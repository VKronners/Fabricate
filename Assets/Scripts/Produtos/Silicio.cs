using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silicio : MonoBehaviour {

    DinheiroPlayer dinheiroPlayer;
    AtualizeDinheiro atualizeDinheiro;
    Produtos produtos;

    public void CompraSilicio()
    {
        dinheiroPlayer = GameObject.Find("ManagerDeDinheiro").GetComponent<DinheiroPlayer>();
        atualizeDinheiro = GameObject.Find("ManagerDeDinheiro").GetComponent<AtualizeDinheiro>();
        produtos = GameObject.Find("GameManager").GetComponent<Produtos>();
        if (!produtos.produto[3].comprado)
        {
            if (dinheiroPlayer.dinheiroTotal >= produtos.produto[3].valorDeLiberacaoDeComercio)
            {
                atualizeDinheiro.Prejuizo(produtos.produto[3].valorDeLiberacaoDeComercio);
                produtos.produto[3].comprado = true;
            }
        }
    }

}