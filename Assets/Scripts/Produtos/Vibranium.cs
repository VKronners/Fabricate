using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibranium : MonoBehaviour {

    DinheiroPlayer dinheiroPlayer;
    AtualizeDinheiro atualizeDinheiro;
    Produtos produtos;

    public void CompraVibranium()
    {
        dinheiroPlayer = GameObject.Find("ManagerDeDinheiro").GetComponent<DinheiroPlayer>();
        atualizeDinheiro = GameObject.Find("ManagerDeDinheiro").GetComponent<AtualizeDinheiro>();
        produtos = GameObject.Find("GameManager").GetComponent<Produtos>();
        if (!produtos.produto[4].comprado)
        {
            if (dinheiroPlayer.dinheiroTotal >= produtos.produto[4].valorDeLiberacaoDeComercio)
            {
                atualizeDinheiro.Prejuizo(produtos.produto[4].valorDeLiberacaoDeComercio);
                produtos.produto[4].comprado = true;
            }
        }
    }

}