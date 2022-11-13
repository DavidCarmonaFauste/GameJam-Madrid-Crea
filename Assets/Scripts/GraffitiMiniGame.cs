using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraffitiMiniGame : MonoBehaviour
{
    public string GraffitiBinario;
    public Sprite mySprite;
    private SpriteRenderer srTex;


    void Awake()
    {
        srTex = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        srTex.color = new Color(0.5f, 0.5f, 0.5f, 0.3f);
        transform.position = new Vector3(1.5f, 1.5f, 0.0f);
        GameManager.Instance.GraffitiBinario = new string[240];
    }

    void Start()
    {

        srTex.sortingOrder = -1;

        //mySprite = Sprite.Create(tex[0], new Rect(0.0f, 0.0f, Screen.width, Screen.height), new Vector2(0.5f, 0.5f), 100.0f);
        srTex.sprite = mySprite;
        srTex.transform.position = new Vector3(0, 0, -1);
        srTex.transform.localScale = new Vector3(1,1,1);

        var textFile = Resources.Load<TextAsset>(GraffitiBinario);
        GameManager.Instance.GraffitiBinario = textFile.text.Split('\n');


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
