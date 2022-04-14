using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int cost; //цена товара
    [SerializeField] private int col; //количество купленных ресурсов
    [SerializeField] private GameObject buttonToSell; //ссылка на кнопку продажи

    /// <summary>
    /// метод покупки товара
    /// </summary>
    public void buy()
    {
        if (GetComponentInParent<ShopManager>().money >= cost)
        {
            GetComponentInParent<ShopManager>().money -= cost;
            col += 1;
            buttonToSell.SetActive(true);
        }
    }

    /// <summary>
    /// метод продажи товара 
    /// </summary>
    public void ToSell()
    {
        GetComponentInParent<ShopManager>().money += (cost/2);
        GetComponentInParent<ShopManager>().removeItem();
        col -= 1;
        if (col <= 0)
        {
            buttonToSell.SetActive(false);
        }
    }

}
