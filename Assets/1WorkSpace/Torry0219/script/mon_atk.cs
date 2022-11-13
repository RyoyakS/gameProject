using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mon_atk : MonoBehaviour
{
    public float atk_power = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player_State>().Player_HP -= atk_power;
        }
        else if (other.gameObject.CompareTag("Goblin") || other.gameObject.CompareTag("Troll") || other.gameObject.CompareTag("Wolf"))
        {
            other.gameObject.GetComponent<Monster_State>().Monster_HP -= atk_power;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print("hurt!");
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player_State>().Player_HP -= atk_power;
        }
        else if (collision.gameObject.CompareTag("Goblin") || collision.gameObject.CompareTag("Troll") || collision.gameObject.CompareTag("Wolf"))
        {
            collision.gameObject.GetComponent<Monster_State>().Monster_HP -= atk_power;
        }
    }
}
