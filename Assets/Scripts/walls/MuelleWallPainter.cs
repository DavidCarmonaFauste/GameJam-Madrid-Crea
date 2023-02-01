using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuelleWallPainter : MonoBehaviour
{
    public GameObject painting, intObj;

    void Awake()
    {
        if (GameManager.Instance.muellePainted == true)
        {
            painting.SetActive(true);
            intObj.SetActive(false);
        }
    }


}
