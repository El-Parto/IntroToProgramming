using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//(Note) Abstract classes even when being a MonoBehaviour, cannot be added to Gameobjects
// as components as you cannot instance abstract classes. 
// Any classes with any abstract function MUST be marked as Abstract.
//Not the best with Picasso
//you can't create an instance of this script.
public abstract class Person : MonoBehaviour
{// any class that has abstract functionality must have the abstract named or else it wont run

    // abstract can only be either public or protected. Must be overriden in inherited classes.
    // * Abstract functions can't have a method body and can only exist with an abstract class.
    // * They can only be marked as protected or public as they need to be accessible to any inherited class.
    protected abstract int GetID();

    
    protected abstract string GetPersonType();



    

    // Start is called before the first frame update
    void Start()
    {
                    
        Debug.Log($"{GetPersonType()}: {GetID()}"); // logs  "person ID;" with GetId
       //             person ID         RNG based number           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}





// if the inherited class is abstract, then you don't need to have abstract 