import { Component, OnInit } from "@angular/core"
import { Produto } from "../modelo/produto";
import { ProdutoServico } from "../servicos/produto/produto.servico";
import { Router } from "@angular/router";

@Component({
  selector: "app-produto",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]

})
export class ProdutoComponent implements OnInit {

  public produto: Produto;
  public arquivosSelecionado: File;
  public ativar_spinner: boolean;
  public mensagem: string;


  constructor(private produtoServico: ProdutoServico, private router: Router) {

  }

  ngOnInit(): void {
    var produtoSession = sessionStorage.getItem('produtoSession');
    if (produtoSession) {
      this.produto = JSON.parse(produtoSession);
    } else {
      this.produto = new Produto();
    }

  }
  public inputChange(files: FileList) {

    this.arquivosSelecionado = files.item(0);
    this.ativaEspera();
    this.produtoServico.enviarArquivo(this.arquivosSelecionado)
      .subscribe(
        nomeArquivo => {
          this.produto.nomeArquivo = nomeArquivo;
          console.log(nomeArquivo);
          this.desativaEspera();
        },
        e => {
          console.log(e.error);
          this.desativaEspera();
        });
  }

  public cadastrar() {
    this.ativaEspera();
    this.produtoServico.cadastrar(this.produto)
      .subscribe(
        produto_json => {
          console.log(produto_json);
          this.desativaEspera();
          this.router.navigate(['/pesquisar-produto']);
        },
        e => {
          console.log(e.error);
          this.mensagem = e.error;
          this.desativaEspera();
        }
      );
  }

  public ativaEspera() {
    this.ativar_spinner = true;
  }
  public desativaEspera() {
    this.ativar_spinner = false;
  }
}
