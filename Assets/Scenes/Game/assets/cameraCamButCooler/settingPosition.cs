using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingPosition : MonoBehaviour
{
    public Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.position;
        transform.rotation = camera.rotation;
    }
}
