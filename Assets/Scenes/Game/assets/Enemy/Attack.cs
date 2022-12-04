using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject player;
    public GameObject main;
    public GameObject mesh;
    public GameObject head;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Finish" && !EnemyAIScript.isDead){
        player.transform.LookAt(head.transform.position);
        main.transform.LookAt(player.transform.position);
        mesh.GetComponent<Animator>().SetTrigger("Attack");
        main.GetComponent<UnityEngine.AI.NavMeshAgent>().Stop();
        player.GetComponent<FirstPersonController>().enabled = false;
        }
    }
}
