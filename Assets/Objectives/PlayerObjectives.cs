using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using NUnit.Framework;
using System.Collections.Generic;

public class PlayerObjectives : MonoBehaviour
{
    List<string> objLista = new List<string>() {
        "Kapcsold fel az egyik tornyot",
        "Állítsd be a rádiót a második szobában",
        "Kapcsold fel a következő tornyot", 
        "Kapcsold fel a biztosítékot a födszinten", 
        "Kapcsold fel az utolsó tornyot" };

    [SerializeField] private int objectiveCounter = 0;

    [SerializeField] private UIObjective ui;

    private void Awake()
    {
        if (ui == null)
            ui = FindAnyObjectByType<UIObjective>();
    }

    public void AddObjective()
    {
        Debug.Log(ui);
        objectiveCounter++;
        Debug.Log("Objektív kész!");
        ui.SetObjective(objLista[objectiveCounter - 1]);
    }

    public bool IsComplete()
    {
        return objectiveCounter == 6;
    }
}
