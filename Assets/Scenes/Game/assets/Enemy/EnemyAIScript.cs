using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAIScript : MonoBehaviour
{
    public static NavMeshAgent ai;
    private Animator anim;
    public GameObject[] targets;
    public GameObject mesh;
    public static bool isGoingToPlayer;
    public GameObject player;
    public static bool escaped = false;
    public Transform respawnPlace;
    public GameObject hullianRagPrefab;
    public static bool isDead;
    private bool count = false;
    public static bool isMove = false;
    public GameObject pointLight;
    // Start is called before the first frame update
    void Start()
    {
        if (mainScript.diffic == 1)
        {
            pointLight.SetActive(true);
        }
        else
        {
            pointLight.SetActive(false);
        }
        ai = GetComponent<NavMeshAgent>();
       anim = mesh.GetComponent<Animator>();
       ai.SetDestination(targets[0].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        isMove = !(ai.velocity.magnitude < 1.0f);
        if (isDead && !count){
            count = true;
            StartCoroutine(Die());
        }
        if (mainScript.always){
            isGoingToPlayer = true;
        }
        if (isGoingToPlayer){
            ai.SetDestination(player.transform.position);
        }else if (escaped){
            StartCoroutine(toOne());
        }
        anim.SetBool("IsRunning",isMove); // animation walk and idle
    }
        private void OnTriggerEnter(Collider other){
        if (other.gameObject.name == "1" && !isGoingToPlayer){
            StartCoroutine(toTwo());
        }
        if (other.gameObject.name == "2" && !isGoingToPlayer){
            StartCoroutine(toThree());
        }
        if (other.gameObject.name == "3" && !isGoingToPlayer){
            StartCoroutine(toFour());
        }
        if (other.gameObject.name == "4" && !isGoingToPlayer){
            StartCoroutine(toFive());
        }
        if (other.gameObject.name == "5" && !isGoingToPlayer){
            StartCoroutine(toOne());
        }
    }

    IEnumerator toOne(){
        yield return new WaitForSeconds(4);
        ai.SetDestination(targets[0].transform.position);
    }
    IEnumerator toTwo(){
        yield return new WaitForSeconds(4);
        ai.SetDestination(targets[1].transform.position);
    }
    IEnumerator toThree(){
        yield return new WaitForSeconds(4);
        ai.SetDestination(targets[2].transform.position);
    }
    IEnumerator toFour(){
        yield return new WaitForSeconds(4);
        ai.SetDestination(targets[3].transform.position);
    }
    IEnumerator toFive(){
        yield return new WaitForSeconds(4);
        ai.SetDestination(targets[4].transform.position);
    }
    IEnumerator Die(){
        isDead = true;
        GameObject instant = Instantiate(hullianRagPrefab, mesh.transform.position, mesh.transform.rotation);
        GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        mesh.SetActive(false);
        instant.SetActive(true);
        yield return new WaitForSeconds(20);
        this.gameObject.transform.position = respawnPlace.position;
        GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        mesh.SetActive(true);
        isDead = false;
        Destroy(instant);
        count = false;
    }
    /*public static void GoToDroppedItem(Vector3 position)
    {
        ai.SetDestination(position);
    } */
}