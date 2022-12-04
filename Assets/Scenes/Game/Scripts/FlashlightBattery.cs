using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlashlightBattery : MonoBehaviour
{
    public static float battery = 100.0f;
    public static float minusBatteryPerSecond = 2f;
    public Slider bar;
    public Text batteryText;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        batteryText.text = (Language.curLang == "EN") ? "Flashlight's battery:" : "Батарея фонарика:";
        if (PlayerScript.isFlashLightOn)
            battery -= minusBatteryPerSecond * Time.deltaTime;
        if (battery <= 0)
            PlayerScript.isFlashLightOn = false;
        bar.value = battery;

        if (!(Language.curLang == "EN"))
            batteryText.fontSize = 16;
        else
            batteryText.fontSize = 20;
    }
}
