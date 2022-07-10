using System;
using Menus;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public DataInstaller dataInstaller;
    public ArtInstaller artInstaller;
    public OverridesInstaller overridesInstaller;

    public EndGameStatus Status { get; private set; }

    private void Start()
    {
        EventManager.OnEndGame.Subscribe(status =>
        {
            Status = status;

            if (status.win)
                GUIManager.Open<EndGameWinMenu>();
            else
                GUIManager.Open<EndGameLoseMenu>();
        });
    }

    private void OnDestroy()
    {
        EventManager.Reset();
    }
}
