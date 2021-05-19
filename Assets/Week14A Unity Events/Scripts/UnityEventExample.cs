using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // new namespace required for Unity Events.


public class UnityEventExample : MonoBehaviour
{// unity event system; makes it better for unity, rather than using c# events or event delagates

    // * Unity events MUST be serializable in order to show up in the inspector
    // * they will still work without it, but what's the point of them if they
    // * don't show up? 
    [System.Serializable]
    public class DeathEvent : UnityEvent</*up to 4 params*/ int> { } // we created the type, not the event itself with just this
    // A limit of 4 params, andalways appears at the botom of the list.
    // generic events don't get serialised,
    // so you need to do this ^ 

    //* the Standard within unity is to make the instance of the event
    //* private and then make a read only property to access it
    public DeathEvent OnDeath => onDeath;
    // * even though we hace created the type of the event, we haven't created an
    // * instance of the event itself,so we are doing that here.
    [SerializeField] private DeathEvent onDeath = new DeathEvent();
 //created event, but haven't subscribed to it yet   

    //create the event here
    public void Die()
    {
        // * Run/raise the death event, we add ? to make sure it is not null.
        onDeath?.Invoke(Random.Range(0,10));


        //when you invoke it, that's when you raise it.
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Die(); // raising the event here
        }
    }
}
