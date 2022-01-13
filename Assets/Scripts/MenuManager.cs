using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuManager : MonoBehaviour
{
    public GameObject nameInput;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // For Start Button
    public void StartNew()
    {
        HighScoreManager.Instance.playerName = nameInput.GetComponent<TMP_InputField>().text;
        Debug.Log(HighScoreManager.Instance.playerName);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
