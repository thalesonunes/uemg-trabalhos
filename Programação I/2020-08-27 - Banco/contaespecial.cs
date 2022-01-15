class ContaEspecial : ContaComum
    {
        float limite;

 

        public ContaEspecial(String nc, string tit, float limite) : base(nc, tit)
        {
            this.limite = limite;
        }
        public override void abertura(float valor)
        {
            saldo = valor + limite;
        }

 

        public override void saque(float valor)
        {
            if (saldo >= valor)
            {
                if (valor > (saldo - limite))
                    Console.WriteLine("Você está usando seu limite");
                else
                    Console.WriteLine("Saque ok");
                saldo -= valor;
            }
            else
                Console.WriteLine("Saldo insuficiente");
        }

 

    }