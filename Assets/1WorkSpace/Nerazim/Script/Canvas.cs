using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Canvas : MonoBehaviour
{
    public static GameObject select_monster;
    public TextMeshProUGUI Selected_MonsterName_UI;
    public TextMeshProUGUI Time_UI;
    public TextMeshProUGUI Score_UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time_UI.text = "Time:" + Time.time;
        Score_UI.text = "Score:" + Player_State.Player_Score;
        if ((select_monster)&&(select_monster.transform.tag != "Ground"))
        {
            Selected_MonsterName_UI.text = "Selected Monster:"+select_monster.tag;
        }

        
    }
}
