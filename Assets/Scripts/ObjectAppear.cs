using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectAppear : MonoBehaviour
{
    void Start()
    {

        gameObject.GetComponent<Text>().enabled = false;

    }

    void OnTriggerEnter(Collider other)
    {

        gameObject.GetComponent<Text>().enabled = true;

    }

    //void OnTriggerExit(Collider other)
    //{
        //gameObject.GetComponent<Text>().enabled = false;
    //}
}