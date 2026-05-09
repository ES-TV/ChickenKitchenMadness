using System;
using UnityEngine;

public class GameManager : Singleton<IGameSource>, IGameSource
{
    public int CurrentSanity => _maxSanity;  // Propiedad pública de solo lectura que devuelve el valor de la variable privada

    public GameState CurrentGameState { get; private set; }  // Propiedad pública de solo lectura que se puede establecer solo dentro de la clase
    private int _maxSanity = 100;  // Las variables privadas van con guion bajo por convención

    public event Action<GameState> OnGameStateChanged;

    public void ChangeGameState(GameState newState)
    {
        if (CurrentGameState == newState) return;
        CurrentGameState = newState;
        OnGameStateChanged?.Invoke(CurrentGameState);
    }

    private void SetPauseState()
    {
        switch (CurrentGameState)
        {
            case GameState.Menu:
                // Lógica para el estado de menú
                ChangeGameState(GameState.Menu);
                break;
            case GameState.InGame:
                // Lógica para el estado de juego
                ChangeGameState(GameState.InGame);
                break;
            case GameState.OnPause:
                // Lógica para el estado de pausa
                ChangeGameState(GameState.OnPause);
                break;
            case GameState.GameOver:
                // Lógica para el estado de juego terminado
                ChangeGameState(GameState.GameOver);
                break;
        }
    }
}
