using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_State : MonoBehaviour
{
    // Start is called before the first frame update
    public float HP;
    void Start()
    {
        
        if(this.transform.tag=="Goblin")
        {
            HP = 100;
        }
        else if(this.transform.tag=="Troll")
        {
            HP = 100;
        }
        else if(this.transform.tag=="Wolf")
        {
            HP = 100;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag=="Bullet")
        {
            Player_State.Player_Score += 5;
            print("123");
            Destroy(collision.transform);
            HP-=5;
        }
    }
}
