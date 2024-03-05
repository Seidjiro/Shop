using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_1_7 : MonoBehaviour
{
    private int _number = 5;
    private int _factorial = 1;

    void Start()
    {
        CalculateFactorial();
    }

    private void CalculateFactorial()
    {
        for (int i = 2; i <= _number; i++)
        {
            _factorial *= i;
        }
        print($"Факториал числа {_number} равен {_factorial}");
    }
}
