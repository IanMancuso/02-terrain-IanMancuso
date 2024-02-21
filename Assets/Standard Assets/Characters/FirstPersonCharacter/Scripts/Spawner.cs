using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject capsule;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(capsule, new Vector3(230, 0, 516), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
