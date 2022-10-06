using System;


namespace Herança_e_Polimorfismo.Entidades
{
    internal class EmpregadoTercerizado : Empregado
    {
        public double CustoAdicional { get; set; }

        public EmpregadoTercerizado()
        {
        }

        public EmpregadoTercerizado(string nome, int horas,double valorPorHora, double custoAdicional) : base(nome,horas,valorPorHora) 
        {
            CustoAdicional = custoAdicional;
        }


        public override double Pagamento()
        {
            return  base.Pagamento() + 1.1  * CustoAdicional;

           
        }
    }
}
