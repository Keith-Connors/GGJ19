using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField]
    Canvas m_SettingsMenu;
    [SerializeField]
    Canvas m_AccessibilityMenu;

    
    

   [SerializeField] bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        m_SettingsMenu.enabled = false;
        m_AccessibilityMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            m_SettingsMenu.enabled = true;
            isPaused = true;
        } else
        {
            
            m_SettingsMenu.enabled = false;
            isPaused = false;
        }
    }
}
