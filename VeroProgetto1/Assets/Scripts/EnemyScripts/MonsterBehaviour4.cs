using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;


public class MonsterBehaviour4 : MonoBehaviour
{
    Random random;
    Rigidbody2D Monster;
   
    // Start is called before the first frame update
    void Start()
    {
        Monster = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
                    Monster.velocity=new Vector2(0, 2);
    }
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
