using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class award : MonoBehaviour
{
    //public int type = 0; // 0 gun 1 explode
    public float Speed = 1.5f;
    public bool dead = false;
    public int score ;
    public int flag=0;

    // Update is called once per frame
    void Update()
    {
      
        transform.Translate(new Vector2(0,-1) * Speed * Time.deltaTime);
        if (dead)
           GameObject.Find("生成").GetComponent<score>().allScore += this.score;

        if (transform.position.y <= -2.7f )
        {
            Destroy(this.gameObject);

        }
        if(dead)
        {
            Destroy(this.gameObject);
           
          GameObject.Find("233").GetComponent<Player>().Ammos += 50;
                    


            }



        }
      
    }
    
    
      

