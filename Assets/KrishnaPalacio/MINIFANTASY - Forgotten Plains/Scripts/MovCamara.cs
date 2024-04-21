using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public Camera camara;

    private void OnTriggerEnter2D(Collider2D obj){  //PORTAL 1
        if(obj.gameObject.tag == "portal1"){
            Vector3 posicioncamara = new Vector3(53.2f, 54.5f,-10);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(53.2f, 54.5f,-10); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;
        }
        if(obj.gameObject.tag == "portal4"){
            Vector3 posicioncamara = new Vector3(26.6f, 21.3f,0);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(26.6f, 21.3f,0); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;
        

        }
        
        if(obj.gameObject.tag == "portal2"){
            Vector3 posicioncamara = new Vector3(154f, -6.1f, 0);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(154f, -6.1f, 0); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;

        }

        if(obj.gameObject.tag == "portal5"){
            Vector3 posicioncamara = new Vector3(58.7f, -0.3f, 0);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(58.7f, -0.3f, 0); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;

        }

        if(obj.gameObject.tag == "portal3"){
            Vector3 posicioncamara = new Vector3(23.4f, -50.8f, 0);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(23.4f, -50.8f, 0); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;

        }
        if(obj.gameObject.tag == "portal6"){
            Vector3 posicioncamara = new Vector3(16.6f, -16.7f, 0);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(16.6f, -16.7f, 0); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;

        }
         if(obj.gameObject.tag == "portal7"){
            Vector3 posicioncamara = new Vector3(-247.8f, 6.6f, 0);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-247.8f, 6.6f, 0); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;

        }
       if(obj.gameObject.tag == "portal8"){
            Vector3 posicioncamara = new Vector3(-46.6f, 3.5f, 0);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-46.6f, 3.5f, 0); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;

        }
    
    }
}