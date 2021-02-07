using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public InputField NameField;
    [SerializeField] Button startB;
    public static string CurrentName;


    // Update is called once per frame
    void Update()
    {
        if (string.IsNullOrEmpty(NameField.text))
        {
            startB.gameObject.SetActive(false);
        }
        else
            startB.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        CurrentName = NameField.text;
    }
}
