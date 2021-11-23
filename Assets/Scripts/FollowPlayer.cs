using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(50,5,0);

    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset; //Para la posición de la cámara le sumamos a la posición del Player el vector 50,5,0, así seguírá al Player a cierta distancia.
    }

}
