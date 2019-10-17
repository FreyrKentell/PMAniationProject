using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public float coffeeTemp = 170.0f;
    float hotTemp = 180.0f;
    float coldTemp = 110.0f;

    // Update is called once per frame
    void Update()
    {
        coffeeTemp -= Time.deltaTime * 5;
        //coffee = coffeTemp - Time.deltaTime * 5
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TempatureTest();
        }
    }
    void TempatureTest()
    {
        if(coffeeTemp > hotTemp)
        {
            Debug.Log("Ouch! I Burned My Tongue...");
        }
        else if(coffeeTemp < coldTemp)
        {
            Debug.Log("Ugh, COLD coffee is groooossss.");
        }
        else
        {
            //just right
            Debug.Log("Mmmmmmm Coffeee Coffeee Coffeeeeee");
        }
    }
}
