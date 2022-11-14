using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject prefab;
    public GameObject Fondo;

    public float Y;
    private Camera cam;
    private List<Vector2> points = new List<Vector2>();

    //my variables
    public float velocity = 0.5f;
    private float step = 0.0f;

    
    public void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            if(step < velocity)
            {
                step += Time.deltaTime;
                return;
            }
            step = 0.0f;
           // Debug.Log("puslsando mouse.............");
            cam = Camera.main;
            Vector2 mousePos = new Vector2();
            mousePos.x = Input.mousePosition.x;
            mousePos.y = Input.mousePosition.y;
            GameManager.Instance.Mancha = mousePos;
            Vector3 point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 100));
            Instantiate(
                prefab,
                point,
                Quaternion.identity
            );
            CalculateInOutPoint(mousePos);
        }
        else
        {
            step = 0;
        }
    }
    private void CalculateInOutPoint(Vector2 mousePos)
    {
        float xNorm = mousePos.x / Screen.width;
        float yNorm = mousePos.y / Screen.height;

        int yBin = (int) (yNorm * GameManager.Instance.GraffitiBinario.Length);
        int xBin = (int)(xNorm * GameManager.Instance.GraffitiBinario[yBin].Length);

        char isIn = GameManager.Instance.GraffitiBinario[134 - yBin][xBin];

        int isInNumber = isIn - '0';
        if(isInNumber == 0)
        {
            GameManager.Instance.NumIns++;
        }
        GameManager.Instance.NumOuts += isInNumber;
       Debug.Log(GameManager.Instance.NumOuts);

        int i = 0;
        i++;
    }
 }