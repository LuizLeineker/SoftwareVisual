
namespace WEB.Models;


public class Produto{ 

    public Produto(){
        CriadoEm = DateTime.Now;
        Id = Guid.NewGuid().ToString();


    }



    //PUBLICO
    public string? Id {get; set;}
    public string? Nome {get; set;}
    public double Preco {get; set;}

    public int Quantidade {get; set;}

    public DateTime CriadoEm { get; set; }  
    







    /*
    PRIVATE

    private double preco;

    public double getPreco(){
        return preco;
    }

    public void setPreco(double preco){
        this.preco = preco * 2.5;
    }


*/
}

