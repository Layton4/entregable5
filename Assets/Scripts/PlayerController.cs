using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 15.0f; //velocidad a la que se moverá el avión
    private float verticalInput;
    public float turnSpeed = 35.0f;
    private float zMax = -90f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        verticalInput = Input.GetAxis("Vertical"); //asociamos a la variable verticalInput las teclas W y S (equivalente a las flechas arriba y abajo)
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * -verticalInput); //rotará en el eje x si pulsamos W positivamente y negativamente si pulsamos S

        if (transform.rotation.z <= zMax)
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        }
    }
}
