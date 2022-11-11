using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_State : MonoBehaviour
{
    public static float Player_HP;
    public static float Player_Score;
    public  GameObject selected_monster;
    bool ishit = false;
    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        Player_HP = 100;
        Player_Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //print(selected_monster.transform.tag);
        Canvas.select_monster = selected_monster;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);    
        
        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
        {
            ishit = true;
            //OnGUI(hit.transform.root.tag, hit.transform.name);
            
            if(hit.collider.gameObject.transform.tag!="Ground")
            {
                //print("hit");
                //print(hit.collider.gameObject.tag);
                selected_monster = hit.collider.gameObject;
            }
            ishit = false;
        }
    }
}
