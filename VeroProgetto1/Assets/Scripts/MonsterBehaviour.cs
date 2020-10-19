using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{
    GameObject player;
    Animator anim;
    //posizione puntata dal nemico
    Vector3 target;
    //dopo quanto tempo attacca
    [SerializeField] float attackDelay = 3f;
    //velocità di attacco
    [SerializeField] float monsterSpeed = 3f;
    float timePassedSinceLast = 0f;

    //controllo se attacca
    bool isAttacking = false;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        WaitForAttack();
        Movement();
    }
    void WaitForAttack()
    {
        if (!isAttacking)
        {
            timePassedSinceLast += Time.deltaTime;
            if (timePassedSinceLast > attackDelay)
            {
                target = player.transform.position;
                timePassedSinceLast = 0f;
                Attack();
            }
        }
    }

    private void Attack()
    {
        var dir = target - transform.position;
        anim.SetBool("Attack", true);
        anim.applyRootMotion = true;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(-dir.x, dir.y) * Mathf.Rad2Deg));
        isAttacking = true;
    }

    void Movement() {
        if (isAttacking)
        {
            transform.position += transform.up * Time.deltaTime * monsterSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (isAttacking == true)
        {
            Destroy(gameObject);
        }
    }
}
