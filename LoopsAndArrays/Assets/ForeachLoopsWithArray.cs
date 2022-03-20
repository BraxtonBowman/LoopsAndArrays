using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        foreach (string i in cars)
        {
            Console.WriteLine($"One type of car is a {i}");
        }
        
    }
}
