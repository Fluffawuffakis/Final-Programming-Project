using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foods : MonoBehaviour
{
    public Rigidbody foodRb;
    void Start()
    {
        foodRb = GetComponent<Rigidbody>();
    }
    public void Awake()
    {
        LaunchFood();
    }

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
       
    }

    public virtual void LaunchFood()
    {
        foodRb.AddForce(Vector3.up * 4, ForceMode.Impulse); //food specific force);
        StartCoroutine(DestroyFood());
    }

    public IEnumerator DestroyFood()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
