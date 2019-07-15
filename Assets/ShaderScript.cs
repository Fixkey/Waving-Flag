using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour
{

    public Material mat;
    public float _Speed = 0;
    public float _Frequency = 0.302f;
    public float _Amplitude = 0.46f;

    // Update is called once per frame
    void Update()
    {
        mat.SetFloat("_Speed", _Speed);
        mat.SetFloat("_Frequency", _Frequency);
        mat.SetFloat("_Amplitude", _Amplitude);
    }
}
