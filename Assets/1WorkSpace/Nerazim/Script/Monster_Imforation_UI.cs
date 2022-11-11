using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Monster_Imforation_UI : MonoBehaviour
{
    public TextMeshProUGUI Monster_Name;
    public Image Monster_HpBar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Monster_HpBar.GetComponent<Image>().fillAmount = Canvas.select_monster.GetComponent<Monster_State>().HP/100;
    }
}
