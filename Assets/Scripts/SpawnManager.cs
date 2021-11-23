using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    private float TimeFirstSpawn = 0.5f;
    private float TimeSpawn = 5f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", TimeFirstSpawn, TimeSpawn); //usamos la funci�n spawnobstacle, a los 0.5 segundos de darle a play y luego se vuelve a ejecutar cada 5 segundos.
    }

    public void SpawnObstacle()
    {
        float randomY = Random.Range(-10f, 10f); //generamos un n�mero random entre -10 y 10
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50f); //La posici�n de cada obst�culo queremos que sea 50 metros m�s alante que el anterior y a una altura aleatoria entre -10 y 10

        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); //esta funci�n generar� el prefab en la posici�n spawnPose y con la rotaci�n que ya tiene el prefab
    }
}
