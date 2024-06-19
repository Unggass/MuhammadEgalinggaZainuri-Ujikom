using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public PlayerController playerController;

    public void Resumegame()
    {
        playerController.Resume();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
