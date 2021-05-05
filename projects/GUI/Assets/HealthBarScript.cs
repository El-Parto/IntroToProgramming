using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


// Needs to keep track of slider's value
// Needs to transition the color from one to the other based on how much health
// And edit the text while doing this
[ExecuteInEditMode]
public class HealthBarScript : MonoBehaviour
{
    [SerializeField]
    private Color fullColor;
    [SerializeField]
    private Color emptyColor = Color.red;
    [SerializeField]
    private Slider healthSlider;
    [SerializeField]
    private TextMeshProUGUI healthText;
    [SerializeField]
    private Image healthDisplay;

    public void Damage(float _amount)
    {
        healthSlider.value -= _amount;
    }

    // Liniar interpolation is moving from one value to another
    // Current / max (divide)

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.value = healthSlider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.color = Color.Lerp(emptyColor, fullColor, Mathf.Clamp01(healthSlider.value / healthSlider.maxValue));
        healthText.text = healthSlider.value.ToString("0");
    }
}
