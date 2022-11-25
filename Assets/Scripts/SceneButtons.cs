using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class SceneButtons : MonoBehaviour
{
    [SerializeField] ARSession arSession;
    [SerializeField] Camera arCamera;


    private void Awake()
    {
        arCamera = Camera.main;
        arSession = arCamera.transform.parent.Find("AR Session").GetComponent<ARSession>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetPosButton()
    {
        arCamera.transform.localPosition = new Vector3(0, 0, 0);
        arSession.Reset();
    }
}
