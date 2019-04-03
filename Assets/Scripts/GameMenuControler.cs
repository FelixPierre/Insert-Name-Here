using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuControler : MonoBehaviour
{
    public GameObject gameMenu;

    private bool isOpen = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isOpen)
            {
                closeGameMenu();
            }
            else
            {
                openGameMenu();            
            }
        }
    }

    void openGameMenu()
    {
        Time.timeScale = 0;
        gameMenu.SetActive(true);
        isOpen = true;
    }

    void closeGameMenu()
    {
        gameMenu.SetActive(false);
        Time.timeScale = 1;
        isOpen = false;
    }
}
