using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetUpMainMenu : MonoBehaviour
{
    public GameObject firstStartObjects;
    public GameObject mainObjects;
    public Text go;
    public Text play;
    public Text tips;
    public Text quit;
    public Text options;
    public Text mainText;
    public Text presents;
    public Text diffText;
    public Text keybindings;
    public Dropdown selectLang;
    public Font englishFont;
    public Font russianFont;
    public Text tipsText;
    public Text[] backButts;
    private bool firStart = false;
    // Start is called before the first frame update
    void Start()
    {
        selectLang.value = (PlayerPrefs.GetString("lang", "EN") == "EN") ? 0 : 1;
        if (PlayerPrefs.HasKey("firStart")){
            firStart = false;
        }else{
            mainObjects.SetActive(false);
            firstStartObjects.SetActive(true);
        }
        PlayerPrefs.SetInt("firStart", 0);
        PlayerPrefs.SetString("lang","EN");
    }

    // Update is called once per frame
    void Update()
    {
        if (Language.curLang == "EN"){
            play.text = "Play";
            tips.text = "Tips";
            quit.text = "Quit";
            options.text = "Options";
            presents.text = "xlebza presents:";
            mainText.text = "At  Hullian";
            keybindings.text = "Throw item -- [E] \n \n Shoot -- [Q] \n \n Do Action -- left mouse button \n \n Turn off/on flashlight -- right mouse button \n \n Go to menu (in game) -- [Z]";
            mainText.font = englishFont;
            diffText.text = "Difficulty:";
            for (int i = 0; i < backButts.Length; i++){
                backButts[i].text = "Back";
            }
            go.text = "Go!";
            tipsText.fontSize = 35;
            tipsText.text = "To be able to open the door, you have to turn black, blue, red, green lever. \n \n Hullian can find you only by see you \n \n If you're playing in extreme, don't be spotted by him, he will get you fast \n \n If extreme looks like easy, you can set the 'Torches are off'. \n \n If you hear footsteps, and the are loud, it mean that Hullian is close. \n \n This place has a many useful items, find them to make passing easier. \n \n Good Luck!..";
        }else{
            diffText.text = "Сложность:";
            go.text = "Поехали!";
            tipsText.fontSize = 31;
            keybindings.text = "Бросить предмет -- [E] \n \n Стрелять -- [Q] \n \n Взаимодействовать -- ЛКМ \n \n ВКЛ/ВЫКЛ фонарик -- ПКМ \n \n Выйти в меню (в время игры) -- [Z]";
            tipsText.text = "Чтобы иметь возможность открыть дверь, вы должны повернуть черный, синий, красный, зеленый рычаг. \n \n Хуллиан может найти вас, только увидев вас \n \n Если вы играете в экстрим, не попадитесь ему на глаза, он вас быстро достанет \n \n Если экстрим кажется легкой, вы можете установить «Факели выключены». \n \n Если вы слышите шаги, и они громкие, значит, Хуллиан близко. \n \n В этом месте много полезных предметов, найдите их, чтобы облегчить прохождение. \n \n Удачи!..";
            mainText.font = russianFont;
            mainText.text = "У Хуллиана";
            presents.text = "xlebza представляет:";
            play.text = "Играть";
            for (int i = 0; i < backButts.Length; i++){
                backButts[i].text = "Назад";
            }
            tips.text = "Подсказки";
            quit.text = "Выйти";
            options.text = "Опции";
        }
        if (selectLang.value == 0){
            PlayerPrefs.SetString("lang", "EN");
            Language.curLang = "EN";
        }else if (selectLang.value == 1){
            PlayerPrefs.SetString("lang", "RU");
            Language.curLang = "RU";
        }
    }
    public void SetLanguage(string lang){
        PlayerPrefs.SetString("lang", lang);
        Language.curLang = lang;
    }
    public void FromLangToMainMenu(){
        firstStartObjects.SetActive(false);
        mainObjects.SetActive(true);
        selectLang.value = (Language.curLang == "EN") ? 0 : 1;
    }
}
