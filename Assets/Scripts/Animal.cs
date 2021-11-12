using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animal : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI infoText;
    protected int age;

    // ENCAPSULATION
    protected string m_AnimalName;
    public string AnimalName
    {
        get { return m_AnimalName; }
        set
        {
            if(value.Length > 15)
            {
                Debug.LogError("Your animal name is too long!");
            }
            else
            {
                m_AnimalName = value;
            }
        }
    }
    
    // POLYMORPHISM
    protected virtual void DisplayText()
    {
        infoText.text = "Animal \nName: " + m_AnimalName + " \nAge: " + age;
    }

    protected void OnMouseDown()
    {
        // ABSTRACTION
        DisplayText();
    }
}
