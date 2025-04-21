using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace SaveVillage
{
    public class GameCycle : MonoBehaviour
    {
        private List<IGameListener> _gameListeners;
        private List<IUpdateListener> _updateListeners;

        [Inject]
        private void Construct(List<IGameListener> gameListeners, List<IUpdateListener> updateListeners)
        {
            _gameListeners = gameListeners;
            _updateListeners = updateListeners;
        }
        
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
        
        [BoxGroup("Game Cycle")]
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
            var deltaTime = Time.deltaTime;
            if (_updateListeners == null) return;
            foreach (var updateable in _updateListeners)
            {
                updateable?.OnUpdateGame(deltaTime);
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