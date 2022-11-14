using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mon_atk : MonoBehaviour
{
    public float atk_power = 5;
    
    public AudioClip SE;
    public AudioSource audioPlayer;
    //private int CanPlay;
    // Start is called before the first frame update
    void Awake()
    {
        audioPlayer = gameObject.GetComponentInParent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if ()
        {
            CanPlay += 1;
            if (CanPlay == 1)
            {
                Invoke("playSE", 0.6f);
            }
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player_State>().Player_HP -= atk_power;
            if (other.gameObject.GetComponent<Player_State>().Player_HP < 0)
            {
                other.gameObject.GetComponent<Player_State>().Player_HP = 0;
            }
        }
        else if (other.gameObject.CompareTag("Goblin") || other.gameObject.CompareTag("Troll") || other.gameObject.CompareTag("Wolf"))
        {
            other.gameObject.GetComponent<Monster_State>().Monster_HP -= atk_power;
            if (other.gameObject.GetComponent<Player_State>().Player_HP < 0)
            {
                other.gameObject.GetComponent<Player_State>().Player_HP = 0;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print("hurt!");
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player_State>().Player_HP -= atk_power;
            if (collision.gameObject.GetComponent<Player_State>().Player_HP < 0)
            {
                collision.gameObject.GetComponent<Player_State>().Player_HP = 0;
            }
        }
        else if (collision.gameObject.CompareTag("Goblin") || collision.gameObject.CompareTag("Troll") || collision.gameObject.CompareTag("Wolf"))
        {
            collision.gameObject.GetComponent<Monster_State>().Monster_HP -= atk_power;
            if (collision.gameObject.GetComponent<Player_State>().Player_HP < 0)
            {
                collision.gameObject.GetComponent<Player_State>().Player_HP = 0;
            }
        }
    }

    private void OnEnable()
    {
        print("play");
        audioPlayer.PlayOneShot(SE);
    }
}
