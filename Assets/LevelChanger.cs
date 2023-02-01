using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    [SerializeField]
    private LevelConnection connection;

    [SerializeField]
    private string targetSceneName;

    [SerializeField]
    private Transform spawnPoint;

    private void Start()
    {
        if(connection == LevelConnection.ActiveConnection)
        {
            FindObjectOfType<Player>().transform.position = spawnPoint.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.collider.GetComponent<Player>();

        if(player != null) 
        {
            LevelConnection.ActiveConnection = connection;
            SceneManager.LoadScene(targetSceneName);
        }
        
       
    }
}
