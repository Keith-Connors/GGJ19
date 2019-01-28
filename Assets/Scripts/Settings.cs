using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;

public class Settings : MonoBehaviour
{
    [SerializeField]
    Canvas m_SettingsCanvas;

    [SerializeField]
    Canvas m_AccessibilityCanvas;

    [SerializeField]
    Colorblind m_colorBlind;

    [SerializeField]
    bool isPaused;


    CursorLockMode wantedMode;


    private void Start()
    {
        m_SettingsCanvas.enabled = false;
        m_AccessibilityCanvas.enabled = false;
        isPaused = false;
    }

    private void Update()
    {

        if (isPaused == true)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            openSettings();
        }
    }

    public void openSettings()
    {
        isPaused = true;
        m_SettingsCanvas.enabled = true;
        m_AccessibilityCanvas.enabled = false;
    }

    public void closeSettings()
    {
        isPaused = false;
        m_SettingsCanvas.enabled = false;
        m_AccessibilityCanvas.enabled = false;
    }

    public void openAccessibilityMenu()
    {
        isPaused = true;
        m_SettingsCanvas.enabled = false;
        m_AccessibilityCanvas.enabled = true;
    }

    public void closeAccessibilityMenu()
    {
        m_AccessibilityCanvas.enabled = false;
        m_SettingsCanvas.enabled = false;
        isPaused = false;
    }

    public void loadNormalVision() //Turn Off Color Blind assistance
    {
        m_colorBlind.Type = 0;
        m_SettingsCanvas.enabled = false;
        m_AccessibilityCanvas.enabled = false;
        isPaused = false;
    }

    public void loadProtanopiaVision() //Protanopia
    {
        m_colorBlind.Type = 1;
        m_SettingsCanvas.enabled = false;
        m_AccessibilityCanvas.enabled = false;
        isPaused = false;
    }

    public void loadDeuteranopiaVision() //Deuteranopia
    {
        m_colorBlind.Type = 2;
        m_SettingsCanvas.enabled = false;
        m_AccessibilityCanvas.enabled = false;
        isPaused = false;
    }

    public void loadTritanopiaVision() //Tritanopia
    {
        m_colorBlind.Type = 3;
        m_SettingsCanvas.enabled = false;
        m_AccessibilityCanvas.enabled = false;
        isPaused = false;
    }
}