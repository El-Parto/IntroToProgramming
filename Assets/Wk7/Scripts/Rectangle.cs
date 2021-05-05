using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour , IShape
{
    public float Height => height;

    public float Width => width;

    public string Name => "Rectangle";


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
}
