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
    public bool caught1;
    public bool caught2;

    public void Addition()
    {
        try
        {
            number1Float = float.Parse(Number1.text);
            caught1 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField1());
            caught1 = true;
        }
        try
        {
            number2Float = float.Parse(Number2.text);
            caught2 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField2());
            caught2 = true;
        }
        if (caught1 == true | caught2 == true)
        {
            Result.text = "No Result";
        }
        else
        {
            
            Result.text = (number1Float + number2Float).ToString();
            //caught1 = false;
            //caught2 = false;
        }
    }

    public void Subtraction()
    {
        try
        {
            number1Float = float.Parse(Number1.text);
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField1());
        }

        try
        {
            number2Float = float.Parse(Number2.text);
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField2());
        }
        
        Result.text = (number1Float - number2Float).ToString();
    }

    public void Multiply()
    {
        try
        {
            number1Float = float.Parse(Number1.text);
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField1());
        }
        try
        {
            number2Float = float.Parse(Number2.text);
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField2());
        }
        Result.text = (number1Float * number2Float).ToString();
    }

    public void Divide()
    {
        try
        {
            number1Float = float.Parse(Number1.text);
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField1());
        }

        try
        {
            number2Float = float.Parse(Number2.text);
            
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField2());
        }
        Result.text = (number1Float / number2Float).ToString();
    }
    IEnumerator turnRedField1()
    {
        Result.text = "No Result";
        Number1.image.color = new Color32(255, 0, 0, 255);
        yield return new WaitForSeconds(2);
        Number1.image.color = new Color32(255, 255, 255, 255);
    }
    IEnumerator turnRedField2()
    {
        Result.text = "No Result";
        Number2.image.color = new Color32(255, 0, 0, 255);
        yield return new WaitForSeconds(2);
        Number2.image.color = new Color32(255, 255, 255, 255);
    }
}
