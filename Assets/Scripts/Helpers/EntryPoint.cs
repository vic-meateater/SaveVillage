using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace SaveVillage
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] GameConfig _gameConfig;
        [SerializeField] GameView _gameView;

        private IGameViewModel _gameViewModel;
        
        private GameModelFactory _gameModelFactory;

        [Inject]
        private void Construct(GameModelFactory gameModelFactory)
        {
            _gameModelFactory = gameModelFactory;
        }

        [Button]
        private void ShowView()
        {
            _gameViewModel = _gameModelFactory.Create(_gameConfig);
            _gameView.Init(_gameViewModel);
        }
    }
}