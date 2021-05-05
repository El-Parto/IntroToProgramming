using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class Calculator : MonoBehaviour
{
    public float leftHandSide = 0;
    public float rightHandSide = float.PositiveInfinity;
    public float calculatedValue = float.PositiveInfinity;

    // The function that is currently being applied to the left and right hand side variables 
    [System.NonSerialized]
    public FunctionalButton.Function currentFunction = FunctionalButton.Function.None;



    [SerializeField] private TextMeshProUGUI outputDisplay;



    public void ClearHistory()
    {
        leftHandSide = 0;
        rightHandSide = float.PositiveInfinity;
        currentFunction = FunctionalButton.Function.None;
    }



    public void Calculate()
    {
        switch (currentFunction)
        {
            case FunctionalButton.Function.Modulus:
                calculatedValue = leftHandSide % rightHandSide;
                break;
            case FunctionalButton.Function.Divide:
                calculatedValue = leftHandSide / rightHandSide;
                break;
            case FunctionalButton.Function.Multiply:
                calculatedValue = leftHandSide * rightHandSide;
                break;
            case FunctionalButton.Function.Subtract:
                calculatedValue = leftHandSide - rightHandSide;
                break;
            case FunctionalButton.Function.Add:
                calculatedValue = leftHandSide + rightHandSide;
                break;
        }
    }








    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        outputDisplay.text = GetOutputDisplay();
    }


    private string GetOutputDisplay()
    {
        if(float.IsPositiveInfinity(rightHandSide))
        {
            return leftHandSide.ToString();
        }

        else if(float.IsPositiveInfinity(calculatedValue))
        {
            return rightHandSide.ToString();
        }

       
       return calculatedValue.ToString();




    }


    public void SetFunction(FunctionalButton.Function _function)
    {
        currentFunction = _function;
        rightHandSide = 0;
    }





    

    public void SetNumber(int _number)
    {
        if (!float.IsPositiveInfinity(calculatedValue))
        {
            // reset the values here
            leftHandSide = calculatedValue;
            rightHandSide = 0;
            calculatedValue = float.PositiveInfinity;
        }

        string lhsString = GetValueString();

        if (lhsString.Replace(".", "").Length > 6)
            return;

        // Add this numbers value to the string as text
        lhsString += _number.ToString();

        SetValue(lhsString);
    }


    public void Backspace()
    {
        string valueString = GetValueString();

        valueString = valueString.Substring(0, valueString.Length - 1);

        SetValue(valueString);
    }
        
    private string GetValueString()
    {

        // Get the current float value from the calc and turns it into a string
        float currentFloat = leftHandSide;
        if (currentFunction != FunctionalButton.Function.None)
        {
            // We are currently trying to apply an operator so modify the second number
            currentFloat = rightHandSide;
        }

        return currentFloat.ToString();
    }

    private void SetValue(string _value)
    {
        // Convert the string back into a float
        float currentFloat = float.Parse(_value);

        // If we are applying an operator, set the right hand side to the valie, othersie the lhs
        if (currentFunction != FunctionalButton.Function.None)
        {
            rightHandSide = currentFloat;
        }
        else
        {
            leftHandSide = currentFloat;
        }
    }




}



