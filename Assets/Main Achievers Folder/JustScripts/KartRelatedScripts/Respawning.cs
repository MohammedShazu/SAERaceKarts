using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawning : MonoBehaviour
{
    public int maxHealth;
    public int playerHealth;

    private Transform spawnPoint;
    private Transform playerPos;

    private void Start()
    {
        playerHealth = maxHealth;

        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        spawnPoint = GameObject.FindGameObjectWithTag("Respawn").transform;

    }

    public void PlayerTakeDamage(int Damage)
    {
        playerHealth = playerHealth - Damage;
        if (playerHealth <= 0)
        {
            playerHealth = maxHealth;
            playerPos.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
