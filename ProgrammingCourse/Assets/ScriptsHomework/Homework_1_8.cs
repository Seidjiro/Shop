using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_1_8 : MonoBehaviour
{
    private int _Fibonacci = 100;
    private int _sumElementA = 0;
    private int _sumElementB = 1;
    private int _nextElement = 0;
    private int _number = 0;

    void Start()
    {
        while (_number <= _Fibonacci)
        {
            if (_number <= 1)
            {
                _nextElement = _number;
            }
            else
            {
                _nextElement = _sumElementA + _sumElementB;
                _sumElementA = _sumElementB;
                _sumElementB = _nextElement;
            }
            print($"Число Фибоначчи с индексом {_sumElementA} = {_sumElementB}, {_Fibonacci}, {_nextElement}");
            _number++;
        }
    }

    
}
