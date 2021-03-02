using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField Number1;
    public InputField Number2;
    public Text Result;

    public float Number1Float;
    public float Number2Float;
    
    public void Addition()
    {
        Number1Float = float.Parse(Number1.text);
        Number2Float = float.Parse(Number2.text);
        Result.text = (Number1Float + Number2Float).ToString();
    }

    public void Subtraction()
    {
        Number1Float = float.Parse(Number1.text);
        Number2Float = float.Parse(Number2.text);
        Result.text = (Number1Float - Number2Float).ToString();
    }

    public void Multiply()
    {
        Number1Float = float.Parse(Number1.text);
        Number2Float = float.Parse(Number2.text);
        Result.text = (Number1Float * Number2Float).ToString();
    }

    public void Divide()
    {
        Number1Float = float.Parse(Number1.text);
        Number2Float = float.Parse(Number2.text);
        Result.text = (Number1Float / Number2Float).ToString();
    }
}
