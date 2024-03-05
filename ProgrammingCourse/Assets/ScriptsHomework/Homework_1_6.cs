using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_1_6 : MonoBehaviour
{
    private int _month = 5;
  
    void Start()
    {
        AmountOfDays();
    }

    private void AmountOfDays()
    {
       switch (_month)
       {
            case 1:
                print($"В {_month} месяце, 31 дней");
                break;
            case 2:
                print($"В {_month} месяце, 28 дней");
                break;
            case 3:
                print($"В {_month} месяце, 31 дней");
                break;
            case 4:
                print($"В {_month} месяце, 30 дней");
                break;
            case 5:
                print($"В {_month} месяце, 31 дней");
                break;
            case 6:
                print($"В {_month} месяце, 30 дней");
                break;
            case 7:
                print($"В {_month} месяце, 31 дней");
                break;
            case 8:
                print($"В {_month} месяце, 31 дней");
                break;
            case 9:
                print($"В {_month} месяце, 30 дней");
                break;
            case 10:
                print($"В {_month} месяце, 31 дней");
                break;
            case 11:
                print($"В {_month} месяце, 30 дней");
                break;
            case 12:
                print($"В {_month} месяце, 31 дней");
                break;
       }
    }
}
