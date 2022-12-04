using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InHandCrowbar : MonoBehaviour
{
    public static bool isTook = false;
    public GameObject crowbarInFloor;
    public Camera cam;
    public GameObject mesh;
    public Transform dropPlace;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            Instantiate(crowbarInFloor, dropPlace.position, dropPlace.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 500);
            isTook = false;
            this.gameObject.SetActive(false);
        }
    }
}
