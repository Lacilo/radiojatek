using JetBrains.Annotations;
using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable
{
    private bool done = false;

    public void Interact()
    {
        Debug.Log("Interacting...");

        if (done) return;

        done = true;

        var player = FindAnyObjectByType<PlayerObjective>();
        player.AddObjective();
    }
}