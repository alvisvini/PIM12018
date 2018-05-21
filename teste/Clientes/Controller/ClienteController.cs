using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MiniPack.Clientes.control
{
    public class ClienteController
    {
        public bool Insert(model.Cliente p)
        {
            try
            {
                Banco.Open();
                string cmdText = "INSERT INTO GE_CLIENTE(nomerazao,tipopessoa,cpf,id,senha,rg,telcelular,telfixo,telrecado,dtanasc,sexo,estadocivil,email,cep,logradouro,nro,bairro,complemento,cidade,uf,pais) "+
                    "VALUES (?nome,?tipopessoa,?cpf,?id,?senha,?rg,?telcelular,?telfixo,?telrecado,?dtanasc,?sexo,?estadocivil,?email,?cep,?logradouro,?nro,?bairro,?complemento,?cidade,?uf,?pais);";
                MySqlCommand cmd = new MySqlCommand(cmdText, Banco.connection);
                cmd.Parameters.AddWithValue("?nome", p.NomeRazao);
                cmd.Parameters.AddWithValue("?tipopessoa", p.Tipopessoa);
                cmd.Parameters.AddWithValue("?cpf", p.Cpf);
                cmd.Parameters.AddWithValue("?id", p.Id);
                cmd.Parameters.AddWithValue("?senha", p.Senha);
                cmd.Parameters.AddWithValue("?rg", p.Rg);
                cmd.Parameters.AddWithValue("?telcelular", p.TelCelular);
                cmd.Parameters.AddWithValue("?telfixo", p.TelFixo);
                cmd.Parameters.AddWithValue("?telrecado", p.TelRecado);
                cmd.Parameters.AddWithValue("?dtanasc", p.DtaNasc);
                cmd.Parameters.AddWithValue("?sexo", p.Sexo);
                cmd.Parameters.AddWithValue("?estadocivil", p.EstadoCivil);
                cmd.Parameters.AddWithValue("?email", p.Email);
                cmd.Parameters.AddWithValue("?cep", p.Cep);
                cmd.Parameters.AddWithValue("?logradouro", p.Logradouro);
                cmd.Parameters.AddWithValue("?nro", p.Nro);
                cmd.Parameters.AddWithValue("?bairro", p.Bairro);
                cmd.Parameters.AddWithValue("?complemento", p.Complemento);
                cmd.Parameters.AddWithValue("?cidade", p.Cidade);
                cmd.Parameters.AddWithValue("?uf", p.Uf);
                cmd.Parameters.AddWithValue("?pais", p.Pais);
                cmd.ExecuteNonQuery();
                Banco.Close();
                return true;
            }
            catch (Exception z)
            {
                //MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return false;
            }
        }

        public bool Delete(model.Cliente p)
        {
            try
            {
                string vsSql = "DELETE FROM ge_cliente WHERE SEQ = " + p.Seq;
                Banco.Open();
                MySqlCommand command = new MySqlCommand(vsSql, Banco.connection);
                command.ExecuteNonQuery();
                Banco.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public model.Cliente Pesquisar(int seq)
        {
            string strSQL = "Select * From ge_cliente where seq = " + seq;
            model.Cliente p = null;
            try
            {
                Banco.Open();
                MySqlCommand comando = new MySqlCommand(strSQL, Banco.connection);
                MySqlDataReader Reader = comando.ExecuteReader();

                if (Reader.HasRows)
                {
                    p = new model.Cliente();
                    while (Reader.Read())
                    {
                        p.Seq = Reader.GetInt16("seq");
                        p.NomeRazao = Reader.GetString("nomerazao");
                        p.Tipopessoa = Reader.GetString("tipopessoa");
                        p.Cpf = Reader.GetString("cpf");
                        p.Id = Reader.GetString("id");
                        p.Senha = Reader.GetString("senha");
                        p.Rg = Reader.GetString("rg");
                        p.TelCelular = Reader.GetString("telcelular");
                        p.TelFixo = Reader.GetString("telfixo");
                        p.TelRecado = Reader.GetString("telrecado");
                        p.DtaNasc = Reader.GetString("dtanasc");
                        p.Sexo = Reader.GetString("sexo");
                        p.EstadoCivil = Reader.GetString("estadocivil");
                        p.Email = Reader.GetString("email");
                        p.Cep = Reader.GetString("cep");
                        p.Logradouro = Reader.GetString("logradouro");
                        p.Nro = Reader.GetInt16("nro");
                        p.Bairro = Reader.GetString("bairro");
                        p.Complemento = Reader.GetString("complemento");
                        p.Cidade = Reader.GetString("cidade");
                        p.Uf = Reader.GetString("uf");
                        p.Pais = Reader.GetString("pais");
                    }
                }
                Reader.Close();
                Banco.Close();
                return p;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Banco.Close();
                return p;
            }
        }

        public bool Update(model.Cliente p)
        {
            try
            {
                Banco.Open();
                string cmdText = "update GE_CLIENTE set nomerazao = ?nome, cpf = ?cpf, tipoPessoa = ?tipo, id = ?id, senha = ?senha, rg = ?rg," +
                    "telcelular = ?telcelular, telfixo = ?telfixo, telrecado = ?telrecado, dtanasc = ?dtanasc, sexo = ?sexo, estadocivil = ?estadocivil," +
                    "email = ?email, cep = ?cep, logradouro = ?logradouro, nro = ?nro, bairro = ?bairro, complemento = ?complemento, cidade = ?cidade," +
                    "uf = ?uf, pais = ?pais where seq = ?seq;";
                MySqlCommand cmd = new MySqlCommand(cmdText, Banco.connection);
                cmd.Parameters.AddWithValue("?nome", p.NomeRazao);
                cmd.Parameters.AddWithValue("?cpf", p.Cpf);
                cmd.Parameters.AddWithValue("?tipo", p.Tipopessoa);
                cmd.Parameters.AddWithValue("?id", p.Id);
                cmd.Parameters.AddWithValue("?senha", p.Senha);
                cmd.Parameters.AddWithValue("?seq", p.Seq);
                cmd.Parameters.AddWithValue("?rg", p.Rg);
                cmd.Parameters.AddWithValue("?telcelular", p.TelCelular);
                cmd.Parameters.AddWithValue("?telfixo", p.TelFixo);
                cmd.Parameters.AddWithValue("?telrecado", p.TelRecado);
                cmd.Parameters.AddWithValue("?dtanasc", p.DtaNasc);
                cmd.Parameters.AddWithValue("?sexo", p.Sexo);
                cmd.Parameters.AddWithValue("?estadocivil", p.EstadoCivil);
                cmd.Parameters.AddWithValue("?email", p.Email);
                cmd.Parameters.AddWithValue("?cep", p.Cep);
                cmd.Parameters.AddWithValue("?logradouro", p.Logradouro);
                cmd.Parameters.AddWithValue("?nro", p.Nro);
                cmd.Parameters.AddWithValue("?bairro", p.Bairro);
                cmd.Parameters.AddWithValue("?complemento", p.Complemento);
                cmd.Parameters.AddWithValue("?cidade", p.Cidade);
                cmd.Parameters.AddWithValue("?uf", p.Uf);
                cmd.Parameters.AddWithValue("?pais", p.Pais);
                cmd.ExecuteNonQuery();
                Banco.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public string getSenha(string usuario)
        {
            string senha = "";
            string strSQL = "Select * From ge_cliente where id = '" + usuario + "' and tipopessoa = 'Funcionário'";
            try
            {
                Banco.Open();
                MySqlCommand comando = new MySqlCommand(strSQL, Banco.connection);
                MySqlDataReader Reader = comando.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        senha = Reader.GetString("senha");
                    }
                }
                Reader.Close();
                Banco.Close();
                return senha;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Banco.Close();
                return senha;
            }
        }

        public DataTable GetClientes(string where)
        {
            DataTable dt = new DataTable();
            try
            {
                string strSQL = "SELECT a.seq, a.nomerazao, a.cpf, a.telCelular, a.telFixo, a.email, a.tipopessoa FROM pim1.ge_cliente a";
                if (where != "")
                    strSQL += " where nomerazao like'%" + where + "%'";
                Banco.Open();
                MySqlCommand comando = new MySqlCommand(strSQL, Banco.connection);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(dt);
                Banco.Close();
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
        }
    }
}
