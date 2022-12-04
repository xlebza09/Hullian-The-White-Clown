using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killIt : MonoBehaviour
{ 
    public GameObject main;
    private bool darking = false;
    public Image dark;
    void Update(){
        if (darking){
            int count = 0;
            count++;
            dark.color = new Color(0,0,0,count);
        }
    }
    public void kill(){
        //darking = true;
        Application.Quit();
    }
    private void OnCollisionEnter(Collision other){
        print("it works");
        if (other.gameObject.tag == "bullet"){
            print("he checked and it works");
            EnemyAIScript.isDead = true;
        }
    }
}
