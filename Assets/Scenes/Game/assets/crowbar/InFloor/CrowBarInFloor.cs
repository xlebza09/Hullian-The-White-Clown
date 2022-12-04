using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CrowBarInFloor : MonoBehaviour
{
    private bool canGrab = false;
    public GameObject main;
    public GameObject inHand;
    public GameObject slingshotInHand;
    public Text warn;
    // Start is called before the first frame update
    void Start()
    {

        warn = GameObject.Find("warnText").GetComponent<Text>();
        if (inHand == null){
        inHand = GameObject.Find("crowObj").transform.GetChild(0).gameObject;
        }
        slingshotInHand = GameObject.Find("slingSHOT").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (canGrab){
            print("can grab");
            if (Input.GetMouseButtonDown(0) && !(slingshotInHand.activeSelf)){
                warn.text = "";
                Destroy(main);
                inHand.SetActive(true);
            }
        }
    }
    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Select"){
            canGrab = true;
            warn.text = (Language.curLang == "EN") ? "Crowbar" : "Лом";
            warn.color = new Color(255,255,255);
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Select"){
            canGrab = false;
            warn.text = "";
        }
    }
}
