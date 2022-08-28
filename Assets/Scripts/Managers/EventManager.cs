using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }

    public Action OnGameLoaded;
    public void LoadGame()
    {
        // game state pregame
        GameStateManager.Instance.SwitchState(GameState.Pregame);
        OnGameLoaded?.Invoke();
    }
    public Action OnGameStarted;
    public void StartGame()
    {
        // game state ingame
        OnGameStarted?.Invoke();
    }
    public Action OnGameFinished;
    public void FinishGame()
    {
        // check for win or lose state
        OnGameFinished?.Invoke();
    }

    public Action OnPinned;
    public void Pinned() => OnPinned?.Invoke();
}
