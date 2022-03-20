using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int number = 0;
        while(number<5;){
            Console.WriteLine($"The number is now {number}");
            number++;
        }

        int number2 = 0;
        do{
            Console.WriteLine($"The second number is now {number2}");
            number2++;
        }while (i<5);
        
    }
}
