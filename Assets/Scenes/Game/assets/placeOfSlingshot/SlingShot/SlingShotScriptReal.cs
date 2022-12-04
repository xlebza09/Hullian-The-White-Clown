using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlingShotScriptReal : MonoBehaviour
{
    private bool canGrab = false;
    public GameObject slingshot;
    public GameObject slingShotHand;
    public GameObject crowbarInHand;
    public GameObject door;
    public Text warn;
    // Start is called before the first frame update
    void Start()
    {
        warn = GameObject.Find("warnText").GetComponent<Text>();
        crowbarInHand = GameObject.Find("crowObj").transform.GetChild(0).gameObject;
        slingshot.transform.localScale = new Vector3(0.1868312f,0.1868312f,0.1868312f);
       if (slingShotHand == null){
        slingShotHand = GameObject.Find("slingSHOT").transform.GetChild(0).gameObject;
       }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSceneVars.isSlingShotOpened){
            Destroy(door);
        }        if (canGrab && Input.GetMouseButtonDown(0)){
            print("can");
            if (GameSceneVars.isSlingShotOpened && !(crowbarInHand.activeSelf)){
            warn.text = "";
            Destroy(slingshot);
            slingShotHand.SetActive(true);
            print("you grabbed");
            SlingShotInHand.isTook = true;
        }}
        if (canGrab && GameSceneVars.isSlingShotOpened){
            warn.text = (Language.curLang == "EN") ? "Slingshot" : "Рогатка";
            warn.color = new Color(255,255,255);
        }
    }
    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Select"){
            canGrab = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Select"){
            canGrab = false;
            warn.text = "";
        }
    }
}
