using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public Vector2 Mancha { get; set; }
    public string[] GraffitiBinario { get; set; }
    public int NumOuts { get; set; }

    public static GameManager Instance
    {
        get
        {
            if (_instance is null)
                Debug.LogError("Game Manager is Null");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;  
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
