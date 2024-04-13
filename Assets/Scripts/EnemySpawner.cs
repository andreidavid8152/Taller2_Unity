using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject rockPrefab;
    public float spawnRate = 5f;
    public GameObject gamePlane; // Referencia al objeto del plano con Mesh Collider
    private MeshCollider meshCollider; // Para almacenar el Mesh Collider del plano

    private float nextTimeToSpawn = 0f;

    void Start()
    {
        meshCollider = gamePlane.GetComponent<MeshCollider>();
    }

    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            SpawnRock();
            nextTimeToSpawn = Time.time + spawnRate;
        }
    }

    void SpawnRock()
    {
        float spawnPosX = Random.Range(meshCollider.bounds.min.x, meshCollider.bounds.max.x);
        float spawnPosZ = Random.Range(meshCollider.bounds.min.z, meshCollider.bounds.max.z);
        float spawnPosY = 1.85f;

        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
        Instantiate(rockPrefab, spawnPosition, Quaternion.identity);
    }
}
