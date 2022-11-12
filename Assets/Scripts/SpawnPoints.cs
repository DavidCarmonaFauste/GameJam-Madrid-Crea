using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject prefab;
    public float Y;

    private Camera cam;
    private List<Vector2> points = new List<Vector2>();

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            cam = Camera.main;
            Vector2 mousePos = new Vector2();
            mousePos.x = Input.mousePosition.x;
            mousePos.y = cam.pixelHeight - Input.mousePosition.y;
            Vector3 point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));
            points.Add(new Vector2(point.x, point.y * -1));
        }
        if (Input.GetMouseButtonUp(0))
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
        }
    }
}