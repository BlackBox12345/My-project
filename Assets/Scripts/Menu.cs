using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;



public class menu : MonoBehaviour

{

   public static bool isPaused = true;

    void Update()
    {
        if (isPaused)
            Time.timeScale = 0; // Остановить время
        else
            Time.timeScale = 1; // Возобновить время
    }

    public static void SetPause(bool pause)
    {
        isPaused = pause;
    }
   public void Play()

   {
    SceneManager.LoadScene(1);
    isPaused = false;
   }

   public void Quite()

   {

    Application.Quit();

   }
}
