using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBG : MonoBehaviour
{
    //ultimo posto della camera
    float lastCameraX;
    //asse x come si muove la camera
    float currentCameraX;

    //velocità di movimento
    [SerializeField] float parallaxSpeed=20f;

    //elemento su cui operiamo è la camera
    Transform cam;
    // Start is called before the first frame update
    //Background va a sinistra quando player va a destra e va a destra quando giocatore va a sinistra
    void Start()
    {
        //salvata transform della camera
        cam = Camera.main.transform;

        //dò la camera corrente iniziale con current e last uguali
        lastCameraX = cam.position.x;
        currentCameraX = lastCameraX;
    }

    // Update is called once per frame
    void Update()
    {
        //nuova camera appena mossa
        currentCameraX = cam.position.x;
        //variazione di ora
        float delta = currentCameraX - lastCameraX;

        //si è spostata e voglio cambiare lo sfondo
        if (Mathf.Abs(delta) > 0) 
        {
            Vector3 newPosition = new Vector3(transform.position.x-delta,transform.position.y,transform.position.z);
            //permette di muovere lo sfondo dietro
            transform.position = Vector3.MoveTowards(transform.position, newPosition, Time.deltaTime * parallaxSpeed);
            //ora la camera modificata corriponde a quella corrent
            lastCameraX = currentCameraX;
        }
        if(Mathf.Abs(delta)==0) lastCameraX = currentCameraX;
    }
}
