using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollCookie : MonoBehaviour
{
    public GameObject hullianRag;
    public GameObject mesh;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        

        hullianRag.transform.position = mesh.transform.position;
        hullianRag.transform.rotation = mesh.transform.rotation;
    }
}
