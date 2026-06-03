using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // EZ KELL a jelenetváltáshoz!

public class SettingsMenu : MonoBehaviour
{
    [Header("UI Panelek")]
    public GameObject settingsPanel;
    public GameObject mainMenuPanel;

    // --- ÚJ RÉSZ: JÁTÉK INDÍTÁSA ---
    public void JatekInditasa()
    {
        Debug.Log("Játék indítása: 'Base' jelenet betöltése...");
        SceneManager.LoadScene("Base"); // Betölti a Base nevű pályát
    }

    // --- MENÜ NAVIGÁCIÓ ---
    public void SettingsMegnyit()
    {
        if (settingsPanel != null) settingsPanel.SetActive(true);
        if (mainMenuPanel != null) mainMenuPanel.SetActive(false);
        Debug.Log("Settings megnyitva.");
    }

    public void SettingsBezar()
    {
        if (settingsPanel != null) settingsPanel.SetActive(false);
        if (mainMenuPanel != null) mainMenuPanel.SetActive(true);
        Debug.Log("Settings bezárva.");
    }

    public void ToggleSettings()
    {
        if (settingsPanel != null)
        {
            bool isActive = !settingsPanel.activeSelf;
            settingsPanel.SetActive(isActive);
            
            if (mainMenuPanel != null)
            {
                mainMenuPanel.SetActive(!isActive);
            }
        }
    }

    // --- FELBONTÁS BEÁLLÍTÁSOK ---
    public void Felbontas1920()
    {
        Screen.SetResolution(1920, 1080, true);
        Debug.Log("Felbontás: 1920x1080");
    }

    public void Felbontas1280()
    {
        Screen.SetResolution(1280, 720, true);
        Debug.Log("Felbontás: 1280x720");
    }

    public void Felbontas800()
    {
        Screen.SetResolution(800, 600, true);
        Debug.Log("Felbontás: 800x600");
    }
}