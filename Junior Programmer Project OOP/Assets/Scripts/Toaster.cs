using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toaster : MonoBehaviour
{
    public GameObject toast;
    public GameObject toaster;
    public Rigidbody toasterRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(toast, new Vector3(gameObject.transform.position.x, 1.25f, gameObject.transform.position.z), toast.transform.rotation);
        }
    }
}
