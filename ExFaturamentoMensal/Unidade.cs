namespace ExFaturamentoMensal {
    class Unidade {
        public string Local { get; set; }
        public double ValorArrecadado { get; set; }
        public Unidade() { }
        public Unidade(string local, double valorArrecadado) {
            Local = local;
            ValorArrecadado = valorArrecadado;
        }
    }
}
