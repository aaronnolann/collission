using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_Box : MonoBehaviour
{
    public int currentAmmo;
    GameObject ammobox;
    RaycastHit result;
    Renderer test; 

    void Start()
    {
        currentAmmo = 0;  
    }

    
    void Update()
    {
        if (Input.GetButtonDown("leftClick") && currentAmmo>0)
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
            Physics.Raycast(ray, out result);
            currentAmmo--;
            if (result.collider.gameObject.name == "Target")
            {
                GameObject t = result.collider.gameObject;
                Animation a = t.transform.parent.GetComponent<Animation>();
                a.Play("LowerBridge");
            }
        }
        if (currentAmmo == 0)
        {
            ammobox = GameObject.Find("AmmoBox");
            //test = ammobox.GetComponent<MeshRenderer>();
            //test.enabled = true;
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
            test= other.gameObject.GetComponent<MeshRenderer>();
            test.enabled = false;
        } 
    }
        
}
