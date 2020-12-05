using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCCameraMovement : MonoBehaviour
{
    Rigidbody2D CameraMoved;
    // Start is called before the first frame update
    void Start()
    {
        CameraMoved = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraMoved.velocity = new Vector2(0.3f, 0);
    }
}
