using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_1_5 : MonoBehaviour
{
    private float _number_1 = 5;
    private float _number_2 = 1.5f;
    private float _number_3 = 7.2f;


    void Start()
    {
        FindingTheMaximumNumber();
        FindingTheMinimumNumber();
    }

    private void FindingTheMaximumNumber()
    {
        if (_number_1 > _number_2 && _number_1 > _number_3)
        {
            print($"В числах {_number_1}, {_number_2}, {_number_3}, максимальное число = {_number_1}");
        }
        else if (_number_2 > _number_1 && _number_2 > _number_3)
        {
            print($"В числах {_number_1}, {_number_2}, {_number_3}, максимальное число = {_number_2}");
        }
        else if (_number_3 > _number_1 && _number_3 > _number_2)
        {
            print($"В числах {_number_1}, {_number_2}, {_number_3}, максимальное число = {_number_3}");
        }
    }
    private void FindingTheMinimumNumber()
    {
        if (_number_1 < _number_2 && _number_1 < _number_3)
        {
            print($"В числах {_number_1}, {_number_2}, {_number_3}, минимальное число = {_number_1}");
        }
        else if (_number_2 < _number_1 && _number_2 < _number_3)
        {
            print($"В числах {_number_1}, {_number_2}, {_number_3}, минимальное число = {_number_2}");
        }
        else if (_number_3 < _number_1 && _number_3 < _number_2)
        {
            print($"В числах {_number_1}, {_number_2}, {_number_3}, минимальное число = {_number_3}");
        }
    }
}
