using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    //player da seguire
    Transform player;
    //velocità di movimento
    Vector3 velocity=Vector3.zero;
    //offset posto z
    [SerializeField] float z_offset = -10f;
    //offset posto y
   [SerializeField] float y_offset = 3f;
    //con che velocità segue il player
    [SerializeField] float smooth = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform; 
    }
    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 targetPosition = new Vector3(player.position.x, player.position.y + y_offset, player.position.z + z_offset);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smooth);
        }
    }
}
