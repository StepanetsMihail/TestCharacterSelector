using CharacterGame.CharacterSelector.Selector;
using CharacterGame.Holders;
using CharacterGame.Scene.SceneLoader;
using Zenject;

public class CharacterSelectorSceneInstaller : MonoInstaller
{
    public PrefabsHolder prefabsHolder;
    public SceneLoader sceneLoader;
    public CharacterSelector characterSelector;

    public override void InstallBindings()
    {
        BindingSceneGeneration();
        BindingSceneLoader();
        BindingCharacterSelectorUI();
    }

    private void BindingSceneGeneration()
    {
        Container.Bind<PrefabsHolder>().FromInstance(prefabsHolder)
            .AsSingle();
    }

    private void BindingCharacterSelectorUI()
    {
        Container.Bind<CharacterSelector>().FromInstance(characterSelector)
            .AsSingle();
    }

    private void BindingSceneLoader()
    {
        Container.Bind<SceneLoader>().FromInstance(sceneLoader)
            .AsSingle();
    }
}