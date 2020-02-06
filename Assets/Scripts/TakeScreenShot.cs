using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Generate a screenshot and save to disk with the name SomeLevel.png.

public class TakeScreenShot : MonoBehaviour
{
    void OnMouseDown()
    {
        ScreenCapture.CaptureScreenshot("Rose Bouquet");
    }
}