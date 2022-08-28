using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private GameState _currentState;

    public GameState CurrentState => _currentState;
    
    public bool _isGameStarted => _currentState == GameState.Ingame;
    public static GameStateManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    public void SwitchState(GameState newState)
    {
        _currentState = newState;
    }
}

public enum GameState
{
    Pregame,
    Ingame,
    Endgame
}
public enum EndGameState
{
    Wingame,
    Losegame
}