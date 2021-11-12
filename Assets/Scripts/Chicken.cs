using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Chicken : Animal
{
    
    void Start()
    {
        age = 5;
        AnimalName = "Chicken";
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        base.DisplayText();
        infoText.text = "\nName: " + m_AnimalName + " \nAge: " + age;
    }
}
