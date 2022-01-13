using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

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
        HighScoreManager.Instance.playerName = nameInput.GetComponent<InputField>().text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
