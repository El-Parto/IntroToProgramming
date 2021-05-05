using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipse : TwoDimentionalShape/*MonoBehaviour , IShape*/
{
    //    public float Height => height;

    //   public float Width => width; removed these after creating the "TwoD" script

    // public override string Name => "Ellipse";

    public override string Name => "Ellipse";

    public override float Area() => Mathf.PI * Width * Height;

    public override float Perimeter()
    {
        float a = Mathf.Pow(Width, 2);
        float b = Mathf.Pow(Height, 2);
        float sqrRoot = Mathf.Sqrt((a + b) / 2);

        return 2 *  Mathf.PI * sqrRoot;
    }
    /*
 This was commented as soon as TwoDimensional Shape reared it's ugly head.
   [SerializeField]
   private float height = 5; // also referenced in I2DMaths where it's getting this.
   [SerializeField]
   private float width = 5;
*/




}
