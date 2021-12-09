using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void LEVEL1()
    {
        SceneManager.LoadScene("level");
    }






    public void QuitGame()
    {
        Application.Quit();
    }


    public void controls()
    {
        SceneManager.LoadScene("controls");
    }

  
    private void OnTriggerEnter(Collider other)
    {
        SceneManager .LoadScene("end")
    }

}






