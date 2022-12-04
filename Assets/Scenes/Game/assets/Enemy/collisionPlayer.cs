using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            EnemyAIScript.isGoingToPlayer = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Player"){
            EnemyAIScript.escaped = true;
            EnemyAIScript.isGoingToPlayer = false;
            EnemyAIScript.escaped = false;
        }
    }
}
