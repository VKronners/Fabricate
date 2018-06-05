using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LiberacaoDeNovoProduto : ScriptableObject{

    /// <summary>
    /// Classe criada para realizar a liberação do produto em sua compra caso o Player possua o dinheiro.
    /// 
    /// Caso o jogador possua o valor necessario para comprar o novo produto que ele podera apartir de sua
    /// comprar realizar entregas e vendas deste mesmo produto.
    /// 
    /// </summary>

    [Header("Pode Comprar")]
    [Tooltip("Quando ligado o produto se torna liberado para comprar (Entregas) e para vender")]
    public bool comprado = false;

    public bool Comprado()
    {
        if (comprado)
        {
            comprado = false;
            return false;
        }

        else
        {
            comprado = true;
            return true;
        }
    }
}
