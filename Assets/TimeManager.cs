using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
   public Text txt_timeFloored;
    void Update()
    {
        float currentTime = Time.time;
       
        txt_timeFloored.text = Mathf.Floor(currentTime).ToString();


    }
}
