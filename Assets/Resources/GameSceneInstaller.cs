using CharacterGame.Game;
using CharacterGame.Holders;
using CharacterGame.Scene.SceneLoader;
using Zenject;

public class GameSceneInstaller : MonoInstaller
{
    public PrefabsHolder prefabsHolder;
    public SceneLoader sceneLoader;
    public SceneGeneration sceneGeneration;

    public override void InstallBindings()
    {
        BindingPrefabsHolder();
        BindingSceneLoader();
        BindingSceneGeneration();
    }

    private void BindingPrefabsHolder()
    {
        Container.Bind<PrefabsHolder>().FromInstance(prefabsHolder)
            .AsSingle();
    }

    private void BindingSceneGeneration()
    {
        Container.Bind<SceneGeneration>().FromInstance(sceneGeneration)
            .AsSingle();
    }

    private void BindingSceneLoader()
    {
        Container.Bind<SceneLoader>().FromInstance(sceneLoader)
            .AsSingle();
    }
}