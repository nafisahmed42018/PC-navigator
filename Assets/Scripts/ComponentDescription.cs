using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Component Description")]

public class ComponentDescription : ScriptableObject
{
    [SerializeField] string headerComponent;
    [TextArea(10,14)][SerializeField] string textComponent;
    [SerializeField] Sprite imageComponent;

    public string GetHeader() 
    {
        return headerComponent;
    }
    public string GetDescription() 
    {
        return textComponent;
    }
    public Sprite GetImage()
    {
        return imageComponent;
    }
    
}
