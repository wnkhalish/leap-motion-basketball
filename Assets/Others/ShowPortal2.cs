using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPortal2 : MonoBehaviour
{

    [SerializeField] GameObject pointA,inputObject,portal1,portal2;
    [SerializeField] Vector3 vecAC, vecAB, pointB, pointC;
    [SerializeField] float magAB, magAC;
    [SerializeField] float dotProduct;
    [SerializeField] float angle = 0;
    [SerializeField] bool firstHalf = false;
    [SerializeField] int circleCounter = 0;


    // Use this for initialization
    void Start()
    {
        pointB = inputObject.transform.position;
        portal1.SetActive(false);
        portal2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pointC = new Vector3(inputObject.transform.position.x, inputObject.transform.position.y,0);

        vecAB = pointB - pointA.transform.position;
        vecAC = pointC - pointA.transform.position;
        vecAB.z = 0;
        vecAC.z = 0;

        // Calculate the magnitude of ab and ac
        magAB = Vector3.Magnitude(vecAB);
        magAC = Vector3.Magnitude(vecAC);

        // Calculate the dot product 
        dotProduct = Vector3.Dot(vecAB, vecAC);

        // Calculate the angle between two vectors
        angle = Mathf.Acos(dotProduct / (magAB * magAC)) * Mathf.Rad2Deg;


        if (angle > 160)
        {
            firstHalf = true;
        }

        if (firstHalf == true && angle < 20)
        {
            firstHalf = false;
            circleCounter++;
        }

        if (circleCounter >= 2)
        {

            // Show your portal

            portal1.SetActive(true);
            portal2.SetActive(true);
            circleCounter = 0;

        }




    }
}