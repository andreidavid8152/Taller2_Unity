using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnRate = 2f;
    public GameObject gamePlane; // Referencia al objeto del plano con Mesh Collider
    private MeshCollider meshCollider; // Para almacenar el Mesh Collider del plano
    public float coinLifetime = 10f; // Tiempo de vida de cada moneda

    private float nextTimeToSpawn = 0f;

    void Start()
    {
        // Obtener el Mesh Collider del plano
        meshCollider = gamePlane.GetComponent<MeshCollider>();
    }

    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            SpawnCoin();
            nextTimeToSpawn = Time.time + spawnRate;
        }
    }

    void SpawnCoin()
    {
        float spawnPosX = Random.Range(meshCollider.bounds.min.x, meshCollider.bounds.max.x);
        float spawnPosZ = Random.Range(meshCollider.bounds.min.z, meshCollider.bounds.max.z);
        float spawnPosY = 1.85f;

        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
        GameObject coin = Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        Destroy(coin, coinLifetime); // Destruye la moneda después de un tiempo establecido
    }
}
