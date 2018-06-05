using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niquel : MonoBehaviour {

    DinheiroPlayer dinheiroPlayer;
    AtualizeDinheiro atualizeDinheiro;
    Produtos produtos;

    public void CompraNiquel()
    {
        dinheiroPlayer = GameObject.Find("ManagerDeDinheiro").GetComponent<DinheiroPlayer>();
        atualizeDinheiro = GameObject.Find("ManagerDeDinheiro").GetComponent<AtualizeDinheiro>();
        produtos = GameObject.Find("GameManager").GetComponent<Produtos>();
        if (!produtos.produto[2].comprado)
        {
            if (dinheiroPlayer.dinheiroTotal >= produtos.produto[2].valorDeLiberacaoDeComercio)
            {
                atualizeDinheiro.Prejuizo(produtos.produto[2].valorDeLiberacaoDeComercio);
                produtos.produto[2].comprado = true;
            }
        }
    }

}