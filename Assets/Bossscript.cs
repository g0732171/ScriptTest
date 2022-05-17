using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossscript: MonoBehaviour
{

    public class Boss 
    {
        private int hp = 100;
        private int power = 25;
        public int mp = 53;

        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        public void Magic()
        {
            if(this.mp>=5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは"+this.mp);
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }

        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            this.hp -= damage;
        }

    }



    void Start()
    {

        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);
        for(int j=lastboss.mp; j>=0;j-=5)
        {
            lastboss.Magic();
        }
        

    }

    void Update()
    {
        
    }
}
