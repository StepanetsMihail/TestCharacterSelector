using System;
using UnityEngine;
using CharacterController = CharacterGame.CharacterSelector.Controller.CharacterController;

namespace CharacterGame.CharacterSelector.View
{
    public class CharacterView
    {
        public event Action<GameObject> OnCharacterGenerated;

        public void GenerateRandomCharacter(CharacterController controller)
        {
            GameObject randomCharacter = controller.GenerateRandomCharacter();
            OnCharacterGenerated?.Invoke(randomCharacter);
        }
    }
}