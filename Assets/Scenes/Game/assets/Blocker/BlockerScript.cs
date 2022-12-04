using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerScript : MonoBehaviour
{
    private bool canInteract = false;
    public GameObject[] objsToRemove;
    public static bool isRemoved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canInteract)
        {
            if (Input.GetMouseButtonDown(0) && InHandCrowbar.isTook)
            {
                RemoveThings();
                isRemoved = true;
            }
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Select")
                canInteract = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Select")
            canInteract = false;
    }
    public void RemoveThings()
    {
        for (int i = 0; i < objsToRemove.Length; i++)
            Destroy(objsToRemove[i]);
    }
}
