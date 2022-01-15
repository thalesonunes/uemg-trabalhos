class ContaPoupanca : ContaComum
    {
        public ContaPoupanca(string nc, string tit) : base(nc, tit) { }

 

        public void rendimento()
        {
            Console.WriteLine("Aqui vc tem rendimento");
        }
    }