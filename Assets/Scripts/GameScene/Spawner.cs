using UnityEngine;

namespace CharacterGame.Game.Spawn
{
    public class Spawner
    {
        public void Spawn(GameObject prefab, Transform spawnPoint)
        {
            GameObject.Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
