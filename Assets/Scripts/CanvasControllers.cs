using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControllers : MonoBehaviour {

    public GameObject canvasTablet;
    public GameObject canvasAppCompra;
    public GameObject apps;

    private void Start()
    {
        canvasTablet = GameObject.Find("CanvasTablet");
        canvasAppCompra = GameObject.Find("AppCompra");
        apps = GameObject.Find("Apps");
        canvasTablet.SetActive(false);
        canvasAppCompra.SetActive(false);
    }

    public void Sair()
    {
        apps.SetActive(true);
        canvasTablet.SetActive(false);
        canvasAppCompra.SetActive(false);

        Time.timeScale = 1;
    }

    public void LigaTablet()
    {
        canvasTablet.SetActive(true);
        Time.timeScale = 0;
    }

    public void AbreAppCompra()
    {
        canvasAppCompra.SetActive(true);
        apps.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            LigaTablet();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Sair();
        }
    }


}
