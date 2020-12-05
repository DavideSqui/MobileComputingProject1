using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsControllerActivator : MonoBehaviour
{
    public GameObject game;
    public static int points;
    public Text riassunto;

    public void Start()
    {
        game.gameObject.SetActive(false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="Player")
        {
            points = PointsCounter.pointAmount;
            game.gameObject.SetActive(true);
            Destroy(gameObject);
            riassunto.text = "Level Completed " +
                "\nyour points are: " + points;
            Time.timeScale = 1;
        }
    }
}
