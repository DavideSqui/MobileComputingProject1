using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject coin1, coin2, coin3, coin4, coin5, coin6, coin7, coin8, coin9, coin10;
    public static int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        coin1.gameObject.SetActive(false);
        coin2.gameObject.SetActive(false);
        coin3.gameObject.SetActive(false);
        coin4.gameObject.SetActive(false);
        coin5.gameObject.SetActive(false);
        coin6.gameObject.SetActive(false);
        coin7.gameObject.SetActive(false);
        coin8.gameObject.SetActive(false);
        coin9.gameObject.SetActive(false);
        coin10.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (currentScore > 10) currentScore = 10;
        switch (currentScore)
        {
            case 10:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(true);
                coin3.gameObject.SetActive(true);
                coin4.gameObject.SetActive(true);
                coin5.gameObject.SetActive(true);
                coin6.gameObject.SetActive(true);
                coin7.gameObject.SetActive(true);
                coin8.gameObject.SetActive(true);
                coin9.gameObject.SetActive(true);
                coin10.gameObject.SetActive(true);
                break;
            case 9:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(true);
                coin3.gameObject.SetActive(true);
                coin4.gameObject.SetActive(true);
                coin5.gameObject.SetActive(true);
                coin6.gameObject.SetActive(true);
                coin7.gameObject.SetActive(true);
                coin8.gameObject.SetActive(true);
                coin9.gameObject.SetActive(true);
                coin10.gameObject.SetActive(false);
                break;
            case 8:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(true);
                coin3.gameObject.SetActive(true);
                coin4.gameObject.SetActive(true);
                coin5.gameObject.SetActive(true);
                coin6.gameObject.SetActive(true);
                coin7.gameObject.SetActive(true);
                coin8.gameObject.SetActive(true);
                coin9.gameObject.SetActive(false);
                coin10.gameObject.SetActive(false);
                break;
            case 7:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(true);
                coin3.gameObject.SetActive(true);
                coin4.gameObject.SetActive(true);
                coin5.gameObject.SetActive(true);
                coin6.gameObject.SetActive(true);
                coin7.gameObject.SetActive(true);
                coin8.gameObject.SetActive(false);
                coin9.gameObject.SetActive(false);
                coin10.gameObject.SetActive(false);
                break;
            case 6:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(true);
                coin3.gameObject.SetActive(true);
                coin4.gameObject.SetActive(true);
                coin5.gameObject.SetActive(true);
                coin6.gameObject.SetActive(true);
                coin7.gameObject.SetActive(false);
                coin8.gameObject.SetActive(false);
                coin9.gameObject.SetActive(false);
                coin10.gameObject.SetActive(false);
                break;
            case 5:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(true);
                coin3.gameObject.SetActive(true);
                coin4.gameObject.SetActive(true);
                coin5.gameObject.SetActive(true);
                coin6.gameObject.SetActive(false);
                coin7.gameObject.SetActive(false);
                coin8.gameObject.SetActive(false);
                coin9.gameObject.SetActive(false);
                coin10.gameObject.SetActive(false);
                break;
            case 4:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(true);
                coin3.gameObject.SetActive(true);
                coin4.gameObject.SetActive(true);
                coin5.gameObject.SetActive(false);
                coin6.gameObject.SetActive(false);
                coin7.gameObject.SetActive(false);
                coin8.gameObject.SetActive(false);
                coin9.gameObject.SetActive(false);
                coin10.gameObject.SetActive(false);
                break;
            case 3:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(true);
                coin3.gameObject.SetActive(true);
                coin4.gameObject.SetActive(false);
                coin5.gameObject.SetActive(false);
                coin6.gameObject.SetActive(false);
                coin7.gameObject.SetActive(false);
                coin8.gameObject.SetActive(false);
                coin9.gameObject.SetActive(false);
                coin10.gameObject.SetActive(false);
                break;
            case 2:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(true);
                coin3.gameObject.SetActive(false);
                coin4.gameObject.SetActive(false);
                coin5.gameObject.SetActive(false);
                coin6.gameObject.SetActive(false);
                coin7.gameObject.SetActive(false);
                coin8.gameObject.SetActive(false);
                coin9.gameObject.SetActive(false);
                coin10.gameObject.SetActive(false);
                break;
            case 1:
                coin1.gameObject.SetActive(true);
                coin2.gameObject.SetActive(false);
                coin3.gameObject.SetActive(false);
                coin4.gameObject.SetActive(false);
                coin5.gameObject.SetActive(false);
                coin6.gameObject.SetActive(false);
                coin7.gameObject.SetActive(false);
                coin8.gameObject.SetActive(false);
                coin9.gameObject.SetActive(false);
                coin10.gameObject.SetActive(false);
                break;
            case 0:
                coin1.gameObject.SetActive(false);
                coin2.gameObject.SetActive(false);
                coin3.gameObject.SetActive(false);
                coin4.gameObject.SetActive(false);
                coin5.gameObject.SetActive(false);
                coin6.gameObject.SetActive(false);
                coin7.gameObject.SetActive(false);
                coin8.gameObject.SetActive(false);
                coin9.gameObject.SetActive(false);
                coin10.gameObject.SetActive(false);
                break;
        }
    }
}
