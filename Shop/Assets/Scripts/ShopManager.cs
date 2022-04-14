using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private Text moneyText; //ссылка на текстовый обьект
    [SerializeField] private GameObject[] button; //массив, кнопок редких ресурсов
    [HideInInspector] public int money = 100; //количество денег

    private void Update()
    {
        moneyText.text = money.ToString();
        activeButton();
    }

    /// <summary>
    /// метод отображения (добавление денег)
    /// </summary>
    public void addItem()
    {
        moneyText.text = money.ToString();
    }

    /// <summary>
    /// метод отображения (сокращение денег) 
    /// </summary>
    public void removeItem()
    {
        moneyText.text = money.ToString();
    }

    /// <summary>
    /// метод добавление денег на 5, при нажатии кнопки "Нажми"
    /// </summary>
    public void buttonClick()
    {
        money += 5;
    }

    /// <summary>
    /// метод активации редких ресурсов
    /// </summary>
    public void activeButton()
    {
       if (money > 200)
       {
            foreach (var item in button)
            {
                item.GetComponent<Button>().interactable = true;
            }
       }
    }
}
