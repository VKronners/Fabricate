using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstaLigado : MonoBehaviour
{
    /// <summary>
    /// Classe criada para todas as ferramentas que precisam serem ligadas ou desligadas no jogo.
    /// 
    /// De exemplo se tem as peças de recebimento ao comprar um determinado material caso o recebimento esteja ligado
    /// mas não conectado as peças serão jogadas no chão.
    /// </summary>

    [Header("Ligar a Ferramenta")]
    [Tooltip("Ira ativar a ferramenta aonde este script estiver afixado")]
    public bool estaLigado = false;

    public bool Switch()
    {
        if (estaLigado)
        {
            estaLigado = false;
            return false;
        }

        else
        {
            estaLigado = true;
            return true;
        }
    }
}

