using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.gameObject.tag=="Ground")
        {
            SceneManager.LoadScene("Level2");
        }
        if (collision.gameObject.tag == "Ground1")
        {
            SceneManager.LoadScene("Level3");
        }
        if (collision.gameObject.tag == "Ground2")
        {
            SceneManager.LoadScene("Level4");
        }
        if (collision.gameObject.tag == "Ground3")
        {
            SceneManager.LoadScene("Level5");
        }
        if (collision.gameObject.tag == "Ground4")
        {
            SceneManager.LoadScene("Level6");
        }
        if (collision.gameObject.tag == "Ground5")
        {
            SceneManager.LoadScene("GameWin");
        }
    }
}
