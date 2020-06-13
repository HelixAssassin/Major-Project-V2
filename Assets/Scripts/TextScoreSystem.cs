using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextScoreSystem : MonoBehaviour
{
    public GameObject countText;
    public static int theCount;

    void OnTriggerEnter(Collider other)
    {
        countText.GetComponent<Text>().text = "THOUGHTS: " + theCount;
    }
}