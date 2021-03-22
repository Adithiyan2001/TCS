using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Material Hitmaterial;
    [SerializeField] int Bullet;
    public Text BulletText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BulletText.text = Bullet.ToString("0");
        if (Bullet >0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitinfo;

                if (Physics.Raycast(ray, out hitinfo))
                {
                    
                    var rig = hitinfo.collider.GetComponent<Rigidbody>();
                    if (rig != null)
                    {
                        
                        rig.GetComponent<MeshRenderer>().material = Hitmaterial;
                        rig.AddForceAtPosition(ray.direction * 50f, hitinfo.point, ForceMode.VelocityChange);
                        Bullet--;
                    }
                }
            }
        }
       if(Bullet <=0)
        {
            int ActiveScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(ActiveScene);
        }
       if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
