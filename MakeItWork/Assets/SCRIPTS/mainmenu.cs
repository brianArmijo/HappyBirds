using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class mainmenu : MonoBehaviour
{
    public void PlayGame()


    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

    public void QuitGame ()
    {
        Application.Quit();
    }
   /*
     public void Levelselect1 ()
    {
        SceneManager.LoadScene("Scenes/Level1");
    }
    public void Levelselect2 ()
    {
        SceneManager.LoadScene("Scenes/Level2");

    }
    public void Levelselect3 ()
    {
        SceneManager.LoadScene("Scenes/Level3");

    }*/

}