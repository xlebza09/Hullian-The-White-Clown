using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotScript : MonoBehaviour
{
    private bool canGrab = false;
    public GameObject door;
    public GameObject slingshot;
    public GameObject slingShotHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSceneVars.isSlingShotOpened){
            Destroy(door);
        }
        if (canGrab && Input.GetMouseButtonDown(0) && GameSceneVars.isSlingShotOpened){
            Destroy(slingshot);
            slingShotHand.SetActive(true);
            SlingShotInHand.isTook = true;
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
        }
    }
}
