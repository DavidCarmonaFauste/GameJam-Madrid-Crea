using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleckWallPainter : MonoBehaviour
{
    public GameObject painting, intObj;

    void Awake()
    {
        if (GameManager.Instance.bleckPainted == true) { 
            painting.SetActive(true);
            intObj.SetActive(false);
        }
    }
}
