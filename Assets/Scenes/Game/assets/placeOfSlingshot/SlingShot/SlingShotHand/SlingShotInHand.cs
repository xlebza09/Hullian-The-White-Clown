using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotInHand : MonoBehaviour
{
    public static bool isTook = false;
    private bool workIt = false;
    public Transform firePlace;
    public Transform dropPlace;
    public GameObject bullet;
    public GameObject inFloor;
    // Start is called before the first frame update
    void Start()
    {
        dropPlace = GameObject.Find("dropPlace").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            Instantiate(inFloor, dropPlace.position,dropPlace.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 500);
            this.gameObject.SetActive(false);
        }
        if (workIt && Input.GetKeyDown(KeyCode.Q)){
            Instantiate(bullet, firePlace.position, firePlace.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 2500);
        }
        if (isTook){
            workIt = true;
        }else{
            workIt = false;
        }
    }
}
