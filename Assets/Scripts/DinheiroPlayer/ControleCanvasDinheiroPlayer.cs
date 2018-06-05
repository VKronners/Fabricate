using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class ControleCanvasDinheiroPlayer : MonoBehaviour {

    public Text txt_Dinheiro;

    public DinheiroPlayer dinheiroPlayer;

    public List<Button> btnCompra;
    public GameObject[] Aux = new GameObject[10];

	void Start () {
        AtualizaCanvas();

        Aux = GameObject.FindGameObjectsWithTag("btnProduto");

        for (int i = 0; i < Aux.Length; i++)
        {
            btnCompra.Add(Aux[i].GetComponent<Button>());
        }
    }

    public void AtualizaCanvas()
    {



        dinheiroPlayer = GameObject.Find("ManagerDeDinheiro").GetComponent<DinheiroPlayer>();

        txt_Dinheiro = GameObject.Find("txt_DinheiroTablet").GetComponent<Text>();
        //Debug.Log(textoDinheiro);
        txt_Dinheiro.text = string.Format("{0}", dinheiroPlayer.dinheiroTotal.ToString());
    }
}
