using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] FlashEffect[] flashEffects;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnSpace(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            foreach (var effect in flashEffects)
            {
                effect.StartFlashing();
            }
        }
    }
}
