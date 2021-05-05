using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// where things turn abstract and gets real powerful-ish

public abstract class TwoDimentionalShape : MonoBehaviour , IShape, I2DMaths
{

    public float Height => height;

    public float Width => width;

    public abstract string Name { get; }


    [SerializeField]
    private float height = 5; // also referenced in I2DMaths where it's getting thi
    [SerializeField]
    private float width = 5;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract float Area();


    public abstract float Perimeter();
    
}
