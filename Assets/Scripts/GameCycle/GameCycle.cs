using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace SaveVillage
{
    public class GameCycle : MonoBehaviour
    {
        private List<IGameListener> _gameListeners;
        private List<IUpdateListener> _updateListeners;

        [BoxGroup("Game Cycle")]
        [Button("Start Game")]
        private void StartGame()
        {
            Debug.Log("Starting Game");
            
            if (_gameListeners == null) return;
            foreach (var listener in _gameListeners)
            {
                if (listener is IGameStartListener gameStartListener)
                    gameStartListener.OnStartGame();
            }
        }

        [Button("Pause Game")]
        private void PauseGame()
        {
            Debug.Log("Pause Game");
            
            if (_gameListeners == null) return;
            foreach (var listener in _gameListeners)    
            {
                if (listener is IGamePauseListener gamePauseListener)
                    gamePauseListener.OnPauseGame();
            }
        }

        [Button]
        private void ResumeGame()
        {
            Debug.Log("Resume Game");
            
            if (_gameListeners == null) return;
            foreach (var listener in _gameListeners)
            {
                if (listener is IGameResumeListener gameResumeListener)
                    gameResumeListener.OnResumeGame();
            }
        }

        [Button]
        private void StopGame()
        {
            Debug.Log("Stop Game");
            
            if (_gameListeners == null) return;
            foreach (var listener in _gameListeners)
            {
                if(listener is IGameStopListener gameStopListener)
                    gameStopListener.OnStopGame();
            }
        }

        private void Update()
        {
            if (_updateListeners == null) return;
            foreach (var updateable in _updateListeners)
            {
                updateable?.OnUpdateGame();
            }
        }

        public void AddListener(IGameListener listener)
        {
            _gameListeners.Add(listener);
            if(listener is IUpdateListener updateListener)
                _updateListeners.Add(updateListener);
        }
    }
}