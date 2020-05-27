using System.Collections;
using UnityEngine;

public class TriggerObject : MonoBehaviour {

    public GameObject textObject;


    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ShowAndHide(textObject , 20.0f)); // 1 second
    }
    IEnumerator ShowAndHide(GameObject go, float delay)
    {
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);

    }
}