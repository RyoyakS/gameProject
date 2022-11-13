using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mon_AI : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent navi;
    public static GameObject player;
    public float mon_track_range = 20f;
    public float mon_attack_range = 5f;
    // Start is called before the first frame update
    void Start()
    {
        navi = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        navi.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player = GameObject.FindWithTag("Player");
        if(Vector3.Distance(transform.position, player.transform.position) <= mon_track_range && Vector3.Distance(transform.position, player.transform.position)>mon_attack_range && !this.GetComponent<mon_ani>().lockAI && !this.GetComponent<mon_ani>().dead){
            navi.enabled = true;
            navi.SetDestination(player.transform.position);
        }
        else navi.enabled = false;
    }
}
