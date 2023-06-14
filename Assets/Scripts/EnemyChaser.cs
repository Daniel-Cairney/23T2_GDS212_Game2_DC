using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyChaser : MonoBehaviour
{
    public float movementSpeed = 5f;
    public string sceneToLoad;

    private GameObject player;

    private void Start()
    {
        // Find the player object by tag
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        // Check if player object exists
        if (player != null)
        {
            // Calculate direction towards the player
            Vector3 direction = (player.transform.position - transform.position).normalized;

            // Move towards the player
            transform.position += direction * movementSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadScene();
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}

