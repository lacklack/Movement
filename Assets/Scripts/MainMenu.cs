using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button timerModeButton;

    // timermode jeenleg letiltva
    public void timerModeEnable()
    {
        timerModeButton.interactable = false;
    }

    private void Start()
    {
        timerModeEnable();
    }

    public void LoadStoryMode()
    {
        SceneManager.LoadScene("Tutorial");
    }

    // csak sztori mod kijatszasa utan elerheto
    public void LoadTimerMode()
    {

    }

    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void LoadProfile()
    {
        SceneManager.LoadScene("Profile");
    }
}