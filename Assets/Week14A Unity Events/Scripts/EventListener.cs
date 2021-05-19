using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{

    //This is the listener
    // * The event listener. A listener is a functionthat is waiting
    // * to be called in a 'batch' by the event publisher.
    // * A listener is also known as a 'Subscriber'
    public void OnDeath(int _someRandomNumber)
    {
        Debug.Log(_someRandomNumber);
    }

    public void OnDeathSqrd(int _number)
    {
        Debug.LogError($"Death Squared = {_number + _number}");
    }
}
