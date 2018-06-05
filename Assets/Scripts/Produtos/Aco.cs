using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aco : MonoBehaviour {

    DinheiroPlayer dinheiroPlayer;
    AtualizeDinheiro atualizeDinheiro;
    Produtos produtos;

    public void CompraAco()
    {
        dinheiroPlayer = GameObject.Find("ManagerDeDinheiro").GetComponent<DinheiroPlayer>();
        atualizeDinheiro = GameObject.Find("ManagerDeDinheiro").GetComponent<AtualizeDinheiro>();
        produtos = GameObject.Find("GameManager").GetComponent<Produtos>();
        if (!produtos.produto[1].comprado)
        {
            if (dinheiroPlayer.dinheiroTotal >= produtos.produto[1].valorDeLiberacaoDeComercio)
            {
                atualizeDinheiro.Prejuizo(produtos.produto[1].valorDeLiberacaoDeComercio);
                produtos.produto[1].comprado = true;
            }
        }
    }

}
