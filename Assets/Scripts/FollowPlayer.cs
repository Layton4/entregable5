using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(50,5,0);

    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset; //Para la posici�n de la c�mara le sumamos a la posici�n del Player el vector 50,5,0, as� segu�r� al Player a cierta distancia.
    }

}
