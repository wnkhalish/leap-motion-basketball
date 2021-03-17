using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public GameObject objToTP;
	public GameObject tpLoc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
	

        if(other.gameObject.tag == "Object"){
		objToTP.transform.position = tpLoc.transform.position;
	}
    }
}
