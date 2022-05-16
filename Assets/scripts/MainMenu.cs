using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject ButtonPanel, SettingsPanel;

    public void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Settings()
    {
        ButtonPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("You did it you fucking cunt");
    }

    public void SettingsBack()
    {
        ButtonPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }

}
