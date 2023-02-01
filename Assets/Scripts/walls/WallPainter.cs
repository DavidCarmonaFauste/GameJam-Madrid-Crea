using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPainter : MonoBehaviour
{

    public GameObject glubPainting, intObj;

    void Awake()
    {
        if (GameManager.Instance.glubPainted == true) {
            glubPainting.SetActive(true);
            intObj.SetActive(false);
        }
            
    }
}
