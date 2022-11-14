using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    Vector2 playerPos;
     GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
        Debug.Log(playerPos);
    }
}
