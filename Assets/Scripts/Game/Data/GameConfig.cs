using UnityEngine;

namespace SaveVillage
{
    [CreateAssetMenu(
        fileName = "GameConfig", 
        menuName = "SaveVillage/GameConfig")
    ]
    public class GameConfig : ScriptableObject
    {
        [field: SerializeField] public float WorkersCountDown { get; private set; }
    }
}
