using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace SaveVillage
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] GameConfig _gameConfig;
        [SerializeField] GameView _gameView;
        
        private GameModelFactory _gameModelFactory;

        [Inject]
        private void Construct(GameModelFactory gameModelFactory)
        {
            _gameModelFactory = gameModelFactory;
        }

        [Button]
        private void ShowView()
        {
            var model = _gameModelFactory.Create(_gameConfig);
            _gameView.Construct(model);
        }
        
        
    }
}