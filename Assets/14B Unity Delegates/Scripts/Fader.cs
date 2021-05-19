using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public delegate void FadeCallback(); //out side of the class because it shortens the amount of code.


[RequireComponent(typeof(Image))]
public class Fader : MonoBehaviour
{
    [SerializeField] private Color solid = Color.black; // black colour
    [SerializeField] private Color faded = Color.clear; // alpha/clear
    [SerializeField, Range(.1f, 10f)] private float fadeTime = 1f;

    private Image image;

    // making a delagate type, one of the few data types can run outside of the class
    // without affecting the compiler
    
    
    //lambda version you could include {}
    void Start() => image = gameObject.GetComponent<Image>();

    //for delegate
    public void FadeDown(FadeCallback _callback = null)
    {
        StartCoroutine(FadeToSolid(_callback));
    }

    private IEnumerator FadeToSolid(FadeCallback _callback = null)//the param is for delegates
    {
        // * To store the time we are currently at for the lerp function
        float currentTime = 0;


        // * Loop until currenttime exceeds fadeTime
        while(currentTime < fadeTime)
        {
            // * Add the deltaTime to the currentTime and get the lerp factor
            currentTime += Time.deltaTime;

            //great way for lerping value
            float factor = Mathf.Clamp01(currentTime / fadeTime);

            //* Update the image color by the interpolated value of solid and clear

            image.color = Color.Lerp(faded, solid, factor);
            //                                   by a factor of

            //* wait until next frame
            yield return null;
            // yield return is checking//waiting for the condition 
        }

        // * force the image color to be the solid colour in case of floating point check errors

        image.color = solid;

        // * run the callback for the fade being completed
        _callback?.Invoke(); //callback null? invoke.(?)
        //function as the variable


    }
}
