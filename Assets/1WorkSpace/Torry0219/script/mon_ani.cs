using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mon_ani : MonoBehaviour
{
    public float move_speed;
    private Animator ani;
    public static GameObject player;
    public static bool lockAI;
    
    int atkstate;
    int runstate;

    Vector3 prevPos;
    // Start is called before the first frame update
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
        atkstate = Animator.StringToHash("Base Layer.attack01");
        runstate = Animator.StringToHash("Base Layer.run");
        prevPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        float vel = ((transform.position - prevPos) / Time.deltaTime).magnitude;
        AnimatorStateInfo state = ani.GetCurrentAnimatorStateInfo(0);
        lockAI = false;
        ani.SetFloat("speed", vel);
        if(Vector3.Distance(transform.position, player.transform.position) <= 2.5f){
            ani.SetBool("attack01", true);
        }
        else if (state.fullPathHash == atkstate){
            ani.SetBool("attack01", false);
            lockAI = true;
        }
        prevPos = transform.position;
    }
}
