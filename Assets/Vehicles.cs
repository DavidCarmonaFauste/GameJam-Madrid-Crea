using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicles : MonoBehaviour
{
    [SerializeField]
    private float speed, lifeTime;

     Transform t;
     Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        t = GameObject.Find("vehicle_target").transform;
        target = new Vector2(t.position.x, t.position.y);
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
