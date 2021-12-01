using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatBarScript : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMaxValue (int amount)
    {
        slider.maxValue = amount;
        slider.value = amount;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetStat(int amount)
    {
        slider.value = amount;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
