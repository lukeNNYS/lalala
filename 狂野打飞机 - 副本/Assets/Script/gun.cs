using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    
    //发射子弹间隔
    public float rate =0.1f;
    //子弹的实例化存储对象
    public GameObject bullet;
    
    void Start()
    {
       
        OpenFire();
    }

    public void OpenFire()
    {    
        InvokeRepeating("fire", 1f, rate);

    }
    //发射一枚子弹
    public void fire()
    {
        GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
        GameObject.Find("233").GetComponent<Player>().Ammos--;
    }


}
