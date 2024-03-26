using System.Collections.Generic;
using CharacterGame.Pool;
using UnityEngine;

namespace CharacterGame.CharacterSelector.Model
{
    public class CharacterModel
    {
        private ObjectPool _characterPool;
        private int _previousIndex;

        public CharacterModel(List<GameObject> characters, Transform spawnPoint)
        {
            _characterPool = new ObjectPool();

            _characterPool.InitializePool(characters, spawnPoint);
        }

        public GameObject GetRandomCharacter()
        {
            _characterPool.ReturnObject(_previousIndex);
            int randomIndex = Random.Range(0, _characterPool.GetPoolCount());
            _previousIndex = randomIndex;
            SetCharacterIndex(randomIndex);
            return _characterPool.GetObject(randomIndex);
        }

        private void SetCharacterIndex(int index)
        {
            GlobalData.CharacterPrefabIndex = index;
        }
    }
}