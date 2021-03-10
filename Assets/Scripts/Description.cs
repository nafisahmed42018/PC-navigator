using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Description : MonoBehaviour
{
    [SerializeField] Text header;
    [SerializeField] Text description;
    [SerializeField] Image image;
    [SerializeField] ComponentDescription componentID;

    ComponentDescription componentDescription;
    void Update()
    {
        componentDescription = componentID;
        header.text = componentDescription.GetHeader();
        description.text = componentDescription.GetDescription();
        image.sprite = componentDescription.GetImage();
    }
    
}
