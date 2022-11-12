using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject prefab;
    public float Y;
    public GameManager Instance; // A static reference to the GameManager instance
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
            Instance.setStain(mousePos);
            Vector3 point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 100));
            Instantiate(
                prefab,
                point,
                Quaternion.identity
            );

            points.Add(new Vector2(point.x, point.y * -1));
        }
        else
        {
            step = 0;
        }
        /*if (Input.GetMouseButtonUp(0))
        {
            float totalDistance = 0;
            for (int i = 0; i < points.Count - 1; i++)
            {
                totalDistance += Vector2.Distance(points[i], points[i + 1]);
            }
            float averageDistance = totalDistance / (points.Count - 1);

            // Spawning first Point
            Vector2 lastPoint = points[0];
            Instantiate(
                prefab,
                new Vector3(lastPoint.x, lastPoint.y,Y),
                Quaternion.identity
            );
            // Spawning other Points
            for (int i = 0; i < points.Count - 1; i++)
            {
                Vector2 spawnPos = lastPoint + ((points[i + 1] - lastPoint).normalized * averageDistance);

                lastPoint = spawnPos; //Save the new point because you want create the next one from this one
                Instantiate(
                    prefab,
                    new Vector3(spawnPos.x, spawnPos.y, Y),
                    Quaternion.identity
                );
            }
            // Resetting List
            points = new List<Vector2>();
        }*/
    }
}