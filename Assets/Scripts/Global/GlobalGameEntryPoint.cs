using CharacterGame.Game;
using Zenject;

namespace CharacterGame.Global
{
    public class GlobalGameEntryPoint : GlobalEntryPointBase
    {
        private SceneGeneration _sceneGeneration;

        [Inject]
        private void Construct(SceneGeneration sceneGeneration)
        {
            _sceneGeneration = sceneGeneration;
        }
        
        protected override void Start()
        {
            base.Start();
            _sceneGeneration.Initialize();
        }
    }
}