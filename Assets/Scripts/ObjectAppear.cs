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

    void OnCollisionEnter(Collision collision)
    {

        gameObject.GetComponent<Text>().enabled = true;

    }
}
