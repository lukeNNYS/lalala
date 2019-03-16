using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackGround : MonoBehaviour
{    public static float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
         moveSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2 (0,-1) * moveSpeed * Time.deltaTime);
        Vector2 postion = transform.position;
        if (postion.y <= -2.53f*2)
        {
            transform.position = new Vector2(postion.x, postion.y + 2 * 2.53f*2);
        }

         
        
    }
}
