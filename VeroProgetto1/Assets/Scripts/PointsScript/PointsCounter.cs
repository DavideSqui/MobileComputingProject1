using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public static int pointAmount;
    public Text pointsCounter;
    // Start is called before the first frame update
    void Start()
    {
        pointsCounter.GetComponent<Text>();
        pointAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointsCounter.text = "Points: " + pointAmount;
    }
}
