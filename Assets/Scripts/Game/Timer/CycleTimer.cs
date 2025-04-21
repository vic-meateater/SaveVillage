using R3;
using UnityEngine;

namespace SaveVillage
{
    public class CycleTimer : IUpdateListener, IGameStartListener, IGamePauseListener, IGameResumeListener
    {
        public readonly ReactiveProperty<bool> IsTimerEnd = new ReactiveProperty<bool>(false);
        
        private float _remainingTime;
        private bool _isPaused;

        public void StartTimer(float cooldownTime)
        {
            _remainingTime = cooldownTime;
            _isPaused = false;
            IsTimerEnd.Value = false;
        }
        
        public void OnUpdateGame(float deltaTime)
        {
            if (_isPaused || IsTimerEnd.Value) 
                return;

            _remainingTime -= deltaTime;
        
            if (_remainingTime <= 0)
            {
                _remainingTime = 0;
                IsTimerEnd.Value = true;
            }
            Debug.Log($"Осталось: {_remainingTime} ");
        }

        public void OnStartGame()
        {
            StartTimer(50f);
        }

        public void OnPauseGame()
        {
            _isPaused = true;
        }

        public void OnResumeGame()
        {
            _isPaused = false;
        }
    }
}