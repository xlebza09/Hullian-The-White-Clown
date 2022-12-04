using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    private bool canDo = false;
    public GameObject lattice;
    public GameObject main;
    public GameObject otmuchFull;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canDo && Input.GetMouseButtonDown(0)){
            if (OpenLatticeScript.hasTook){
                Destroy(main);
                Destroy(otmuchFull);
                lattice.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Select"){
            canDo = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Select"){
            canDo = false;
        }
    }
}
