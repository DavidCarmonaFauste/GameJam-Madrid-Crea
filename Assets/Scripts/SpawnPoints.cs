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
    private int velocity = 2;
    private int step = 0;

    
    public void Start()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {

            if(step < velocity)
            {
                step++;
                return;
            }
            step = 0;
            Debug.Log("puslsando mouse.............");
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

        Debug.Log("x: " + xBin);
        Debug.Log("y: " + (134 - yBin));

        //GameManager.Instance.NumOuts += (int)isIn;
        int i = 0;
        i++;
    }
 }