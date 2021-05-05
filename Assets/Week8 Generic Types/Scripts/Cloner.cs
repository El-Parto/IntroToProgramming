using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 8b Generic types
///  it means anything.
///  You tell it what it's going to become
///  
/// turning this into a generic type
/// 
/// </summary>

// Where T : person // Where T inherits from Person, it's holding Person. 
// Anything thing that's in here is Person
// * A generic Type can contain any Standard c;ass type
// * The standard is to name the first type in a generic "T"
// * using " where T : "  means that the type after " : " is the 
// * minimum type that " T " must be
// * In this case, 'T' must be inheriting from Person in someway
// * Adding "new()" after the type means that you can create an
// * instance of the other generic type. But this means that type "T" MUST HAVE an default contstructor to it.
public class Cloner<T> where T : Person, new() 
    // where is usually better when you need to specify a time
{// T stand for type. it's the standard.
    private List<T> people = new List<T>();

    // * Generating a default constructor to do nothing
    // * But will allow us to create a cloner with no people in it by default
    public Cloner() { }
    //  you could have a cloner with no data so you can have data in it later.

    //constructor
    public Cloner(int _amount) => ClonePeople(_amount); // added lambda and ClonePeople
   /* {
        for(int i = 0; i < _amount; i++)
        {
            // new T will not work if you do not have new() when declaring the class (see line 22)
            people.Add(new T());
        }
    }
   */
    public void ClonePeople(int _amount)
    {
        for (int i = 0; i < _amount; i++)
        {
            people.Add(new T());
        }
    }




    //remember arrays cannot be changed
    public T[] GetPeople() => people.ToArray();



}
