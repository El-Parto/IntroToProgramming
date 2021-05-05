using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePrinter : MonoBehaviour
{

    private IShape[] shapes;


    // Start is called before the first frame update
    void Start()
    {
        //shapes = gameObject.GetComponentsInChildren<IShape>();
        shapes = gameObject.GetComponentsInChildren<TwoDimentionalShape>();
        // any object that is in any children of this script, allthe way down in the hierarchy that it iNherits,
        // it'll now have access to.

        /*
        foreach (IShape shape in shapes)
        {
            Debug.LogError($"{shape.Name} : {shape.Width} , {shape.Height}");

        }
        */

        //we've just implemented the specifics of the ellipse here.
        foreach (TwoDimentionalShape shape in shapes)
        {
            Debug.LogError($"{shape.Name} : {shape.Width} , {shape.Height} : Area = {shape.Area()} : Perimeter = {shape.Perimeter()}");

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
