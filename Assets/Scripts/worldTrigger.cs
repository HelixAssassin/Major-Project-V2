using UnityEngine;
using System.Collections;

public class worldTrigger : MonoBehaviour
{

    private GameObject Text;
    void Start()
    {
        Text = GameObject.Find("Text");
        Text.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WorldText"))
        {
            Text.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("WorldText"))
        {
            Text.gameObject.SetActive(false);
        }
    }
}