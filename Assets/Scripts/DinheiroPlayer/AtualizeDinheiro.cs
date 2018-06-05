using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtualizeDinheiro : MonoBehaviour {

    DinheiroPlayer dinheiroPlayer;
    ControleCanvasDinheiroPlayer canvasDinheiro;


    private void Awake()
    {
        dinheiroPlayer = GameObject.Find("ManagerDeDinheiro").GetComponent<DinheiroPlayer>();
        canvasDinheiro = GameObject.Find("ManagerDeDinheiro").GetComponent<ControleCanvasDinheiroPlayer>();
    }

    public void Lucro(float dinheiroASomar)
    {
        dinheiroPlayer.dinheiroTotal += dinheiroASomar;
        canvasDinheiro.AtualizaCanvas();
    }

    public void Prejuizo(float dinheiroASubtrair)
    {
        dinheiroPlayer.dinheiroTotal -= dinheiroASubtrair;
        canvasDinheiro.AtualizaCanvas();
    }
}
