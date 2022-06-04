using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txt_time;
    public Text txt_timeFloored;
    void Update()
    {
        float currentTime = Time.time;
        if (currentTime % 2 == 0)
        {
            int i = 0;
            Debug.Log(i);
            i++;
        }

        txt_time.text = currentTime.ToString();

        //txt_timeFloored.text = Mathf.Floor(currentTime).ToString();

    }
}
