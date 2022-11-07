using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public AudioClip SE;
    public AudioSource audioPlayer;
    public GameObject exp1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
            Instantiate(exp1, transform.position, transform.rotation);
            audioPlayer.PlayOneShot(SE);

    }
}
