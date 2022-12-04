using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpGame : MonoBehaviour
{
    public GameObject[] points;
    public GameObject flashlightPlayer;
    public GameObject enemy;
    public GameObject[] diffPlanks;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < points.Length; i++){
            if (mainScript.torchesOff){
                Destroy(points[i].gameObject);
            }
            if (mainScript.isDarker && !(mainScript.diffic == 4) && !(mainScript.torchesOff)){
                points[i].GetComponent<Light>().intensity = 0.3f;
            }else if(!(mainScript.diffic == 4) && !(mainScript.torchesOff)){
                points[i].GetComponent<Light>().intensity = 1f;
            }
        }
        if (!mainScript.flash){
        flashlightPlayer.GetComponent<Light>().intensity = 0.7f;
        }else{
            flashlightPlayer.GetComponent<Light>().intensity = 2;
        }
        if (mainScript.diffic == 0){
            Destroy(enemy);
        }
        else if (mainScript.diffic == 1){
            diffPlanks[0].SetActive(true);
            enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 1.5f;
        }else if (mainScript.diffic == 2){
            diffPlanks[1].SetActive(true);
            enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3.5f;
        }else if (mainScript.diffic == 3){
            diffPlanks[2].SetActive(true);
            enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 4.5f;
        }else if (mainScript.diffic == 4){
            diffPlanks[3].SetActive(true);
            enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 6f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
