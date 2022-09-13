// See https://aka.ms/new-console-template for more information
using System;

namespace heranca{
    class Program{
        public static void Main(string[] args) {
            Console.WriteLine("Teste");
            Carrinho c = new Carrinho();
            Produto p = new Produto("Holybibble", 50);
            c.adicionarProduto(p);
            c.adicionarProduto(new Produto("Escova De Dente", 10));
            c.adicionarProduto(new Produto("PS5", 4500));
            c.adicionarProduto(new Produto("Rubber Duck", 20));
            c.adicionarProduto(new Produto("Jogo", 50));
            //c.mostarProdutos();
            List<Produto> pdts = c.getProdutos();
            foreach(Produto prod in pdts){
                Console.WriteLine(prod.getNome()); 
                Console.WriteLine(prod.getPreco());
            }
            
            c.mostrarPreco();
            Console.WriteLine("A Soma Dos Produtos É: {0} " , c.total);
            //List<int> numeros = new List<int>();
            //int[] numeros2 = new int[10];
        }
    }

public class Carrinho{
    //private Produto p;
    public float total;
    private List<Produto> produtos = new List<Produto>();

    public void adicionarProduto(Produto p){
        this.produtos.Add(p);
    }

    public void mostarProdutos(){
        for(int i=0; i < this.produtos.Count; i++){
            Console.WriteLine(produtos[i].getNome());
            Console.WriteLine(produtos[i].getPreco());
        }
        /* foreach(Produto p in this.produtos){
            Console.WriteLine(p.getNome());
        }*/
    }

    public void mostrarPreco(){
        for(int i = 0; i < this.produtos.Count; i++){
            total = total + (produtos[i].getPreco());
        }
    }

    public List<Produto> getProdutos(){
        return this.produtos;
    }
}

public class Produto{
    private string nome;
    private float preco;

    public Produto(string nome, float preco){
        this.nome = nome;
        this.preco = preco;
    }

    public string getNome(){
        return this.nome;
    }

    public float getPreco(){
        return this.preco;
    }
}
}