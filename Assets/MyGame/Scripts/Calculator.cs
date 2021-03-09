using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField Number1;
    public InputField Number2;
    public Text Result;
    public Text Message;

    public float number1Float;
    public float number2Float;
    
    public void Addition()
    {
        try
        {
            number1Float = float.Parse(Number1.text);
        }
        catch (System.Exception)
        {
            Message.text = "Try again with numbers";
        }
        try
        {
            number2Float = float.Parse(Number2.text);

        }
        catch (System.Exception)
        {
            Message.text = "Try again with numbers";
        }
        Result.text = (number1Float + number2Float).ToString();
    }

    public void Subtraction()
    {
        try
        {
            number1Float = float.Parse(Number1.text);
        }
        catch (System.Exception ex)
        {

        }
        try
        {
            number2Float = float.Parse(Number2.text);
        }
        catch (System.Exception ex)
        {

        }
        Result.text = (number1Float - number2Float).ToString();
    }

    public void Multiply()
    {
        try
        {
            number1Float = float.Parse(Number1.text);
        }
        catch (System.Exception ex)
        {

        }
        try
        {
            number2Float = float.Parse(Number2.text);
        }
        catch (System.Exception ex)
        {

        }
        Result.text = (number1Float * number2Float).ToString();
    }

    public void Divide()
    {
        try
        {
            number1Float = float.Parse(Number1.text);
        }
        catch (System.Exception ex)
        {

        }
        try
        {
            number2Float = float.Parse(Number2.text);
        }
        catch (System.Exception ex)
        {

        }
        Result.text = (number1Float / number2Float).ToString();
    }
}
