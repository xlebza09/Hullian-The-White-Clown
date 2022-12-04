using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlackLeverScript : MonoBehaviour
{
    private bool once = false;
    public GameObject animObj;
    private bool canPress = false;
    public Text warn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

        if (canPress){
            warn.color = new Color(255,255,255);
            if (!once)
                warn.text = (Language.curLang == "EN") ? "Turn Lever" : "Активировать рычаг";
            if (Input.GetMouseButtonDown(0) && !once /* && BlockerScript.isRemoved*/)
            {
            once = true;
            animObj.GetComponent<Animator>().SetTrigger("Turn");
            GameSceneVars.blackLever = true;
            }
        }
    }
    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Select"){
            canPress = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Select"){
            canPress = false;
            warn.text = "";
        }
    }
}
