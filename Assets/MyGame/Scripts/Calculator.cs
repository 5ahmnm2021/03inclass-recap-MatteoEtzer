using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    //inputfields
    public InputField number1;
    public InputField number2;

    //textfields
    public Text result;
    public Text message;

    //floats
    float number1Float;
    float number2Float;

    //bools
    bool bool1;
    bool bool2;

    //strings
    string noResult = "No Result";
    string calcNumbersNotText = "Calculate Numbers, NOT Text!";
    string validNumber = "Try a valid number";
    string enterNumber2 = "Enter Number 2...";
    string enterNumber1 = "Enter Number 1...";
    string calcNumbers = "Calculate Numbers!";

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
            result.text = noResult;
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
            result.text = noResult;
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
            result.text = noResult;
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
            result.text = noResult;
        }
        else
        {
            result.text = (number1Float / number2Float).ToString();
        }
    }

    IEnumerator turnRedField1()
    {
        message.text = calcNumbersNotText;
        result.text = noResult;
        number1.text = validNumber;
        number1.image.color = new Color32(255, 0, 0, 255);
        yield return new WaitForSeconds(2);
        number1.image.color = new Color32(255, 255, 255, 255);
        yield return new WaitForSeconds(5);
        number1.text = enterNumber1;
        message.text = calcNumbers;
    }

    IEnumerator turnRedField2()
    {
        message.text = calcNumbersNotText;
        result.text = noResult;
        number2.text = validNumber;
        number2.image.color = new Color32(255, 0, 0, 255);
        yield return new WaitForSeconds(2);
        number2.image.color = new Color32(255, 255, 255, 255);
        yield return new WaitForSeconds(5);
        number2.text = enterNumber2;
        message.text = calcNumbers;
    }
    
}
