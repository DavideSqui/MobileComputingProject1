using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileforce : MonoBehaviour
{
    Rigidbody2D projectile;
    // Start is called before the first frame update
    void Start()
    {
        projectile = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        projectile.velocity = new Vector2(10, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Mappa"))
        {
            Destroy(gameObject);
        }
    }
}
