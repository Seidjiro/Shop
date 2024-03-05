using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_1_2 : MonoBehaviour
{
    private int _amountCitizen = 991115;
    private float _squareCountry = 3083523;
    private float _densityPopulation;
        
    void Start()
    {
        _densityPopulation = _amountCitizen / _squareCountry;
        print($"Количество жителей в стране = {_amountCitizen}, её площадь = {_squareCountry}.");
        print($"Плотность населения в этой стране = {_densityPopulation}.");
    }
      
}
