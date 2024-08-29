using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        // create a redObj at (2,0,0) and a rotation of zero
        Instantiate(redObj,new Vector3(2, 0, 0), Quaternion.identity);
        // create a blueObj at (-2,0,0) and a rotation of zero
        Instantiate(blueObj,new Vector3(-2, 0, 0), Quaternion.identity);

        // Limit framerate to cinematic 60 fps.
        QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
        Application.targetFrameRate = 60;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
