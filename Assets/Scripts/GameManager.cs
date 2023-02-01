using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public Vector2 Mancha { get; set; }
    public string[] GraffitiBinario { get; set; }
    public int NumOuts { get; set; }
    public int NumIns { get; set; }
    [HideInInspector]
    public bool muellePainted, tifonPainted, glubPainted, bleckPainted;

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
        if (_instance == null) // If there is no instance already
        {
            DontDestroyOnLoad(gameObject); // Keep the GameObject, this component is attached to, across different scenes
            _instance = this;
        }
        else if (_instance != this) // If there is already an instance and it's not `this` instance
        {
            Destroy(gameObject); // Destroy the GameObject, this component is attached to
        }
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
