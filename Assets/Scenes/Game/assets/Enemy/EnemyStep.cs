using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyStep : MonoBehaviour
{
    public GameObject main;
    private int count = 0;
    public GameObject player;
    public Camera cam;
    private bool countBool = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count > 80){
            count = 0;
            //if (main.GetComponent<NavMeshAgent>().)
            if (EnemyAIScript.isMove)
                main.GetComponent<AudioSource>().Play();
        }
    }
    public void PunchMoment()
    {
        Attack.isPlayerDead = false;
        cam.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        LeanTween.rotateX(player, -67, 0.4f);
        LeanTween.cancel(gameObject);
        //player.transform.rotation = Quaternion.Euler(-67, 0, 0); 
        player.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * 300);
        player.GetComponent<Rigidbody>().AddRelativeForce(Vector3.right * 300);
        if (!countBool)
        {
            LeanTween.value(gameObject, 14, 60, 0.5f).setOnUpdate((float val) =>
            {
                cam.fieldOfView = val;
            });
            countBool = true;
        }
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        SetDarkness.blackout();
    }
}
