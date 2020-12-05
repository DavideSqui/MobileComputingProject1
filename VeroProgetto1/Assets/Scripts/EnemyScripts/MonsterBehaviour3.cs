using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MonsterBehaviour3 : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameControlScript.healt -= 1;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Bullet") Destroy(this.gameObject);
    }
}
