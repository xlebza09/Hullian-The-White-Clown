using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject flashLight;
    public static bool isFlashLightOn = true;

    // Update is called once per frame
    void Update()
    {
        if (isFlashLightOn)
        {
            flashLight.GetComponent<Light>().enabled = true;
        }else
        {
            flashLight.GetComponent<Light>().enabled = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (isFlashLightOn)
            {
                isFlashLightOn = true;
            }
            else
            {
                isFlashLightOn = false;
            }
            isFlashLightOn = !isFlashLightOn;
        }
    }
}
