using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Rigidbody2D bullet;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bullet.velocity = new Vector2(16, 0);
    }
     private void OnCollisionEnter2D(Collision2D collision)
     {
        if (collision.gameObject.CompareTag("Coin")|| collision.gameObject.CompareTag("Mappa")) 
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("monster"))
        {
            PointsCounter.pointAmount += 50;
            Destroy(gameObject);
        }
     }
}
