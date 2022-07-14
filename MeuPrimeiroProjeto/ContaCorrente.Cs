public class ContaCorrente
{
    public string Titular;
    public int Agencia;
    public int Numero;
    public double Saldo;   //(Atributos) 


public ContaCorrente (string Titular, int Agencia, 
int Numero, double Saldo){ //(construtor)

   this.Titular = Titular;
   this.Agencia = Agencia;
   this.Numero = Numero;
   this.Saldo = Saldo;
}
   public bool Sacar (double valorSaque)
{
   if(this.Saldo >= valorSaque)
   {
      this.Saldo = this.Saldo - valorSaque;
      return true;
   }
      return false;
}



 public bool depositar (double valordeposito)
{
   if(this.Saldo > valordeposito)
   {
      this.Saldo = this.Saldo + valordeposito;
      return true;
   }
      return false;
}
}