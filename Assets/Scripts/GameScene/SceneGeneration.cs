using CharacterGame.Game.Spawn;
using CharacterGame.Holders;
using NTC.Global.Cache;
using UnityEngine;
using Zenject;

namespace CharacterGame.Game
{
    public class SceneGeneration : MonoCache
    {
        [SerializeField] private Transform spawnPoint;
        private Spawner _spawner;
        private PrefabsHolder _prefabsHolder;

        [Inject]
        private void Construct(PrefabsHolder prefabsHolder)
        {
            _prefabsHolder = prefabsHolder;
        }

        public void Initialize()
        {
            _spawner = new Spawner();
            SpawnPlayer();
        }

        private void SpawnPlayer()
        {
            _spawner.Spawn(_prefabsHolder.Prefabs[GlobalData.CharacterPrefabIndex], spawnPoint);
        }
    }
}