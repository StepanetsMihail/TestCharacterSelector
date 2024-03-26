using CharacterGame.CharacterSelector.Selector;
using CharacterGame.Global;
using Zenject;

public class GlobalCharacterSelectorEntryPoint : GlobalEntryPointBase
{
    private CharacterSelector _characterSelector;

    [Inject]
    private void Construct(CharacterSelector characterSelector)
    {
        _characterSelector = characterSelector;
    }

    protected override void Start()
    {
        base.Start();
        _characterSelector.Initialize();
    }
}