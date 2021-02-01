using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandeler : MonoBehaviour
{

    public Button HitBtn;
    public Button HealBtn;
    public Slider HealtBar1;
    //public Image SliderFill;

    public Text PlayerHPText;

    public Color RedColor = new Color(231, 75, 75, 255); // E74B4B
    public Color TestColor = new Color(29, 1, 72, 255); // A14B91
    public Color DeadColor = new Color(77, 3, 191, 255); // 1D0148

    public Color PlayerHPTextColor = new Color(255, 227, 179, 255); // FFE3B3

    public int healthBarMax;
    public int healthBarCur;

    public int hitDMG = 2;
    public int healHit = 2;


    // ENEMY ===================================================================
    public Slider HealtBarEnemy;
    public Text EnemyHPText;

    public Button EnemyHitBtn;
    public Button EnemyHealBtn;

    public int EnemyHealthBarMax;
    public int EnemyHealthBarCur;

    public int EnemyHitDMG = 2;
    public int EnemyHealHit = 2;

    // TODO: Do the same to the enemy, as we did with the player UI stuff

    // Start is called before the first frame update
    void Start()
    {

        // Gets the Max and current health. Current health is gonna be saved to a temp/permanent file
        healthBarMax = int.Parse(HealtBar1.maxValue.ToString());
        healthBarCur = int.Parse(HealtBar1.value.ToString());

        // Finds the sliders Fill
        HealtBar1.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = RedColor;
        HealtBarEnemy.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = RedColor;

        // Sets the HP text color to the correct color
        PlayerHPText.color = PlayerHPTextColor;

        // Sets the HP text to the Max and current HP
        PlayerHPText.text = HealtBar1.value.ToString() + "/" + HealtBar1.maxValue.ToString();
        EnemyHPText.text = HealtBarEnemy.value.ToString() + "/" + HealtBarEnemy.maxValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitFunc()
    {
        HealtBar1.value -= hitDMG;
        healthBarCur = int.Parse(HealtBar1.value.ToString());

        
    }
    public void HealFunc()
    {
        if(HealtBar1.maxValue > HealtBar1.value + healHit)
        {
            HealtBar1.value += healHit;
        }
        else
        {
            HealtBar1.value = HealtBar1.maxValue;
        }
        healthBarCur = int.Parse(HealtBar1.value.ToString());
    }

    public void turnFunc (string Choice)
    {
        switch (Choice){
            case "hit":
                HitFunc();
                break;
            case "heal":
                HealFunc();
                break;
        }

        PlayerHPText.text = HealtBar1.value.ToString() + "/" + HealtBar1.maxValue.ToString();

        if (healthBarCur <= 0)
        {
            HealtBar1.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = DeadColor;
        }
        else
        {
            HealtBar1.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = RedColor;
        }

    }

}
