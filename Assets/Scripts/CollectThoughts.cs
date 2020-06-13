using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectThoughts : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        TextScoreSystem.theCount += 1;
    }
}