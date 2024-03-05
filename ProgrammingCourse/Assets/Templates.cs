using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Templates : MonoBehaviour
{
    /* public List<int> numbers = new List<int>() { 3, 4, 8, 5, 1, 2, 1, 4 }; //коллекция целых чисел
     private void Start()
     {
         // методы коллекции List<>
         numbers.RemoveAt(0); // удалить где-то
         numbers.Add(7); // добавить элемент в конец коллекции
         numbers.AddRange(new int[] { 7, 4, 3}); // добавить диапазон элементов
         numbers.IndexOf(8); // возвращает индекс первого элемента с таким числом
         numbers.Insert(2, 28); // Insert(2 - индекс позиции, 28 - добавляемый элемент)

         foreach (var item in numbers)
         {
             print(item);
         }
     }
    */

    /* public Queue<int> numbers = new Queue<int>();

     //Enqueue - поставить в очередь, встать ы очередь (с конца очереди)
     //Dequeue - убрать из очереди, выйти из очереди (с переди очереди)
     //Peek - посмотреть (можно посмотреть первый элемент очереди)

     private void Start()
     {
         numbers.Enqueue(2);
         numbers.Enqueue(3);
         numbers.Enqueue(5);

         numbers.Dequeue();

         foreach (var item in numbers)
         {
             print(item);
         }
     }
    */

    /*
     * коллекция Stac
     * Добавлять элементы в Stac'e можно только сверху (т.е. только в начало)
     * И убирать элементы также можно только сверху (т.е. только первые)
     
      
    public Stack<int> numbers = new Stack<int>();

    private void Start()
    {
        numbers.Push(6); // вталкивать, т.е добавить
        numbers.Push(3);
        numbers.Push(1);

        print("Выкидываем " + numbers.Pop()); // извлечь первый обьект (те удаляется последний добавленный обьект)
        numbers.Push(5);

        print("Наверху лежит " + numbers.Peek());

        foreach (var item in numbers)
        {
            print(item);
        }
    }*/

    Dictionary<int, string> countries = new Dictionary<int, string>(); // Dictionary<int - индекс коллекции, string - элемент коллекции>

    private void Start()
    {
        countries.Add(1, "USA");
        countries.Add(2, "England");
        countries.Add(3, "Italy");

        foreach(KeyValuePair<int, string> keyValue in countries)
        {
            print(keyValue.Key + " - " + keyValue.Value);
        }

        string country = countries[2];
        print(country);


    }

    [SerializeField] private List<GameObject> cubes;
    [SerializeField] private Text inputText;

    public void DeleteCube()
    {
        Destroy(cubes[int.Parse(inputText.text)]);
        cubes.RemoveAt(int.Parse(inputText.text));
    }

    public void PrintCube()
    {
        print(cubes[int.Parse(inputText.text)]);
    }
}
