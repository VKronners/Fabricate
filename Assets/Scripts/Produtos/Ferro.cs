using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferro : MonoBehaviour {

    DinheiroPlayer dinheiroPlayer;
    AtualizeDinheiro atualizeDinheiro;
    Produtos produtos;

    public void CompraFerro()
    {
        dinheiroPlayer = GameObject.Find("ManagerDeDinheiro").GetComponent<DinheiroPlayer>();
        atualizeDinheiro = GameObject.Find("ManagerDeDinheiro").GetComponent<AtualizeDinheiro>();
        produtos = GameObject.Find("GameManager").GetComponent<Produtos>();
        if (!produtos.produto[0].comprado)
        {
            if (dinheiroPlayer.dinheiroTotal >= produtos.produto[0].valorDeLiberacaoDeComercio)
            {
                atualizeDinheiro.Prejuizo(produtos.produto[0].valorDeLiberacaoDeComercio);
                produtos.produto[0].comprado = true;
            }
        }
    }

}
