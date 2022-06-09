using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    AudioSource source;
    public AudioClip Saltito;
    
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > 6)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
        }
        saltar();
    }
    private void saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * 300f);
            source.clip = Saltito;
            source.Play();
        }
    }
}
