using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_3_2 : MonoBehaviour
{
    private Transform self;
    private Transform sphere;
    private Transform cylinder;
    void Start()
    {
        //Using PrintOutNameAndPosition print out the name and position of the Part_3_Cube (1pt)
        self = gameObject.GetComponent<Transform>();
        PrintOutNameAndPosition(self.name, self.position);

        //using GameObject.Find get the transform of Part_3_Sphere and use PrintOutNameAndPosition (1pt)
        sphere = GameObject.Find("Part_3_Sphere").GetComponent<Transform>();
        PrintOutNameAndPosition(sphere.name, sphere.position);
        //Using transform.Find or transform.Get get the Transform of Part_3_Cylinder which is a child of Part_3_Sphere
        //and use PrintOutNameAndPosition (1pt)
        cylinder = sphere.GetChild(0);
        PrintOutNameAndPosition(cylinder.name, cylinder.position);
    }
    
    //Prints out the name and the position of the variables
    private void PrintOutNameAndPosition(string name, Vector3 pos)
    {
        print(name + " " + pos);
    }

}
