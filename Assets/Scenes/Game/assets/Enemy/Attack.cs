using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject player;
    public GameObject main;
    public GameObject mesh;
    public GameObject head;
    public Camera cam;
    public static bool isPlayerDead = false;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.init();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerDead)
        {
            cam.gameObject.transform.rotation = Quaternion.Euler(0, Quaternion.LookRotation(head.gameObject.transform.position - cam.gameObject.transform.position).eulerAngles.y, 0);
        }
    }
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Finish" && !EnemyAIScript.isDead) {
            mesh.transform.rotation = Quaternion.Euler(0,Quaternion.LookRotation(player.transform.position - mesh.transform.position).eulerAngles.y, 0);
            mesh.GetComponent<Animator>().SetTrigger("Attack");
            main.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            player.GetComponent<FirstPersonController>().enabled = false;
            LeanTween.rotate(cam.gameObject, Quaternion.LookRotation(head.gameObject.transform.position - cam.gameObject.transform.position).eulerAngles, 0.4f);
            LeanTween.value(gameObject, 60, 14, 0.5f)/*.setOnComplete(died)*/.setOnUpdate((float val) =>
            {
                cam.fieldOfView = val;
            });
        }
    }
    /*private void died()
    {
        isPlayerDead = true;
    }*/
}
