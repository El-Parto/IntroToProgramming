using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[AddComponentMenu("UI/Number Button")]

[RequireComponent(typeof(Button))]


public class NumberButton : MonoBehaviour
{
    [SerializeField, Range(0, 9)] private int number = 0;
    private TextMeshProUGUI buttonText;
    private Button button;

    private Calculator calculator;




    // Start is called before the first frame update
    void Start()
    {
        calculator = GetComponentInParent<Calculator>();



        buttonText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = number.ToString();

        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);

        buttonText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }

    private void OnClickButton()
    {
        if(!float.IsPositiveInfinity(calculator.calculatedValue))
        {
            // reset the values here
            calculator.leftHandSide = calculator.calculatedValue;
            calculator.rightHandSide = 0;
            calculator.calculatedValue = float.PositiveInfinity;
        }


        // Get the current float value from the calc and turns it into a string
        float currentFloat = calculator.leftHandSide;
        if(calculator.currentFunction != FunctionalButton.Function.None)
        {
            // We are currently trying to apply an operator so modify the second number
            currentFloat = calculator.rightHandSide;
        }

        string lhsString = currentFloat.ToString();

        if (lhsString.Replace(".", "").Length > 6)
            return;


        // Add this numbers value to the string as text
        lhsString += number.ToString();

        // Convert the string back into a float
        currentFloat = float.Parse(lhsString);


        // If we are applying an operator, set the right hand side to the valie, othersie the lhs
        if(calculator.currentFunction != FunctionalButton.Function.None)
        {
            calculator.rightHandSide = currentFloat;
        }
        else
        {
            calculator.leftHandSide = currentFloat;
        }

    }



}
