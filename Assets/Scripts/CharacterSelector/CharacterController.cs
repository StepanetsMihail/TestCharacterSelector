using CharacterGame.CharacterSelector.Model;
using UnityEngine;

namespace CharacterGame.CharacterSelector.Controller
{
    public class CharacterController
    {
        private CharacterModel _model;

        public CharacterController(CharacterModel model)
        {
            _model = model;
        }

        public GameObject GenerateRandomCharacter()
        {
            return _model.GetRandomCharacter();
        }
    }
}