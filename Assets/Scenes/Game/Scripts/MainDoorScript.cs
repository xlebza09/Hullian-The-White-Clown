using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainDoorScript : MonoBehaviour
{
    public Text warn;
    private bool canInteract = false;
    private bool planksAreRemoved = false;
    public GameObject[] keepersEasy;
    public GameObject[] keepersNormal;
    public GameObject[] keepersHard;
    public GameObject[] keepersExtreme;
    private int curDiff = 0;
    // Start is called before the first frame update
    void Start()
    {
        curDiff = mainScript.diffic;
        if (curDiff == 0)
        {
            planksAreRemoved = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (curDiff == 1)
        {
            planksAreRemoved = (keepersEasy[0] == null && keepersEasy[1] == null);
        }else if (curDiff == 2)
        {
            planksAreRemoved = keepersNormal[0] == null && keepersNormal[1] == null && keepersNormal[2] == null && keepersNormal[3] == null && keepersNormal[4] == null && keepersNormal[5] == null && keepersNormal[6] == null && keepersNormal[7] == null;
        }else if (curDiff == 3)
        {
            planksAreRemoved = keepersHard[0] == null && keepersHard[1] == null && keepersHard[2] == null && keepersHard[3] == null && keepersHard[4] == null && keepersHard[5] == null && keepersHard[6] == null && keepersHard[7] == null && keepersHard[8] == null && keepersHard[9] == null && keepersHard[10] == null && keepersHard[11] == null;
        }else if (curDiff == 4)
        {
            planksAreRemoved = keepersExtreme[0] == null && keepersExtreme[1] == null && keepersExtreme[2] == null && keepersExtreme[3] == null && keepersExtreme[4] == null && keepersExtreme[5] == null && keepersExtreme[6] == null && keepersExtreme[7] == null && keepersExtreme[8] == null && keepersExtreme[9] == null && keepersExtreme[10] == null && keepersExtreme[11] == null;
        }
        if (planksAreRemoved)
        {
            print("Planks are removed!");
        }
        if (canInteract){
        if (GameSceneVars.redLever && GameSceneVars.greenLever && GameSceneVars.blueLever && GameSceneVars.blackLever && planksAreRemoved){
            if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("WinScene");
            }
        }else{
            if (Input.GetMouseButtonDown(0)){
                warn.text = (Language.curLang == "EN") ? "To open the door you need to switch every lever" : "Чтобы открыть главную дверь, нужно активировать каждый рычаг";
            }
        }
        }
        
    }
    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Select"){
            canInteract = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Select"){
            canInteract = false;
            warn.text = "";
        }
    }
}
