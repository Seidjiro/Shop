using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_1_3 : MonoBehaviour
{
    private string _surname = "Иван";
    private string _name = "Иванов";
    private int _age = 23;
    private string _placeOfResidence = "Москва";
    private bool _maritalStatus = true;


    void Start()
    {
        print($"ФИО: {_name} {_surname}");
        print($"Возраст: {_age}");
        print($"Место проживания: {_placeOfResidence}");
        print($"Замужем/Женят: {_maritalStatus}");
    }
}
