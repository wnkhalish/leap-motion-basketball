using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{

    public Transform portalOutObj;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "portal1")
        {
            GetComponent<Transform>().position = portalOutObj.position;
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.z, 0, 0);
        }
    }
}
