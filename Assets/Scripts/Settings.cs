using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField]
    Canvas m_SettingsCanvas;
    [SerializeField]
    Canvas m_AccessibilityCanvas;


    [SerializeField]
    bool isPaused;

    

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
        }
        else
        {
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            openSettings();
        }
    }

    public void openSettings()
    {
        isPaused = true;
        m_SettingsCanvas.enabled =  true;
    }

    public void closeSettings()
    {
        isPaused = false;
        m_SettingsCanvas.enabled = false;
    }
}
