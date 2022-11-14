using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_State : MonoBehaviour
{
    public float Player_HP;
    public GameObject Player_Selected_Monster;
    public float Player_Score;
    public int state; //0代表人型態 1代表怪物型態
    bool ishit = false;
    Ray ray;
    RaycastHit hit;

    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name=="Scene0_SpaceStation"){
            PlayerPrefs.SetFloat("Player_HP", 100f);
            Debug.Log("ssssss");
        }
        state = 1;
        Player_HP = PlayerPrefs.GetFloat("Player_HP");
        Player_Score = PlayerPrefs.GetFloat("Player_Score");
        ani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
        {
            ishit = true;
            
            if((hit.collider.gameObject.transform.tag=="Goblin")||(hit.collider.gameObject.transform.tag=="Wolf")||(hit.collider.gameObject.transform.tag=="Troll"))
            {
                print("hit");
                Player_Selected_Monster = hit.collider.gameObject;
            }
            else
            {
                Player_Selected_Monster = null;
            }
            ishit = false;
        }

        if (Player_Selected_Monster)
        {
            print(Player_Selected_Monster.transform.tag);
        }

        if (Player_HP <= 0)
        {
            ani.SetBool("dead", true);
        }


        //use userpref to save the user state
        PlayerPrefs.SetFloat("Player_HP", Player_HP);
        PlayerPrefs.SetFloat("Player_Score", Player_Score);
        
    }
}
