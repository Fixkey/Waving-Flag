using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{

    public Material mat;

    public void onValueChanged(float value)
    {
        mat.SetFloat("_Amplitude", value);
    }

    public void ChangeSpeed(float value)
    {
        mat.SetFloat("_Speed", value);
    }

    public void ChangeFrequency(float value)
    {
        mat.SetFloat("_Frequency", value);
    }
}
