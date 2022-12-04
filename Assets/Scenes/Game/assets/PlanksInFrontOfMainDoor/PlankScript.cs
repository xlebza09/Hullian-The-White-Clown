using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankScript : MonoBehaviour
{
    private bool canTakeOff;
    public GameObject crowbarInHand;
    public GameObject[] keepers;
    // Start is called before the first frame update
    void Start()
    {
        crowbarInHand = GameObject.Find("crowObj").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (canTakeOff && crowbarInHand.activeSelf){
            if (Input.GetMouseButtonDown(0)){
                for (int i = 0; i < keepers.Length; i++){
                    Destroy(keepers[i]);
                }
            }
        }
    }
    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Select"){
            canTakeOff = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Select"){
            canTakeOff = false;
        }
    }
}
