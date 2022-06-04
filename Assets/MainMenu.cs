using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  void Start()
    {
        Time.timeScale = 0f;
    }
   public void JugarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }
    public void Salir()
    {
        Debug.Log("salir");
        Application.Quit();
        
    }
}
