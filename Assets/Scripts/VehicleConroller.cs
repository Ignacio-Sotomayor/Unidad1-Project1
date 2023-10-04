using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleConroller : MonoBehaviour{
    
    //inicializacion de la variables
    private float Velocity = 20f;
    private float TurnSensibility = 45f;
    private float HorizontalInput = 0f;
    private float ForwardInput = 0f;

    // Update is called once per frame
    void Update(){

        //Actualizacion de velocidad segun precion del jugador
        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");

        //Mover el objeto
        transform.Rotate(Vector3.up, Time.deltaTime * HorizontalInput * TurnSensibility);
        transform.Translate(Vector3.forward * Time.deltaTime * Velocity * ForwardInput);
    }
}
