using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using R3;
using Zenject;

namespace SaveVillage
{
    public class GameView: MonoBehaviour
    {
        [SerializeField] private Slider _workersCountDown;
        [SerializeField] private Button _buyWorkersButton;
        [SerializeField] private TMP_Text _workersCountDownText;

        private IGameViewModel _gameViewModel;
        
        public void Construct(IGameViewModel model)
        {
            if (model is not IGameViewModel gameViewModel)
                throw new Exception("ViewModel must be IGameViewModel");
            
            _gameViewModel = gameViewModel;

            _gameViewModel.WorkersCountDown.Subscribe(value => _workersCountDownText.text = value.ToString());
        }
    }
}