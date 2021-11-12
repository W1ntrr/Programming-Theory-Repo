using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Horse : Animal
{
    
    void Start()
    {
        age = 26;
        AnimalName = "Horse";
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        base.DisplayText();
        infoText.text = "\nName: " + m_AnimalName + "\nAge: " + age;
    }
}
