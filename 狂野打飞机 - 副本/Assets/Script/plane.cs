using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate( Vector3.up * Speed * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y >= -3.2f)
                transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x >= -1.8f)
                transform.Translate(new Vector3(1, 0, 0) * -Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x <= 1.8f)
                transform.Translate(new Vector3(1, 0, 0) * Speed * Time.deltaTime);
        }

        
    }
}
