using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuIGameScript : MonoBehaviour
{
    public static bool paused = false;
    public GameObject menuObjects;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FirstPersonController");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            ShowMenu();
        if (paused)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.visible = false;
        }
            

    }
    public void ShowMenu()
    {
        player.GetComponent<FirstPersonController>().enabled = false;
        menuObjects.SetActive(true);
        paused = true;
    }
    public void ReturnToGame()
    {
        player.GetComponent<FirstPersonController>().enabled = true;
        menuObjects.SetActive(false);
        paused = false;
    }
}