using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField Number1;
    public InputField Number2;
    public Text Result;
    

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void Addition()
    {
        Result.text = Number1.text + Number2.text;
    }

    public void Subtraction()
    {

    }
}
