using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public string name;
    public GameObject inputField;
    public GameObject submitButton;
    public GameObject inputText;
    public List<GameObject> navScreens;
    private GameObject currentScreen = null;

    void Start()
    {
        name = PlayerPrefs.GetString("Name");
        Hide();
        Invoke("Show", 1f);
        SetupScreen(0);
    }




    public void Show()
    {
        inputField.SetActive(true);
        submitButton.SetActive(true);
    }

    public void Hide()
    {
        inputField.SetActive(false);
        submitButton.SetActive(false);
    }
      
    public void PlayerName()
    {
        name = inputText.GetComponent<Text>().text;
        PlayerPrefs.SetString("Name", name);
        SetupScreen(1);
    }


    private void SetupScreen(int index)
    {
        index = Mathf.Clamp(index, 0, navScreens.Count - 1);

        if (currentScreen)
        {
            currentScreen.SetActive(false);
        }
        currentScreen = navScreens[index];
        currentScreen.SetActive(true);
    }
}
