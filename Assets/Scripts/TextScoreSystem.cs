using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int theCount;

    void OnTriggerEnter(Collider other)
    {
        theCount += 1;
        scoreText.GetComponent<Text>().text = "0/! " + theCount;
    }
}