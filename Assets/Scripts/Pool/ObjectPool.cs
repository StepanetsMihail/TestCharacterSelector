using System.Collections.Generic;
using UnityEngine;

namespace CharacterGame.Pool
{
    public class ObjectPool
    {
        private List<GameObject> _objects = new List<GameObject>();

        public void InitializePool(List<GameObject> characters, Transform spawnPoint)
        {
            foreach (GameObject character in characters)
            {
                CreateObject(character, spawnPoint);
            }
        }

        private void CreateObject(GameObject prefab, Transform spawnPoint)
        {
            GameObject newObject = GameObject.Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
            newObject.SetActive(false);
            _objects.Add(newObject);
        }

        public int GetPoolCount()
        {
            return _objects.Count;
        }

        public GameObject GetObject(int index)
        {
            return _objects[index];
        }

        public void ReturnObject(int index)
        {
            _objects[index].SetActive(false);
        }
    }
}