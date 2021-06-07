import { Produto } from "../../modelo/produto";

export class LojaCarrinhoCompras {
   
  public produtos: Produto[] = [];


  public adicionar(produto: Produto) {

    var produtoLocaStorage = localStorage.getItem("produtoLocaStorage");
    if (!produtoLocaStorage) {

      this.produtos.push(produto);
    } else {

      this.produtos = JSON.parse(produtoLocaStorage);
      this.produtos.push(produto);
    }

    localStorage.setItem("produtoLocaStorage", JSON.stringify(this.produtos));
  }

  public obterProduto(): Produto[] {

    var produtoLocaStorage = localStorage.getItem("produtoLocaStorage");
    if (produtoLocaStorage)
      return JSON.parse(produtoLocaStorage);
    return this.produtos;
  }

  public removerProduto(produto: Produto) {

    var produtoLocaStorage = localStorage.getItem("produtoLocaStorage");
    if (produtoLocaStorage) {
      this.produtos = JSON.parse(produtoLocaStorage);
      this.produtos = this.produtos.filter(p => p.id != produto.id);
      localStorage.setItem("produtoLocaStorage", JSON.stringify(this.produtos));
    }

  }
  public atualizar(produtos: Produto[]) {

    localStorage.setItem("produtoLocaStorage", JSON.stringify(produtos));
  }

  public temItensCarrinhoCompras(): boolean {
    var itens = this.obterProduto();
    return (itens.length > 0);

  }
  public limparCarrinhoCompras() {
    localStorage.setItem("produtoLocaStorage", "");
  }


}
