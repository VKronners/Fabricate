using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirecionamentoSaida : MonoBehaviour{

    public enum Saida
    {
        Cima,
        Baixo,
        Direita,
        Esquerda
    };

    public Saida direcaoSaida;

    public void DespacheDoProduto()
    {
        if (direcaoSaida == Saida.Cima)
        {

        }
        else if (direcaoSaida == Saida.Baixo)
        {

        }
        else if (direcaoSaida == Saida.Direita)
        {

        }
        else
        {

        }
    }
}
