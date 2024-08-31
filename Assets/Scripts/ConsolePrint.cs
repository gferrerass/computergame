using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{   
    // The counter is set to 3 at the start of the game
    private int counter = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // The frame counter gets updated
        counter++;
        // The gameObject's name and the frame counter get printed
        Debug.Log(gameObject.name+":"+counter);
    }
}
