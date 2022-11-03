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
        StartCoroutine(MRMRLogo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MRMRLogo()
    {
        yield return new WaitForSeconds(3);
        transform.Find("MRMR Logo Background").GetComponent<Image>().enabled = false;
    }

    public void LoZWWButton()
    {
        SceneManager.LoadScene(1);
    }

    public void RECVXButton()
    {
        SceneManager.LoadScene(2);
    }

    public void LoZTPButton()
    {
        SceneManager.LoadScene(3);
    }

}
