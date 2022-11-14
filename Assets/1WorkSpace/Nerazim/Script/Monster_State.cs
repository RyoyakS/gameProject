using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster_State : MonoBehaviour
{
    public GameObject exp1;
    public AudioClip SE;
    public AudioSource audioPlayer;
    public float Monster_HP;

    public bool CanChange;
    // Start is called before the first frame update
    void Start()
    {
        Monster_HP = 100f;
        CanChange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Monster_HP <= 100 && Monster_HP > 0)
        {
            CanChange = true;
        }
        else
        {
            CanChange = false;
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag=="Bullet")
        {
            //Player_State.Player_Score += 5;
            Instantiate(exp1, transform.position, transform.rotation);
            Destroy(exp1, 0.01f);
            audioPlayer.PlayOneShot(SE);
            Destroy(collision.transform);
            Monster_HP-=5;

        }
    }
}
