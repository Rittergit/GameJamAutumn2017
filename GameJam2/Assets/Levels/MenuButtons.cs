using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {
    public Transform camera;

    public void PlayGame() {
		GameSettings.playerLifes = 3;
		SceneManager.LoadScene ("Levels/dmartinDebugLevel");
    }

    public void Settings()
    {
        camera.GetComponent<Animator>().SetBool("switch", true);
    }

    public void TransMenu()
    {
        camera.GetComponent<Animator>().SetBool("switch", false);
    }


    public void Menu()
    {
		SceneManager.LoadScene ("Levels/menu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
