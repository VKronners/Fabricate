using UnityEngine;

public class Produtos : MonoBehaviour{

    public Produto[] produto =  new Produto[6];

    private void Awake()
    {
        produto[0] = new Produto
        {
            nomeDoProduto = "Ferro",
            valorUnitario = 10f,
            valorDeLiberacaoDeComercio = 150,
            estadoDaVendaDoProduto = Produto.EstadoDeVenda.Solido
        };
        produto[1] = new Produto
        {
            nomeDoProduto = "Aço",
            valorUnitario = 12f,
            valorDeLiberacaoDeComercio = 200,
            estadoDaVendaDoProduto = Produto.EstadoDeVenda.Solido
        };
        produto[2] = new Produto
        {
            nomeDoProduto = "Niquel",
            valorUnitario = 25f,
            valorDeLiberacaoDeComercio = 500,
            estadoDaVendaDoProduto = Produto.EstadoDeVenda.Blocos
        };
        produto[3] = new Produto
        {
            nomeDoProduto = "Silicio",
            valorUnitario = 25f,
            valorDeLiberacaoDeComercio = 500,
            estadoDaVendaDoProduto = Produto.EstadoDeVenda.Triturado
        };
        produto[4] = new Produto
        {
            nomeDoProduto = "Adamantium",
            valorUnitario = 1000f,
            valorDeLiberacaoDeComercio = 15000,
            estadoDaVendaDoProduto = Produto.EstadoDeVenda.Liquido
        };
        produto[5] = new Produto
        {
            nomeDoProduto = "Vibranium",
            valorUnitario = 1000f,
            valorDeLiberacaoDeComercio = 15000,
            estadoDaVendaDoProduto = Produto.EstadoDeVenda.Blocos
        };
    }
}
