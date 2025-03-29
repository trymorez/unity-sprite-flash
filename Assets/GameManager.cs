using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] FlashEffect[] flashEffects;
    [SerializeField] SpriteShake[] spriteShakes;
    [SerializeField] CameraShake cameraShake;
    [SerializeField] float cameraShakeDuration = 0.3f;
    [SerializeField] float cameraShakeMagnitude = 0.1f;
    [SerializeField] float spriteShakeDuration = 0.3f;
    [SerializeField] float spriteShakeMagnitude = 0.1f;

    [SerializeField] Toggle cameraShakeActive;
    [SerializeField] Toggle[] spriteShakeActive;

    public void OnSpace(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            for (int i = 0; i < flashEffects.Length; i++)
            {
                var effect = flashEffects[i];
                effect.StartFlashing();

                if (spriteShakeActive[i].isOn)
                {
                    StartCoroutine(spriteShakes[i].Shake(spriteShakeDuration, spriteShakeMagnitude));
                }
            }

            if (cameraShakeActive.isOn)
            {
                StartCoroutine(cameraShake.Shake(cameraShakeDuration, cameraShakeMagnitude));
            }
        }
    }
}
