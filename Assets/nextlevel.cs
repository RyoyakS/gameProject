using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class nextlevel : MonoBehaviour
{
    public int current;
    // Start is called before the first frame update
    void Start()
    {
        current = SceneManager.GetActiveScene().buildIndex;
        print(current);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col){
        SceneManager.LoadScene(++current);
    }
}
