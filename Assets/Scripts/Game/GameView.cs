using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using R3;

namespace SaveVillage
{
    public class GameView: MonoBehaviour
    {
        [SerializeField] private Slider _workersCountDown;
        [SerializeField] private Button _buyWorkersButton;
        //[SerializeField] private TMP_Text _workersCountDownText;
        [SerializeField] WorkersView _workersView;

        private IGameViewModel _gameViewModel;
        private IWorkersViewModel _workersViewModel;
        
        public void Init(IGameViewModel model)
        {
            if (model is not IGameViewModel gameViewModel)
                throw new Exception("ViewModel must be IGameViewModel");
            
            _gameViewModel = gameViewModel;
            _workersViewModel = gameViewModel.WorkersViewModel;
            
            _workersView.Init(_workersViewModel);

            //_workersViewModel.WorkersCountDown.Subscribe(value => _workersCountDownText.text = value.ToString());
        }
    }
}