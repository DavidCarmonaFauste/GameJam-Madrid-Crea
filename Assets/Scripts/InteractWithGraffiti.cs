using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractWithGraffiti : MonoBehaviour
{
    public string sceneToGoTo;
    [SerializeField]
    private GameObject spacebarObj;
    bool canInteract;

    // Start is called before the first frame update
    void Start()
    {
      //  spacebarObj = GameObject.Find("spacebar");
    }

    // Update is called once per frame
    void Update()
    {
        if(canInteract && Input.GetKeyUp(KeyCode.Space))
        {
            canInteract = false;
            SceneManager.LoadScene(sceneToGoTo, LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canInteract = true;
            Debug.Log("grafifi");
            spacebarObj.SetActive(true);
           
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canInteract = false;
            spacebarObj.SetActive(false);
            //SceneManager.LoadScene(sceneToGoTo, LoadSceneMode.Single);
        }
    }

}
