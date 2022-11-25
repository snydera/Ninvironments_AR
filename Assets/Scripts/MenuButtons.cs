using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void LoZWWButton()
    {
        SceneManager.LoadScene(2);
    }

    public void RECVXButton()
    {
        SceneManager.LoadScene(3);
    }

    public void LoZTPButton()
    {
        SceneManager.LoadScene(4);
    }

    public void SA2BButton()
    {
        SceneManager.LoadScene(5);
    }

}
