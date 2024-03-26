using System;
using System.Collections.Generic;
using NTC.Global.Cache;
using UnityEngine;

namespace CharacterGame.Scene.SceneLoader
{
    public class SceneLoader : MonoCache
    {
        [SerializeField] private List<SceneStateInfo> sceneIndexToSceneState;
        private SceneController _controller;
        private SceneView _view;

        private void Start()
        {
            SceneModel model = new SceneModel(sceneIndexToSceneState);

            _controller = new SceneController(model);
            _view = new SceneView(_controller);
        }

        public void LoadScene(SceneState sceneState)
        {
            _view.LoadScene(sceneState);
        }

        [Serializable]
        public class SceneStateInfo
        {
            public SceneState sceneState;
            public string sceneName;
        }
    }
}