using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public Text txt_timeFloored;
    float currentTime;
    void Update()
    {
        currentTime = Time.timeSinceLevelLoad;
       
        txt_timeFloored.text = Mathf.Floor(currentTime).ToString();
        if(currentTime > 2)
        {
            SceneManager.LoadScene("FinalWin");
        }
      
    }
}
