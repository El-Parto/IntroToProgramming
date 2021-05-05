using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//base class can use functionality without knowing what it is.
public class Teacher : Person
{
    protected override int GetID() => Random.Range(0, 10);
    
    

    protected override string GetPersonType() => "Teacher"; 
    
}
