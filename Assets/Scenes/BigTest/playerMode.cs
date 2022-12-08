using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMode : MonoBehaviour
{
    private string curMode = "notControl";
    public GameObject player;
    public GameObject cam;
    public Transform target;
    public KeyCode off;
    public KeyCode on;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (curMode == "notControl")
        {
            player.GetComponent<FirstPersonController>().enabled = false;
            cam.transform.rotation = Quaternion.Euler(0, Quaternion.LookRotation(target.position).eulerAngles.y, 0);
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (curMode == "Control")
            player.GetComponent<FirstPersonController>().enabled = true;
        if (Input.GetKeyDown(on))
            curMode = "notControl";
        else if (Input.GetKeyDown(off))
            curMode = "Control";
    }
}
