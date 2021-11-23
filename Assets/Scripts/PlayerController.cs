using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 12.0f; //velocidad a la que se moverá el avión
    private float verticalInput;
    private float turnSpeed = 35.0f;
    private float zMax = 450f;


    void Start()
    {
        transform.position = Vector3.zero; //cuando empiece el juego el gameobject estará en la posición 0,0,0
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); //movimiento constante hacia adelante

        verticalInput = Input.GetAxis("Vertical"); //asociamos a la variable verticalInput las teclas W y S (equivalente a las flechas arriba y abajo)
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * -verticalInput); //rotará en el eje x si pulsamos W positivamente y negativamente si pulsamos S

        if (transform.position.z >= zMax) //al llegar a cierta distancia del inicio en la coordenada z, 450
        {
            Debug.Log("THE END"); //mostramos por consola el mensaje THE END
            Time.timeScale = 0; //El juego se termina
        }
    }
}
