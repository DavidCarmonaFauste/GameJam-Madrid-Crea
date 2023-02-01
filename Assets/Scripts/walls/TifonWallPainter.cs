using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TifonWallPainter : MonoBehaviour
{
    public GameObject painting, intObj;

    void Awake()
    {
        if (GameManager.Instance.tifonPainted == true) { 

            painting.SetActive(true);
            intObj.SetActive(false);
        }
    }
}
