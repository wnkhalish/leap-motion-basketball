using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity;

public class ShowPortal : MonoBehaviour
{

    [SerializeField] GameObject pointC, portal1, portal2;
    [SerializeField] Vector3 vecAC, vecAB, pointA, pointB;
    [SerializeField] float magAB, magAC;
    [SerializeField] float dotProduct;
    [SerializeField] float angle = 0;
    [SerializeField] bool firstHalf = false;
    [SerializeField] int circleCounter = 0;

    [SerializeField] GameObject rPalm;

    // Use this for initialization
    void Start()
    {
        pointB = pointC.transform.position;
        pointA = pointC.transform.position - new Vector3(1,0,0);
        portal1.SetActive(false);
        portal2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
 
        pointC.transform.position = new Vector3(rPalm.transform.position.x, rPalm.transform.position.y, rPalm.transform.position.z);
        /**
        pointC.transform.position = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        pointC.transform.position = new Vector3 (pointC.transform.position.x, pointC.transform.transform.position.y, 0);
        **/

        // Calculate the vector of pointA and pointB
        vecAB = pointB - pointA;
        vecAC = pointC.transform.position - pointA;

        // Calculate the magnitude of ab and ac
        magAB = Vector3.Magnitude(vecAB);
        magAC = Vector3.Magnitude(vecAC);

        // Calculate the dot product 
        dotProduct = Vector3.Dot(vecAB, vecAC);

        // Calculate the angle between two vectors
        angle = Mathf.Acos(dotProduct / (magAB * magAC)) * Mathf.Rad2Deg;


        if (angle > 10)
        {
            firstHalf = true;
        }
        if (firstHalf == true)
        {
            firstHalf = false;
            circleCounter++;
        }

        if (circleCounter >= 2 && !portal1.activeSelf && !portal2.activeSelf)
        {

            // Show your portal

            portal1.SetActive(true);
            portal2.SetActive(true);
            circleCounter = 0;

        }




    }
}