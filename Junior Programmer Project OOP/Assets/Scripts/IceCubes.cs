using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCubes : Foods
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void LaunchFood()
    {
        foodRb.AddForce(new Vector3(Random.Range(0,3), Random.Range(0, 3), -Random.Range(0, 3)), ForceMode.Impulse); //food specific force);
        StartCoroutine(DestroyFood());
    }

}
