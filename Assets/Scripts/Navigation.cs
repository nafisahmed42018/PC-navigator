using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{
    public Button backBtn;


    public List<GameObject> navScreens;
    private GameObject currentScreen = null;

    public void Next()
    {
        int index = navScreens.IndexOf(currentScreen);
        index++;
        SetupState(index);
    }

    public void Previous()
    {
        int index = navScreens.IndexOf(currentScreen);
        index--;
        SetupState(index);
    }

    private void SetupState(int index)
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
