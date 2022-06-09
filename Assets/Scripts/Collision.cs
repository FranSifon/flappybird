using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Collision : MonoBehaviour
{
    AudioSource source;
    public AudioClip Muerte;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        source.clip = Muerte;
        source.Play();
        Destroy(gameObject);
        Time.timeScale = 0f;
        SceneManager.LoadScene("FinalLose");

    }
   



   
}
