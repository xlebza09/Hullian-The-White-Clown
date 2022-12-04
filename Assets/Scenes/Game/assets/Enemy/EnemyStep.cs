using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyStep : MonoBehaviour
{
    public GameObject main;
    private int count = 0;
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
        SceneManager.LoadScene("MainMenuScene");
    }
}
