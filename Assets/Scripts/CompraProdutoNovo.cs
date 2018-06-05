using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompraProdutoNovo : MonoBehaviour {

    public Produtos produtos;
    DinheiroPlayer dinheiroPlayer;


    void CompraProduto(int i)
    {
        dinheiroPlayer = GameObject.Find("GameManager").GetComponent<DinheiroPlayer>();

        if (dinheiroPlayer.dinheiroTotal >= produtos.produto[i].valorDeLiberacaoDeComercio)
        {
            produtos.produto[i].comprado = true;
        }
    }
}
