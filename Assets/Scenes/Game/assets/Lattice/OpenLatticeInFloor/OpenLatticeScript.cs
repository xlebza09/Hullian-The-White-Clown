using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenLatticeScript : MonoBehaviour
{
    private bool canDo = false;
    public GameObject otmuchInHand;
    public GameObject main;
    public Text warn;
    public static bool hasTook = false;
    // Start is called before the first frame update
    void Start()
    {
        otmuchInHand = GameObject.Find("otmuchObject").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (canDo && Input.GetMouseButtonDown(0)){
            otmuchInHand.SetActive(true);
            Destroy(main);
            hasTook = true;
            warn.text = "";
        }
    }
    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Select"){
            canDo = true;
            warn.text = (Language.curLang == "EN") ? "Master Key" : "Отмычка";
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Select"){
            canDo = false;
            warn.text = "";
        }
    }
}
