using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{

    public Transform lookAt;
    public float boundX = 0.15f;
    public float boundY = 0.05f;
    //LateUpdate weil die Kamera nach der Bewegung erst reagieren soll
    void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        //Kontrolle, ob wir auf innerhalb der Außengrenzen der X-Achse sind
        float deltaX = lookAt.position.x - transform.position.x; // Zentrum der Kamera
            if(deltaX > boundX || deltaX < -boundX){//Wenn die Kamera recht || links ausserhalb der Grenze ist
            if(transform.position.x < lookAt.position.x){  // Kontrolle, ob der Fokus der Kamera "kleiner" als der Spieler, also ist der Spieler rechts und die Kamera links
                delta.x = deltaX - boundX;
            }
            else{
                delta.x = deltaX + boundX;
            }
        }

        //Kontrolle, ob wir auf innerhalb der Außengrenzen der Y-Achse sind
        float deltaY = lookAt.position.y - transform.position.y;

        if(deltaY > boundY || deltaY < -boundY){
            if(transform.position.y < lookAt.position.y){
                delta.y = deltaY - boundY;
            }
            else{
                delta.y = deltaY + boundY;
            }
        }
        transform.position += new Vector3(delta.x,delta.y,0);
    }
}
