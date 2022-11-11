using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recoverItem : MonoBehaviour
{
    public static GameObject pf;
    // Start is called before the first frame update
    void Start()
    {
        //pf = GameObject.Find();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            recover_prefab_control.eat = true;
            Destroy(this.gameObject);
        }
    }
}
