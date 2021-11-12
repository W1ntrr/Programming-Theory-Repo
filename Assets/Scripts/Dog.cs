using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    
    void Start()
    {
        age = 4;
        AnimalName = "Dog";
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        base.DisplayText();
        infoText.text = "\nName: " + m_AnimalName + " \nAge: " + age;
    }
}
