using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : Toaster
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void CreateFood()
    {
        Instantiate(food, new Vector3(gameObject.transform.position.x - 1.5f, 4.78f, gameObject.transform.position.z - 2), food.transform.rotation);
    }
}
