namespace ExFaturamentoDiario {
    class Dados {
        public int Dia { get; set; }
        public double Valor { get; set; }
        public Dados() { }
        public Dados(int dia, double valor) {
            Dia = dia;
            Valor = valor;
        }
        override public string ToString() {
            return "" + Valor;
        }
    }
}
