using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_slide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject parent = transform.parent.gameObject;
        Animation a = parent.GetComponent<Animation>();
        a.Play("OpenDoor");
    }
}
