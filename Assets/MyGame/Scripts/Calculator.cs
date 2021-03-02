using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField Number1;
    public InputField Number2;
    public Text Result;

    public int Number1Int;
    public int Number2Int;
    public int ResultInt;
    
    public void Addition()
    {
        Number1Int = int.Parse(Number1.text);
        Number2Int = int.Parse(Number2.text);
        Result.text = (Number1Int + Number2Int).ToString();
    }

    public void Subtraction()
    {
        Number1Int = int.Parse(Number1.text);
        Number2Int = int.Parse(Number2.text);
        Result.text = (Number1Int - Number2Int).ToString();
    }
}
