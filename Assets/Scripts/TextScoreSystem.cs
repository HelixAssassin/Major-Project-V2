using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextScoreSystem : MonoBehaviour
{
    public GameObject countText;
    public int theCount;

    void OnTriggerEnter(Collider other)
    {
        theCount += 1;
        countText.GetComponent<Text>().text = "THOUGHTS! " + theCount;
    }
}