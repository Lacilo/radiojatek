using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerObjective : MonoBehaviour
{
    [SerializeField] private int objectiveCounter = 0;

    public void AddObjective()
    {
        objectiveCounter++;
        Debug.Log("Objektív kész!");
    }

    public bool IsComplete()
    {
        return objectiveCounter >= 6;
    }
}
