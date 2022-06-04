using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
   public Text txt_timeFloored;
    void Update()
    {
        float currentTime = Time.time;
       
        txt_timeFloored.text = Mathf.Floor(currentTime).ToString();

        if (Time.time == 10)
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
            SceneManager.LoadScene("FinalWin");
        }
    }
}
