namespace MiniPack.Clientes.model
{
    public class Cliente
    {
        private int seq;
        private string nomeRazao;
        private string cpf;
        private string tipopessoa;
        private string id;
        private string senha;
        private string rg;
        private string telCelular;
        private string telFixo;
        private string telRecado;
        private string dtaNasc;
        private string sexo;
        private string estadoCivil;
        private string email;
        private string cep;
        private string logradouro;
        private int nro;
        private string bairro;
        private string complemento;
        private string cidade;
        private string uf;
        private string pais;

        public Cliente() { }

        public int Seq { get => seq; set => seq = value; }
        public string NomeRazao { get => nomeRazao; set => nomeRazao = value; }
        public string Tipopessoa { get => tipopessoa; set => tipopessoa = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Id { get => id; set => id = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Rg { get => rg; set => rg = value; }
        public string TelCelular { get => telCelular; set => telCelular = value; }
        public string TelFixo { get => telFixo; set => telFixo = value; }
        public string TelRecado { get => telRecado; set => telRecado = value; }
        public string DtaNasc { get => dtaNasc; set => dtaNasc = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Email { get => email; set => email = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public int Nro { get => nro; set => nro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Pais { get => pais; set => pais = value; }
    }
}


