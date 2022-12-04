using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorScript : MonoBehaviour
{
    private Animator anim;
    private bool isClosed = true;
    public GameObject cube;
    private bool canOpenOrClose = false;
    public Text warn;
    // Start is called before the first frame update
    void Start()
    {
        warn = GameObject.Find("warnText").GetComponent<Text>();
        anim = cube.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canOpenOrClose){
            warn.text = (Language.curLang == "EN") ? "Door" : "Дверь";
        }
        if (Input.GetMouseButtonDown(0) && canOpenOrClose){
            
            if (isClosed){
                    isClosed = false;
                    Open();
                }else{
                    isClosed = true;
                    Close();
                }
        }
    }
    public void Close(){
        anim.SetTrigger("Close");
    }
    public void Open(){
        anim.SetTrigger("Open");
    }
    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Select"){
                canOpenOrClose = true;
                /*if (isClosed){
                    isClosed = false;
                    Open();
                }else{
                    isClosed = true;
                    Close();
                }*/
            }
        }
        private void OnTriggerExit(Collider other){
            if (other.gameObject.tag == "Select"){
                canOpenOrClose = false;
                warn.text = "";
            }
            if (other.gameObject.tag == "enemy"){
                Close();
            }
        }
        private void OnTriggerEnter(Collider other){
            if (other.gameObject.tag == "enemy"){
                Open();
            }
        }
    }