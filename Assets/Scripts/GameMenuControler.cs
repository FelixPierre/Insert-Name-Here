using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuControler : MonoBehaviour
{
    public GameObject gameMenu;
    public Button objectsButton;
    public Button equipButton;
    public Button statusButton;
    public Button exitButton;

    public Button firstPlayer;

    private bool isOpen = false;
    private bool isActiveChildPanel = false;
    private Button lastButton;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isOpen)
            {
                if (isActiveChildPanel)
                {
                    returnButton();
                }
                else
                {
                    closeGameMenu();
                }
                
            }
            else
            {
                openGameMenu();            
            }
        }

    }

    /// <summary>
    /// Open the game menu.
    /// </summary>
    void openGameMenu()
    {
        Time.timeScale = 0;     // Freeze time when opening the menu
        gameMenu.SetActive(true);
        objectsButton.Select();
        lastButton = objectsButton;
        isOpen = true;
    }

    /// <summary>
    /// Close the game menu.
    /// </summary>
    void closeGameMenu()
    {
        gameMenu.SetActive(false);
        Time.timeScale = 1;
        isOpen = false;
    }

    /// <summary>
    /// Select the first player
    /// </summary>
    public void selectFirstPlayer()
    {
        firstPlayer.Select();
        isActiveChildPanel = true;
    }

    /// <summary>
    /// Come back at the last button.
    /// </summary>
    public void returnButton()
    {
        lastButton.Select();
        isActiveChildPanel = false;
    }

    public void activeObjectButton()
    {
        lastButton = objectsButton;
        selectFirstPlayer();
    }

    public void activeEquipButton()
    {
        lastButton = equipButton;
        selectFirstPlayer();
    }

    public void activeStatusButton()
    {
        lastButton = statusButton;
        selectFirstPlayer();
    }

    public void activeExitButton()
    {
        lastButton = exitButton;
        selectFirstPlayer();
    }

}
