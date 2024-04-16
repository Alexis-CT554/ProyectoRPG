using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public Camera camara;

    private void OnTriggerEnter2D(Collider2D obj){  //PORTAL 1
        if(obj.gameObject.tag == "portal1"){
            Vector3 posicioncamara = new Vector3(1, 1, 1);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(1, 1, 1); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;

        }
  if(obj.gameObject.tag == "portal2"){
            Vector3 posicioncamara = new Vector3(1, 1, 1);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(1, 1, 1); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;

        }

          if(obj.gameObject.tag == "portal3"){
            Vector3 posicioncamara = new Vector3(1, 1, 1);  //POSICION CAMERA
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(1, 1, 1); //POSICION PERSONAJE
            this.transform.position = posicionPlayer;

        }

    }
}