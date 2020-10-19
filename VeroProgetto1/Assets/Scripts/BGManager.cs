using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGManager : MonoBehaviour
{
    //vettore di background
    public Transform[] bgs;

    //ultimo bg di lavoro prima di tornare
    Transform lastBg;

    float lastXBg = 0f;

    void FindLastPoolingCoordinate(Transform[] objects)
    {
        //array lungo indici dove vedo l'insieme dei background
        for (int i = 0; i <= objects.Length - 1; i++)
        {
            if (objects[i].position.x > lastXBg)
            {
                lastBg = objects[i];
                lastXBg = objects[i].position.x;
            }
            //chiamo affinchè sposto un background alla fine 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        FindLastPoolingCoordinate(bgs);
        //dove piazzare primo background che va
        //addosso al box collider
    }

  

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "background")
        {
            float size = col.bounds.size.x;
            //spostare il nuovo background a destra nell'ultimo background
            Vector3 newPosition = new Vector3(lastBg.transform.position.x+size,col.transform.position.y,col.transform.position.z);
            col.transform.position = newPosition;
            lastBg = col.gameObject.transform;
        }
        //ricrea background quando arrivo alla fine
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
