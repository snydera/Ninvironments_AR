using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AppLaunch : MonoBehaviour
{
    //[SerializeField] ScrollRect scrollRect;
    [SerializeField] GameObject continueButton;
    [SerializeField] GameObject MRMRLogoBackground;
    [SerializeField] GameObject appInfoBackground;

    //[SerializeField] bool hasScrolledToBottom = false;

    


    private void Awake()
    {
        //scrollRect = transform.Find("Logo Local Background").Find("Scroll Object").GetComponent<ScrollRect>();
        //scrollRect = transform.Find("Logo Local Background").Find("Scroll Object (original)").GetComponent<ScrollRect>();

        //continueButton = transform.Find("Logo Local Background").Find("Continue Button").gameObject;
        //continueButton = transform.Find("Logo Local Background").Find("Scroll Object").Find("Logo Panel").Find("Continue Button").gameObject;
        MRMRLogoBackground = transform.Find("MRMR Logo Background").gameObject;
        appInfoBackground = transform.Find("App Info Background").gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        //continueButton.SetActive(false);
        StartCoroutine(MRMRLogo());
    }

    // Update is called once per frame
    void Update()
    {
        //ScrollComplete();
    }

    IEnumerator MRMRLogo()
    {
        yield return new WaitForSeconds(3);
        MRMRLogoBackground.SetActive(false);
        StartCoroutine(AppInfo());
    }

    IEnumerator AppInfo()
    {
        yield return new WaitForSeconds(5);
        appInfoBackground.SetActive(false);
    }

    /*public void ScrollComplete()
    {
        if (scrollRect.verticalNormalizedPosition <= 0.1f)
        {
            hasScrolledToBottom = true;
        }
    }*/

    /*public float ScrollComplete
    {
        
    }*/

    /*public void EnableContinueButton()
    {
        if (hasScrolledToBottom == true)
        {
            continueButton.SetActive(true);
        }
    }*/

    public void LoadMainMenu()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(1);
    }
}
