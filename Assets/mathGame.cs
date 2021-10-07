using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathGame : MonoBehaviour
{
    public UnityEngine.UI.Text firstNumber, secondNumber, symbol, equal, answer, status;
    int number1, number2, symbolSign, math;
    int procAnswer;
    int randomNumberRange = 10;
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
            status.text = "BRAVO !";
        }
        else
        {
            status.color = Color.yellow;
            status.text = "Daha iyisini yapabilirsin";
        }
    }
    public void newQuestion()
    {
        answerInput.text = "";
        status.text = "";
        number1 = Random.Range(0, randomNumberRange);
        number2 = Random.Range(0, randomNumberRange);

        if (math == 0)
            symbolSign = Random.Range(1, 4);
        else
            symbolSign = math;


        switch (symbolSign)
        {
            case 1:
                symbol.text = "+";
                procAnswer = number1 + number2;
                break;
            case 2:
                symbol.text = "-";
                if (number1 > number2)
                {
                    procAnswer = number1 - number2;
                    break;
                }
                else
                {
                    procAnswer = number2 - number1;
                    break;
                }
            case 3:
                symbol.text = "X";
                procAnswer = number1 * number2;
                break;
        }
        if (number1 > number2)
        {
            firstNumber.text = number1 + "";
            secondNumber.text = number2 + "";
        }
        else
        {
            firstNumber.text = number2 + "";
            secondNumber.text = number1 + "";
        }
    }
    public void RandomNumber(int number)
    {
        switch (number)
        {
            case 0:
                randomNumberRange = 10;
                break;
            case 1:
                randomNumberRange = 50;
                break;
            case 2:
                randomNumberRange = 100;
                break;
        }
    }

    public void RandomMath(int number)
    {
        math = number;
    }
}