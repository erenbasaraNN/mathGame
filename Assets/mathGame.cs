using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathGame : MonoBehaviour
{
    public UnityEngine.UI.Text firstNumber, secondNumber, symbol, equal, answer, status;
    int number1, number2, symbolSign;
    int procAnswer;
    public UnityEngine.UI.InputField answerInput;
    void Start()
    {
        newQuestion();

    }


    public void answerControl()
    {
        if (int.Parse(answer.text) == procAnswer)
        {

            status.color = new Color32(24, 173, 64, 255);
            status.text = "CORRECT";
        }
        else
        {
            status.color = Color.red;
            status.text = "FALSE";
        }
    }
    public void newQuestion()
    {


        answerInput.text = "";
        status.text = "";
        number1 = Random.Range(1, 10);
        number2 = Random.Range(1, 10);
        symbolSign = Random.Range(1, 4);
        switch (symbolSign)
        {
            case 1:
                symbol.text = "+";
                procAnswer = number1 + number2;
                break;
            case 2:
                symbol.text = "-";
                procAnswer = number1 - number2;
                break;
            case 3:
                symbol.text = "*";
                procAnswer = number1 * number2;
                break;
            case 4:
                symbol.text = "/";
                procAnswer = number1 / number2;
                break;
        }
        firstNumber.text = number1 + "";
        secondNumber.text = number2 + "";
    }
}