using UnityEngine;
using System.Collections;
public class MonsterBehaviour2 : MonoBehaviour
{
    float speed = 1.8f;
    GameObject player;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GameControlScript.healt -= 1;
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "Bullet") Destroy(this.gameObject);
    }
    void Start()
    {
        GameObject _p = GameObject.Find("Player");
        if (_p != null)
        {
            player = _p;
        }
    }
    void Update()
    { 
        Vector3 moveVector = Vector3.left; 
        transform.position += moveVector * speed * Time.deltaTime;
        if (player != null)
        {
            if (this.transform.position.x <= player.transform.position.x - 10.0f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}