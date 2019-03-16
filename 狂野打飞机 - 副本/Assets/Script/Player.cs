using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float smoothing = 1;
    public float restTime = 1;
    public int life = 5;

    public float restTimer = 1;
    private Vector2 targetPos= new Vector2(0,-1);
    private Rigidbody2D rigidbody;
    private Collider2D collider;
    public float lastTime = 0;
    public float FreeDamagePeriod = 2f;
    new Vector2 pos;
    public bool flag = false;
    public int Ammos = 30;
    private Text Ammo;

   




    // Start is called before the first frame update
    void Start()
    {rigidbody =GetComponent <Rigidbody2D>();
        collider = GetComponent<Collider2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
        if(flag==false)
            Move();
        if (Ammos <= 0)
            dead();
        initgame();

        
    }
    private void Move()
    {
        rigidbody.MovePosition(Vector2.Lerp(transform.position, targetPos, smoothing * Time.deltaTime));
        restTimer += Time.deltaTime;
        if (restTimer < restTime) return;
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (h > 0)
        { v = 0; }
        if (v != 0 || h != 0)

        {
            collider.enabled = false;
            RaycastHit2D hit = Physics2D.Linecast(targetPos, targetPos + new Vector2(h, v));
            collider.enabled = true;
            if (hit.transform == null)
                targetPos += new Vector2(h, v);


              restTimer = 0;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {  if (Time.time > lastTime + FreeDamagePeriod)
            if (collision.collider.CompareTag("Enemy"))
            {
                hited();

               pos = collision.collider.GetComponent<enemy>().transform.position;
            }
        
    }
    private void hited()
    {
        flag = true;
        life--;
        forced();
        lastTime = Time.time;
        StartCoroutine(later());               //给予碰撞表现时间



        if (life <= 0)
        {
            dead();
            
        }
        

    }
    private void dead()
    {
        this.enabled = false;
        Destroy (GameObject.Find("gun"));
        GameObject.Find("gameover").GetComponent<Text>().enabled = true;
    }
    private void forced()
    {
        Vector2 hitvector = new Vector2(transform.position.x, transform.position.y) - pos;
        rigidbody.AddForce(5*hitvector , ForceMode2D.Impulse);
    }
    private IEnumerator later()
    {
        yield return new WaitForSeconds(0.3f);
        flag = false;
    }
   private void initgame()
    {
       Ammo= GameObject.Find("ammo").GetComponent<Text>();
        updateammo();

    }
    private void updateammo()
    {
        Ammo.text = "ammo:" + Ammos;
    }
}

