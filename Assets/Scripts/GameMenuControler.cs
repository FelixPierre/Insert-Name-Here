using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuControler : MonoBehaviour
{
    public GameObject gameMenu;
    public Button objectsButton;

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
        objectsButton.Select();
        isOpen = true;
    }

    void closeGameMenu()
    {
        gameMenu.SetActive(false);
        Time.timeScale = 1;
        isOpen = false;
    }
}
