using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasControl : MonoBehaviour
{
    public Text UIText; 
    public Slider UISlider;
    public InputField UIInputField;
    public GameObject UIPanel;
    int count = 0;

    public void MYButton(){
        UIText.text = "HEllo";
        UIPanel.SetActive(!UIPanel.activeSelf);
    }  

    public void MyToggle(bool state){
        UIText.text = state.ToString();
    }

    public void MySlider(){
        UIText.text = UISlider.value.ToString();
    }

    public void MyDropdown(int choice){
        UIText.text = choice.ToString();
    }

    public void MyInputField(){
        UIText.text = UIInputField.text;
    }

}
