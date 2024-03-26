using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace CharacterGame.Scene.SceneLoader
{
    public class SceneController
    {
        private SceneModel _model;

        public SceneController(SceneModel model)
        {
            _model = model;
        }

        public void LoadScene(SceneState sceneState)
        {
            Dictionary<SceneState, string> sceneStateToSceneName = _model.GetSceneStateToSceneNameMapping();

            if (sceneStateToSceneName.TryGetValue(sceneState, out string sceneName))
            {
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                Debug.LogError($"Scene name for state {sceneState} not found.");
            }
        }
    }
}