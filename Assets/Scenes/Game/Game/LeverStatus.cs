using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LeverStatus : MonoBehaviour
{
    public Text green;
    public Text red;
    public Text blue;
    public Text black;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSceneVars.redLever){
            red.text = (Language.curLang == "EN") ? "Red Lever: On" : "Красный рычаг: Активен";
            red.color = new Color(0,255,0);
        }else{
            red.text = (Language.curLang == "EN") ? "Red Lever: Off" : "Красный рычаг: Неактивен";
            red.color = new Color(255,0,0);
        }
        if (GameSceneVars.greenLever){
            green.text = (Language.curLang == "EN") ? "Green Lever: On" : "Зелёный рычаг: Активен";
            green.color = new Color(0,255,0);
        }else{
            green.text = (Language.curLang == "EN") ? "Green Lever: Off" : "Зелёный рычаг: Неактивен";
            green.color = new Color(255,0,0);
        }
        if (GameSceneVars.blueLever){
            blue.text = (Language.curLang == "EN") ? "Blue Lever: On" : "Синий рычаг: Активен";
            blue.color = new Color(0,255,0);
        }else{
            blue.text = (Language.curLang == "EN") ? "Blue Lever: Off" : "Синий рычаг: Неактивен";
            blue.color = new Color(255,0,0);
        }
        if (GameSceneVars.blackLever){
            black.text = (Language.curLang == "EN") ? "Black Lever: On" : "Черный рычаг: Активен";
            black.color = new Color(0,255,0);
        }else{
            black.text = (Language.curLang == "EN") ? "Black Lever: Off" : "Черный рычаг: Неактивен";
            black.color = new Color(255,0,0);
        }
    }
}
