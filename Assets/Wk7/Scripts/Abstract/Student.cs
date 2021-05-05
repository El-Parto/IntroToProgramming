using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Unity message override parent
//don't need void Update and Void Start.

public class Student : Person
{
    // when in play, this will givve you a random number between X and Y (1mil and 9 mil)
    // * Lambdas (Calrissian) are just one one line finctions that can re-route te code to piece of data.
    //  In this case it is the same as just returning the values.
    protected override int GetID() => Random.Range(1000000, 9000000); 


     

    protected override string GetPersonType() => "Student ID";

}