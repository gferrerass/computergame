using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{   
    // The counter is set to 3 at the start of the game
    private int counter = 3;
    public Renderer rend;
    private int randomIntger;
    // Start is called before the first frame update
    void Start()
    {
        // The randomInteger gets generated when the game starts
        randomIntger = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {   
        // The frame counter gets updated
        counter++;
        // The gameObject's name and the frame counter get printed
        Debug.Log(gameObject.name+":"+counter);
        
        // If the tag is Red and the counter is 100
        if (gameObject.tag == "Red" && counter == 100)
        {
            // The GameObject gets deactivated
            gameObject.SetActive(false);
        }
        // If the tag is Blue and the counter is equal to the random integer
        else if (gameObject.tag == "Blue" && counter == randomIntger)
        {
            // The Renderer component gets disabled
            rend.enabled = false;
        }
    }
}
