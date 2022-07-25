using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_3_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        print (Area(10, 3));       //Result should be 30
        print (Area());            //Result should be 1
        print (Area(2.5f, 3.7f));  //Result should be 9.25f
    }

    int Area (int length  = 1, int width = 1)
    {
        return (length * width);
    }

    float Area (float length, float width)
    {
        return (length * width);
    }

    //Create a function called Area where you pass in two integer values and
    //return the Area value (1pt)

    //Add default values to the Area such that width = 1 and length = 1 (1pt)

    //Overload the function by creating another Area function but this one takes in
    //float values and returns a float  (1pt) 
}
