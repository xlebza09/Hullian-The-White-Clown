using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneVars : MonoBehaviour
{
    public static bool redLever = false;
    public static bool greenLever = false;
    public static bool blueLever = false;
    public static bool blackLever = false;
    public static bool isSlingShotOpened = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (redLever && blackLever){
            isSlingShotOpened = true;
            print("slingShot opened");
        }
    }
}
