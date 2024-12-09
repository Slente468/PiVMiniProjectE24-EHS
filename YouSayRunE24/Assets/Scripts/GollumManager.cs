using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GollumManager : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {


        

        
    }
    public void LoadEndScene()
        {
            SceneManager.LoadScene("End");
        }
private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                LoadEndScene(); // Call the public method
            }
        }
}
