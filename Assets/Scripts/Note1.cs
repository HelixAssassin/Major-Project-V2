using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note1 : MonoBehaviour
{

    public PopUpImage popupImage;
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameContorller");
        popupImage = gameController.GetComponent<PopUpImage>();

    }

    // Update is called once per frame
    void Update()
    {
        popupImage.Open("NameOfTexture", "This is some text");
    }

}