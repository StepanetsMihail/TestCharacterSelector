using CharacterGame.CharacterSelector.Model;
using CharacterGame.CharacterSelector.View;
using CharacterGame.Holders;
using CharacterGame.Scene.SceneLoader;
using NTC.Global.Cache;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using CharacterController = CharacterGame.CharacterSelector.Controller.CharacterController;

namespace CharacterGame.CharacterSelector.Selector
{
    public class CharacterSelector : MonoCache
    {
        [SerializeField] private Button generateButton;
        [SerializeField] private Button playButton;
        [SerializeField] private Transform spawnPoint;
        private CharacterController _controller;
        private CharacterView _view;
        private PrefabsHolder _prefabsHolder;
        private SceneLoader _sceneLoader;

        [Inject]
        private void Construct(PrefabsHolder prefabsHolder, SceneLoader sceneLoader)
        {
            _prefabsHolder = prefabsHolder;
            _sceneLoader = sceneLoader;
        }

        public void Initialize()
        {
            CharacterModel model = new CharacterModel(_prefabsHolder.Prefabs, spawnPoint);

            _controller = new CharacterController(model);
            _view = new CharacterView();

            _view.OnCharacterGenerated += DisplayCharacter;

            generateButton.onClick.AddListener(GenerateCharacter);
            playButton.onClick.AddListener(PlayGame);
        }

        private void GenerateCharacter()
        {
            _view.GenerateRandomCharacter(_controller);
        }

        private void DisplayCharacter(GameObject character)
        {
            character.SetActive(true);
        }

        private void PlayGame()
        {
            _sceneLoader.LoadScene(SceneState.Game);
        }

        private void OnDestroy()
        {
            generateButton.onClick.RemoveAllListeners();
            playButton.onClick.RemoveAllListeners();
            _view.OnCharacterGenerated -= DisplayCharacter;
        }
    }
}