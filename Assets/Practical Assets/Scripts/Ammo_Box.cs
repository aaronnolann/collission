using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_Box : MonoBehaviour
{
    int currentAmmo;
    RaycastHit result;


    void Start()
    {
        currentAmmo = 0;  
    }

    
    void Update()
    {
        if (Input.GetButtonDown("leftClick"))
            {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
            Physics.Raycast(ray, out result);
            if (result.collider.gameObject.name == "Target")
            {
                GameObject t = result.collider.gameObject;
                Animation a = t.transform.parent.GetComponent<Animation>();
                a.Play("LowerBridge");
            }
        }
   
    }

    void OnTriggerEnter(Collider other)
        {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "AmmoBox")
        {
            Debug.Log("Debug:");
            currentAmmo = 20;
            Debug.Log(currentAmmo);
            other.gameObject.SetActive(false);
        }
    }
        
}
