namespace CharacterGame.Scene.SceneLoader
{
    public class SceneView
    {
        private SceneController _controller;

        public SceneView(SceneController sceneController)
        {
            _controller = sceneController;
        }

        public void LoadScene(SceneState sceneState)
        {
            _controller.LoadScene(sceneState);
        }
    }
}