using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject car;

    private float carRate, nextCar;

    [SerializeField]
    private float minCarRate = 2, maxCarRate = 3;

    // Start is called before the first frame update
    void Start()
    {
        carRate = Random.Range(minCarRate, maxCarRate);
        nextCar = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time > nextCar))
        {

            Instantiate(car, transform.position, transform.rotation);
            nextCar = Time.time + carRate;
        }
    }

}
