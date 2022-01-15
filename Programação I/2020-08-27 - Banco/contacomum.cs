class ContaComum
    {
        public string nconta, titular;
        public float saldo;

 

        public ContaComum(String nc , string tit)
        {
            nconta = nc;
            titular = tit;
            saldo = 0;
        }
        public virtual void abertura(float valor)
        {
            saldo = valor;
        }

 

        public void deposito(float valor)
        {
            saldo += valor;
        }
        public virtual void saque(float valor)
        {
            if (saldo >= valor)
                saldo = saldo - valor;
            else
                Console.WriteLine("Saldo insuficiente");
        }

 

        public float verificaSaldo()
        {
            return saldo;
        }

 

    }