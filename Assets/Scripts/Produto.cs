using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Produto {

    public enum EstadoDeVenda
    {
        Solido,
        Liquido,
        Trancado,
        Blocos,
        Processado,
        Triturado,
        Prensado
    }

    public string nomeDoProduto;
    public float valorUnitario;
    public int valorDeLiberacaoDeComercio;
    public bool comprado;

    public EstadoDeVenda estadoDaVendaDoProduto;

    public Produto()
        {
            comprado = false;
        }
}
