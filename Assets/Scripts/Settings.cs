using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
=======
using Wilberforce;
>>>>>>> parent of 937297a... Merge branch 'master' of https://github.com/Keith-Connors/GGJ19

public class Settings : MonoBehaviour
{
    [SerializeField]
    Canvas m_SettingsCanvas;
<<<<<<< HEAD
    [SerializeField]
    Canvas m_AccessibilityCanvas;

=======

    [SerializeField]
    Canvas m_AccessibilityCanvas;

    [SerializeField]
    Colorblind m_colorBlind;
>>>>>>> parent of 937297a... Merge branch 'master' of https://github.com/Keith-Connors/GGJ19

    [SerializeField]
    bool isPaused;

<<<<<<< HEAD
<<<<<<< HEAD


=======
    
>>>>>>> 5b174ba23c7ca111ef6e7188a473cf6cd5d725ec
=======

    CursorLockMode wantedMode;

>>>>>>> parent of 937297a... Merge branch 'master' of https://github.com/Keith-Connors/GGJ19

    private void Start()
    {
        m_SettingsCanvas.enabled = false;
        m_AccessibilityCanvas.enabled = false;
        isPaused = false;
    }

    private void Update()
    {
<<<<<<< HEAD
=======

>>>>>>> parent of 937297a... Merge branch 'master' of https://github.com/Keith-Connors/GGJ19
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
<<<<<<< HEAD
<<<<<<< HEAD
        m_SettingsCanvas.enabled = true;
        m_AccessibilityCanvas.enabled = false;
<<<<<<< HEAD
        
=======
        m_SettingsCanvas.enabled =  true;
>>>>>>> 5b174ba23c7ca111ef6e7188a473cf6cd5d725ec
=======
        m_SettingsCanvas.enabled = true;
        m_AccessibilityCanvas.enabled = false;
        
>>>>>>> parent of 937297a... Merge branch 'master' of https://github.com/Keith-Connors/GGJ19
=======
>>>>>>> parent of 51b002c... fix bugs
    }

    public void closeSettings()
    {
        isPaused = false;
        m_SettingsCanvas.enabled = false;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 937297a... Merge branch 'master' of https://github.com/Keith-Connors/GGJ19
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
<<<<<<< HEAD
 
<<<<<<< HEAD
}
=======
    }
}
>>>>>>> 5b174ba23c7ca111ef6e7188a473cf6cd5d725ec
=======
}
>>>>>>> parent of 937297a... Merge branch 'master' of https://github.com/Keith-Connors/GGJ19
=======

    void SetCursorState()
    {
        Cursor.lockState = wantedMode;
        Cursor.visible = (CursorLockMode.Locked != wantedMode);
    }

    void OnGUI()
    {
        SetCursorState();
    }
}
>>>>>>> parent of 51b002c... fix bugs
