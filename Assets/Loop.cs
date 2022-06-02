using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    private float velocidad = 10;
    private int puntos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        loop();
    }
    private void loop()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        if (transform.position.x<-30)
        {
            transform.Translate(Vector3.right * 60);
        }
        if (transform.position.x <= -6)
        {
            puntos++;
            
        }
        Debug.Log(puntos);
    }
}
