using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsControllerMainMenu : ButtonsController
{
    [SerializeField] private GameObject confirmationWindow;
    [SerializeField] private GameObject mainMenu;

    public void ExitGame()
    {
        mainMenu.SetActive(false);
        confirmationWindow.SetActive(true);
    }

    public void Cancel()
    {
        mainMenu.SetActive(true);
        confirmationWindow.SetActive(false);
    }
    public void AgreeExit()
    {
        Application.Quit();
    }
}
