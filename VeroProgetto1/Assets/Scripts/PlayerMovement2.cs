using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Threading.Tasks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement2 : MonoBehaviour
{

    private Rigidbody2D rigidbody2;
    public float moveForce = 0.2f;
    public float jumpForce = 10f;
    private FixedJoystick fixedjoystick;
    public Animator anim;

    public float maxjump = 3;


    //booleano attacco
    bool attack = false;
    //booleano salto
    //bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        fixedjoystick = GameObject.FindWithTag("Joystick").GetComponent<FixedJoystick>();
        anim = GetComponent<Animator>();


       /* GameObject.Find("Attack Button").GetComponent<Button>().onClick.AddListener(PlayerAttack);

        GameObject.Find("Jump Button").GetComponent<Button>().onClick.AddListener(PlayerJump);*/
    }



    // Update is called once per frame
    void Update()
    {

       
        rigidbody2.velocity = new Vector2(fixedjoystick.Horizontal * moveForce, fixedjoystick.Vertical*jumpForce);

        //se mi sto spostando a sinistra o a destra
        if (rigidbody2.velocity.x < 0)
        {
            rigidbody2.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(rigidbody2.velocity.x>0)
        {
            rigidbody2.transform.localScale = new Vector3(1, 1, 1);
        }

        //Se mi sto muovendeo sull'asse orizzontale
        if (fixedjoystick.Horizontal != 0f || fixedjoystick.Vertical != 0f) anim.SetFloat("isMoving", Mathf.Abs(fixedjoystick.Horizontal));
        else anim.SetFloat("isMoving", 0);

    }

    [SerializeField] public void PlayerAttack()
    {
        if (attack)
            anim.SetTrigger("attack");
        anim.SetTrigger("attack");

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
