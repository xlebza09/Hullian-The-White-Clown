using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Hide());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Hide()
    {
        yield return new WaitForSeconds(9);
        Destroy(this.gameObject);
    }
}
