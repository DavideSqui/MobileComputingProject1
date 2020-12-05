using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;


    //Inseriamo l'animatore delle animazioini
    Animator anim; //inizializzato in start

    //velocitàmovimento
    [SerializeField] float moveSpeed = 3f;

    //controllo se salto
    float jumpForce = 7f;
    bool isJumping = false;

    bool attack;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Movement();
        Jumping();
        HandleInput();
    }
    // Update is called once per frame

    private void FixedUpdate()
    {
        HandleAttacks();
        ResetValues();
    }
    //PARTE DEL MOVIMENTO PRINCIPALE DEL PLAYER
    void Movement()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 velocity = new Vector2(Vector2.right.x * moveSpeed * h, body.velocity.y);

        //diamo al vettore velocità quello dato dall'utente
        body.velocity = velocity;

        //se mi st6o spostando a sinistra o a destra
        if (velocity.x < 0) {
            body.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(velocity.x>0)
        {
            body.transform.localScale = new Vector3(1, 1, 1);
        }
        //fine direzionamento personaggio
        //Inserimento valore dell'animator affinchè avvenga l'animazione
        anim.SetFloat("isMoving", Mathf.Abs(h));
    
    }


    //NUOVA FUNZIONE PER IL SALTO DEL PROTAGONISTA
    void Jumping() {
        if (isJumping)
        {
            if (body.velocity.y == 0) 
            { //giocatore a terra
                isJumping = false;
            }
        }
        else
        {
            //se sta spingengo il tasto salto
            if (Input.GetAxis("Jump") > 0)
            {
                //aggiungo il salto al player
                body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                //metto isjumping a true per indicare che salta
                isJumping = true;
            }
        }
    }

    /*ATTACCOOOOOOOOO*/
    private void HandleAttacks() {
        if (attack)
            anim.SetTrigger("attack");
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            attack = true;
        }
        
    }

    //Resetta i valori modificati 

    public void ResetValues() {
        attack = false;
    }


}