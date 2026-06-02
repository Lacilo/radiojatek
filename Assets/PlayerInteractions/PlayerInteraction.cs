using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private float interactionDistance;

    [SerializeField] private InputActionReference interactionReference;

    private void OnDisable()
    {
        interactionReference.action.Disable();
        interactionReference.action.started -= PlayerInteracted;
    }

    private void OnEnable()
    {
        interactionReference.action.started += PlayerInteracted;
        interactionReference.action.Enable();
    }

    private void PlayerInteracted(InputAction.CallbackContext context)
    {
        // Debug.Log("Keresem az interactablet!");
        if (context.started)
        {
            Ray ray = new Ray(playerCamera.position, playerCamera.forward);

            if (!Physics.Raycast(ray, out RaycastHit hitInfo, interactionDistance)) return;

            if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactableObject))
            {
                interactableObject.Interact();
            }
        }
    }
}
