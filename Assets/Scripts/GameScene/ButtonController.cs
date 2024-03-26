using CharacterGame.Scene.SceneLoader;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace CharacterGame.Game.UI
{
    public class ButtonController : MonoBehaviour
    {
        [SerializeField] private Button back;
        private SceneLoader _sceneLoader;

        [Inject]
        private void Construct(SceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        private void Start()
        {
            back.onClick.AddListener(LoadMainScene);
        }

        private void LoadMainScene()
        {
            _sceneLoader.LoadScene(SceneState.CharacterSelector);
        }

        private void OnDestroy()
        {
            back.onClick.RemoveAllListeners();
        }
    }
}