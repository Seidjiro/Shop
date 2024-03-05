using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_1_4 : MonoBehaviour
{
    private int _threeDigitNumber = 543;
    private int _amoutHundred;
    private int _amoutDozen;
    private int _amoutUnit;

    void Start()
    {
       _amoutHundred = _threeDigitNumber / 100;
       _amoutDozen = _threeDigitNumber / 10;
       _amoutUnit = _threeDigitNumber / 1;
        print($"В числе {_threeDigitNumber}, количество сотен = {_amoutHundred}");
        print($"В числе {_threeDigitNumber}, количество десятков  = {_amoutDozen}");
        print($"В числе {_threeDigitNumber}, количество единиц = {_amoutUnit}");
    }
}
