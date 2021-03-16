using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField number1;
    public InputField number2;
    public Text result;
    public Text message;

    float number1Float;
    float number2Float;
    bool bool1;
    bool bool2;

    public void Addition()
    {
        try
        {
            number1Float = float.Parse(number1.text);
            bool1 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField1());
            bool1 = true;
        }

        try
        {
            number2Float = float.Parse(number2.text);
            bool2 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField2());
            bool2 = true;
        }

        if (bool1 == true | bool2 == true)
        {
            result.text = "No Result";
        }
        else
        {
            result.text = (number1Float + number2Float).ToString();
        }
    }

    public void Subtraction()
    {
        try
        {
            number1Float = float.Parse(number1.text);
            bool1 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField1());
            bool1 = true;
        }

        try
        {
            number2Float = float.Parse(number2.text);
            bool2 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField2());
            bool2 = true;
        }

        if (bool1 == true | bool2 == true)
        {
            result.text = "No Result";
        }
        else
        {
            result.text = (number1Float - number2Float).ToString();
        }
    }

    public void Multiplication()
    {
        try
        {
            number1Float = float.Parse(number1.text);
            bool1 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField1());
            bool1 = true;
        }

        try
        {
            number2Float = float.Parse(number2.text);
            bool2 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField2());
            bool2 = true;
        }

        if (bool1 == true | bool2 == true)
        {
            result.text = "No Result";
        }
        else
        {
            result.text = (number1Float * number2Float).ToString();
        }
    }

    public void Division()
    {
        try
        {
            number1Float = float.Parse(number1.text);
            bool1 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField1());
            bool1 = true;
        }

        try
        {
            number2Float = float.Parse(number2.text);
            bool2 = false;
        }
        catch (System.Exception)
        {
            StartCoroutine(turnRedField2());
            bool2 = true;
        }

        if (bool1 == true | bool2 == true)
        {
            result.text = "No Result";
        }
        else
        {
            result.text = (number1Float / number2Float).ToString();
        }
    }

    IEnumerator turnRedField1()
    {
        message.text = "Calculate Numbers, NOT Text!";
        result.text = "No Result";
        number1.text = "Try a valid number";
        number1.image.color = new Color32(255, 0, 0, 255);
        yield return new WaitForSeconds(2);
        number1.image.color = new Color32(255, 255, 255, 255);
        yield return new WaitForSeconds(5);
        number1.text = "Enter Number 2...";
        message.text = "Calculate Numbers!";
    }

    IEnumerator turnRedField2()
    {
        message.text = "Calculate Numbers, NOT Text!";
        result.text = "No Result";
        number2.text = "Try a valid number";
        number2.image.color = new Color32(255, 0, 0, 255);
        yield return new WaitForSeconds(2);
        number2.image.color = new Color32(255, 255, 255, 255);
        yield return new WaitForSeconds(5);
        number2.text = "Enter Number 2...";
        message.text = "Calculate Numbers!";
    }
}
