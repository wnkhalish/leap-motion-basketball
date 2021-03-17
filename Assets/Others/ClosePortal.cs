using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity;

public class ClosePortal : MonoBehaviour
{

    [SerializeField] GameObject pointA, pointB, portal1, portal2;
    [SerializeField] Vector3 lPalm, rPalm;
    [SerializeField] Vector3 range;
    public float value;
    public bool TwoHand;

    // Use this for initialization
    void Start()
    {
        lPalm = pointA.transform.position;
        rPalm = pointB.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        range = new Vector3();
        range = pointB.transform.position - pointA.transform.position;
        value = Vector3.Magnitude(range);

        if (pointA.transform.position != lPalm || pointB.transform.position != rPalm)
        {
            if (value < 0.02)
            {
                portal1.SetActive(false);
                portal2.SetActive(false);
            }
        }

    }

}