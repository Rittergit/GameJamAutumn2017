using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour {

    public Transform camera;


    public void PlayGame() {
           
            Application.LoadLevel(1);
    
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

        Application.LoadLevel(0);

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
