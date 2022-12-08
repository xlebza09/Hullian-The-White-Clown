using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SetDarkness : MonoBehaviour
{
    public static Image dark;
    // Start is called before the first frame update
    void Start()
    {
        dark = GameObject.Find("Darkness").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void blackout()
    {
        dark.GetComponent<Animator>().SetTrigger("blackout");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
