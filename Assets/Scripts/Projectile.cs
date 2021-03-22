using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Material Hitmaterial;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;
            if(Physics.Raycast(ray,out hitinfo ))
            {
                var rig = hitinfo.collider.GetComponent<Rigidbody>();
                if(rig!=null)
                {
                    rig.GetComponent<MeshRenderer>().material = Hitmaterial;
                    rig.AddForceAtPosition(ray.direction * 50f, hitinfo.point, ForceMode.VelocityChange);
                }
            }
        }
    }
}
