using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GraffitiChecker : MonoBehaviour
{
    public string sceneToGoTo;
    [SerializeField]
    float minPointsToGo, outsForPerfect, outsForGood, outsForOK, outsForBad;

    public GameObject nextSceneButton, fadePanel;
    public GameObject perfectText, goodText, okText, badText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.Instance.NumIns >= minPointsToGo)
        {
            nextSceneButton.SetActive(true);
        }
    }

    public void NextScene()
    {
        StartCoroutine(GoToNextScene());
        
        if (GameManager.Instance.NumOuts <= outsForPerfect)
            perfectText.SetActive(true);
        if(GameManager.Instance.NumOuts > outsForPerfect && GameManager.Instance.NumOuts <= outsForGood)
            goodText.SetActive(true);
        if (GameManager.Instance.NumOuts > outsForGood && GameManager.Instance.NumOuts <= outsForOK)
            okText.SetActive(true);
        if (GameManager.Instance.NumOuts >= outsForBad)
            okText.SetActive(true);
    }

    private IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(3f);
        fadePanel.SetActive(true);
        SceneManager.LoadScene(sceneToGoTo, LoadSceneMode.Single);
    }
}
