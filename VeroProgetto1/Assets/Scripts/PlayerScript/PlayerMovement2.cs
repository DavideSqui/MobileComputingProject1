using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics.Eventing.Reader;
using System.Threading.Tasks;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement2 : MonoBehaviour
{
    private Rigidbody2D rigidbody2;
    public float moveForce = 0.2f;
    public float jumpForce = 20f;
    private FixedJoystick fixedjoystick;
    public Animator anim;
    public float maxjump = 3;
    //booleano attacco
    UnityEngine.Object bulletRef;
    //booleano salto
    bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        bulletRef = Resources.Load("dagger");

        fixedjoystick = GameObject.FindWithTag("Joystick").GetComponent<FixedJoystick>();
        anim = GetComponent<Animator>();
       
        /* GameObject.Find("Attack Button").GetComponent<Button>().onClick.AddListener(PlayerAttack);
         GameObject.Find("Jump Button").GetComponent<Button>().onClick.AddListener(PlayerJump);*/
    }
    // Update is called once per frame
    void Update()
    {
        if (isJumping)
        {
            if (rigidbody2.velocity.y == 0)
            {
                isJumping = false;
            }
        }
        else
        {
            if (fixedjoystick.Vertical * jumpForce > 0)
            {
                rigidbody2.velocity = new Vector2(fixedjoystick.Horizontal * moveForce, fixedjoystick.Vertical * jumpForce);
                isJumping = true;
            }
        }
        rigidbody2.velocity = new Vector2(fixedjoystick.Horizontal * moveForce, rigidbody2.velocity.y);
        //se mi sto spostando a sinistra o a destra
        if (rigidbody2.velocity.x < 0)
        {
            rigidbody2.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (rigidbody2.velocity.x > 0)
        {
            rigidbody2.transform.localScale = new Vector3(1, 1, 1);
        }
        //Se mi sto muovendeo sull'asse orizzontale
        if (fixedjoystick.Horizontal != 0f || fixedjoystick.Vertical != 0f) anim.SetFloat("isMoving", Mathf.Abs(fixedjoystick.Horizontal));
        else anim.SetFloat("isMoving", 0);

        //se il giocaore salta di sotto muore
        if (rigidbody2.transform.localPosition.y < -3.7f) {
            GameControlScript.healt -= GameControlScript.healt;
        }
        //morte del player animata
        if (GameControlScript.healt == 0)
        {
            rigidbody2.velocity = new Vector2(0, 0);
            anim.SetTrigger("death");
        }
    }
    [SerializeField] public void PlayerAttack()
    { 
        anim.SetTrigger("Attack");
        //anim.SetTrigger("attacking");
        GameObject bullet = (GameObject)Instantiate(bulletRef);
            bullet.transform.position = new Vector3(transform.position.x + .14f, transform.position.y + .5f, -1);
            
    }

    //unico collisionenter per controllare se collida con coin
   public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            PointsCounter.pointAmount += 100;
            Destroy(collision.gameObject);
        }
    }

    /*  [SerializeField] public void PlayerJump()
      {
          if (rigidbody2.velocity.y == 0) isJumping = false;
          else
          {
              rigidbody2.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
              rigidbody2.velocity = new Vector2(fixedjoystick.Horizontal * moveForce, fixedjoystick.Vertical*moveForce);
              isJumping = true;
          }

      }*/

}
