using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float Speed = 4;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
        if (transform.position.y >= 3f)
        {
            Destroy(this.gameObject);


        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {if(collision.collider.CompareTag("Enemy"))
        collision.collider.GetComponent<enemy>().BeHit();
     if(collision .collider .CompareTag("Award"))
        collision.collider.GetComponent<award>().dead = true;
     
        Destroy(this.gameObject);
    }
}
