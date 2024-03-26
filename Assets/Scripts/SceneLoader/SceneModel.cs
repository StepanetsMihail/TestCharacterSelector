using System.Collections.Generic;

namespace CharacterGame.Scene.SceneLoader
{
    public class SceneModel
    {
        private List<SceneLoader.SceneStateInfo> _sceneIndexToSceneState;

        public SceneModel(List<SceneLoader.SceneStateInfo> sceneIndexToSceneState)
        {
            _sceneIndexToSceneState = sceneIndexToSceneState;
        }

        public Dictionary<SceneState, string> GetSceneStateToSceneNameMapping()
        {
            Dictionary<SceneState, string> mapping = new Dictionary<SceneState, string>();

            foreach (var sceneInfo in _sceneIndexToSceneState)
            {
                mapping[sceneInfo.sceneState] = sceneInfo.sceneName;
            }

            return mapping;
        }
    }
}