using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mainScript : MonoBehaviour
{
    public GameObject setting;
    public GameObject tipsObjects;
    public GameObject mainObjects;
    public GameObject prologObjects;
    public GameObject optionObjects;
    public Dropdown diff;
    public Toggle isAlwaysKnows;
    public Toggle isFlash;
    public Toggle darker;
    public Text info;
    public Toggle torchesAreOff;
    public static bool isDarker = false;
    public static bool flash = false;
    public static int diffic = 0;
    public static bool torchesOff = false;
    public static bool always = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        darker.transform.GetChild(1).gameObject.GetComponent<Text>().text = (Language.curLang == "EN") ? "Darker" : "Темнее";
        torchesAreOff.transform.GetChild(1).gameObject.GetComponent<Text>().text = (Language.curLang == "EN") ? "Torches are off" : "Факелы не горят";
        isAlwaysKnows.transform.GetChild(1).gameObject.GetComponent<Text>().text = (Language.curLang == "EN") ? "Hullian always know your location" : "Хуллиан всегда знает твое местоположение";
        isFlash.transform.GetChild(1).gameObject.GetComponent<Text>().text = (Language.curLang == "EN") ? "Flashlight is powerful" : "Фонарик мощный";
        if (Language.curLang == "EN"){
            diff.options[0].text = "Practice";
            diff.options[1].text = "Easy";
            diff.options[2].text = "Normal";
            diff.options[3].text = "Hard";
            diff.options[4].text = "Extreme";
        }else{
            diff.options[0].text = "Практика";
            diff.options[1].text = "Легко";
            diff.options[2].text = "Нормально";
            diff.options[3].text = "Сложно";
            diff.options[4].text = "Экстрим";
        }
        print(diff.options);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        if (diff.value == 0){
            diffic = 0;
            isFlash.interactable = true;
            info.text = (Language.curLang == "EN") ? "Here's no Hullian\n You can explore territory" : "Хуллиан вне локации \n Вы можете исследовать территорию с безопасностью";
            darker.interactable = true;
            isFlash.interactable = true;
            isAlwaysKnows.interactable = false;
        }
        else if (diff.value == 1){
            isAlwaysKnows.interactable = true;
            diffic = 1;
            isFlash.interactable = true;
            info.text = (Language.curLang == "EN") ? "Hullian is slow\nHe has flashlight" : "Хуллиан медленный \n У него есть фонарик";
            darker.interactable = true;
            isFlash.interactable = true;
        }
        else if (diff.value == 2){
            diffic = 2;
            isAlwaysKnows.interactable = true;
            isFlash.interactable = true;
            info.text = (Language.curLang == "EN") ? "Hullian runs a normal speed" : "Хуллиан бежит с нормальной скоростью";
            darker.interactable = true;
            isFlash.interactable = true;
        }
        else if (diff.value == 3){
            isAlwaysKnows.interactable = true;
            isFlash.interactable = true;
            diffic = 3;
            info.text = (Language.curLang == "EN") ? "Hullian is faster than you a bit" : "Хуллиан немного быстрее тебя";
            darker.isOn = true;
            darker.interactable = false;
        }
        else if (diff.value == 4){
            isAlwaysKnows.interactable = true;
            diffic = 4;
            isFlash.isOn = false;
            isFlash.interactable = false;
            darker.isOn = true;
            info.text = (Language.curLang == "EN") ? "Hullian is faster than you a lot\n Better don't be spotted by him" : "Хуллиан намного быстрее тебя \n Лучше не попадайся ему на глаза";
        }
    }
    public void Quit(){
        Application.Quit();
    }
    public void Play(){
        mainObjects.SetActive(false);
        setting.SetActive(true);
    }
    public void Prolog(){
        prologObjects.SetActive(true);
        mainObjects.SetActive(false);
    }
    public void TipsOpen(){
        mainObjects.SetActive(false);
        tipsObjects.SetActive(true);
    }
    public void ToOptions(){
        mainObjects.SetActive(false);
        optionObjects.SetActive(true);
    }
    public void Back(){
        tipsObjects.SetActive(false);
        setting.SetActive(false);
        optionObjects.SetActive(false);
        mainObjects.SetActive(true);
    }
    public void startGame()
    {
        FlashlightBattery.battery = 100.0f;
        GameSceneVars.redLever = false;
        GameSceneVars.blueLever = false;
        GameSceneVars.blackLever = false;
        GameSceneVars.greenLever = false;
        always = isAlwaysKnows.isOn;
        torchesOff = torchesAreOff.isOn;
        flash = isFlash.isOn;
        isDarker = darker.isOn;
        SceneManager.LoadScene("Game");
    }
}
