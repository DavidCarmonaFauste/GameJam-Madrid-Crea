using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraffitiMiniGame : MonoBehaviour
{
    public Texture2D [] tex;
    private string[] binaries;
    public Sprite mySprite;
    private SpriteRenderer sr;

    void Awake()
    {
        sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        sr.color = new Color(0.9f, 0.9f, 0.9f, 1.0f);

        transform.position = new Vector3(1.5f, 1.5f, 0.0f);
        binaries = new string[240];
    }

    void Start()
    {
        //mySprite = Sprite.Create(tex[0], new Rect(0.0f, 0.0f, Screen.width, Screen.height), new Vector2(0.5f, 0.5f), 100.0f);
        sr.sprite = mySprite;
        sr.transform.position = new Vector3(0, 0, 0);
        sr.transform.localScale = new Vector3(1,1,1);

        var textFile = Resources.Load<TextAsset>("GrafitiMuelle");
        binaries = textFile.text.Split('\n');

       // Debug.Log(textFile.text.Length);
        //for (int i = 0; i < textFile.text.Length; i++)
        //{
        //    binaries[i] = textFile.text.Split('\n');
        //}

    }

    void Update()
    {
        
    }

    void OnGUI()
    {
      
    }
}
