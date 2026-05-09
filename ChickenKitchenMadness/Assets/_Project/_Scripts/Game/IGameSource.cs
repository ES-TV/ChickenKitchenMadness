using System;

public interface IGameSource
{
    int CurrentSanity { get; }

    GameState CurrentGameState { get; }

    event Action<GameState> OnGameStateChanged;

    void ChangeGameState(GameState newState);

}

public enum GameState
{
    Menu, InGame, OnPause, GameOver
}