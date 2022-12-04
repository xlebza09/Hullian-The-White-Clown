using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BatteryChargerScript : MonoBehaviour
{
    private bool canInteract = false;
    private int uses = 5;
    public TextMeshPro remain;
    public TextMeshPro batteryCharger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        batteryCharger.text = (Language.curLang == "EN") ? "Battery Charger" : "Зарядная станция";
        

        if (canInteract && Input.GetMouseButtonDown(0))
        {
            if (!(uses == 0)){
                FlashlightBattery.battery = 100;
                uses--;
            }
        }
        remain.text = (Language.curLang == "EN") ? "Left: " + uses.ToString() : "Осталось: " + uses.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Select")
        {
            canInteract = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Select")
        {
            canInteract = false;
        }
    }
}
