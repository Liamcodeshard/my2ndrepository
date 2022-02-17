// The "using" directives import other classes and functions so we get access to Unity's library, and more.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Our homemade script begins here. Its class name MUST match the file name.
public class Movement_Script : MonoBehaviour
{
    // we can declare variables here
    // the most simple variables can have 4 types
    // int, float, string, bool

    // simply delcaring a variable : we state its type, then its name
    // adding "public" means it gets serialized, so it becomes editable from Unity's inspector
    public float speed;
    public string someText;
    public bool someBoolean;
    public Transform thisobjecttransforms;

    // Start is called before the first frame update
    void Start()
    {
        // we can declare temporary variables within the function's scope (the two brackets)
        int someOtherIntValue = 4;
        // we can assign it to any value...
        someOtherIntValue = 5;
        // ...or to any variable, provided it has the same type.
        // "speed" is not an int, so we proceed to cast it
        someOtherIntValue = (int)speed;
        
        // we can call another function which is declared elsewhere in the same script
        SomeCustomFunction();

        // we can also call another function from another class (another script) if Unity made it accessible.
        // "Debug" is one of these classes. It's a toolbox that contains all the debugging-related functions.
        // The dot . means we're calling the Log function that belongs to the Debug class.
        Debug.Log(someText);

        // simple mathematical operations:
        someOtherIntValue = someOtherIntValue + 7; // addition
        someOtherIntValue = someOtherIntValue - 7; // subtraction
        someOtherIntValue = someOtherIntValue * 7; // multiplication
        someOtherIntValue = someOtherIntValue / 7; // division
        someOtherIntValue = someOtherIntValue % 4; // modulo

        // modulo is the remainder of the division of A by B. For example:
        // 23 % 4 => 3
        // 24 % 4 => 0
        // 25 % 4 => 1
        // 26 % 4 => 2
        // 27 % 4 => 3
        // 28 % 4 => 0

        // Shortcut notation:
        someOtherIntValue += 7; // addition
        someOtherIntValue -= 7; // subtraction
        someOtherIntValue *= 7; // multiplication
        someOtherIntValue /= 7; // division

        // Incrementing or decrementing means +1 or -1. It's useful in so many cases, there's another shortcut for that.
        someOtherIntValue += 1; // incrementation
        someOtherIntValue -= 1; // decrementation
        someOtherIntValue++; // incrementation
        someOtherIntValue--; // decrementation

        // Operations on strings:
        string firstString = "hello";
        string secondString = "world";
        string helloWorldString = firstString + " " + secondString; // concatenate
        // The final result would spell "hello world" (hello, then a space, then world)
    }

    // Update is called once per frame

    
    void Update()
    {
        if (Time.time > 5.0)
        {

        }
        
    }

    // We can declare our own functions
    void SomeCustomFunction()
    {
        speed = 60;
        someText = "I just changed the text";
    }
}