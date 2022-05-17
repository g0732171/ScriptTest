using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    int[] array = {40,20,33,88,77};


    for(int i=0; i<array.Length; i++)
    { Debug.Log(array[i]); }


    for (int i = array.Length-1; i >= 0; i--)
    { Debug.Log(array[i]); }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
