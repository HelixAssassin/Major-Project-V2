using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOpener : MonoBehaviour
{

    public GameObject Button;
    public void OpenButton()
    {
        if (Button != null)
        {
            bool isActive = Button.activeSelf;
            Button.SetActive(!isActive);
        }
    }

}