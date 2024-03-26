using System.Collections.Generic;
using NTC.Global.Cache;
using UnityEngine;

namespace CharacterGame.Holders
{
    public class PrefabsHolder : MonoCache
    {
        [SerializeField] private List<GameObject> prefabs;

        public List<GameObject> Prefabs
        {
            get { return prefabs; }
        }
    }
}