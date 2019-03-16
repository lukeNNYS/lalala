using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int hp = 1;
    public float Speed = 2;
    public int score=0;
    public bool isDeath = false;
   
    

    // Update is called once per frame
    void Update()
    {
        //this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1 * Speed * Time.deltaTime);

        transform.Translate(new Vector2(0,-1) * Speed * Time.deltaTime);
        if (transform.position.y <= -2.7f|| transform.position.x>2.88||transform.position.x<-2.88)
        {
            Destroy(this.gameObject);

        }
        if (isDeath)
            doisDeath();
    }
     public void doisDeath()
        {
           GameObject.Find("生成").GetComponent<score>().allScore += this.score;
            Destroy(this.gameObject);
        GameObject.Find("233").GetComponent<Player>().Ammos += 10;
    }
     public void BeHit()
    {
        hp -= 1;
        if (hp <= 0)
        {
            isDeath = true;
            return;
        }
    }

}
