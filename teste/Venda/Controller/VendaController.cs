using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MiniPack.Venda.Controller
{
    public class VendaController
    {
        public bool Insert(Model.Venda v)
        {
            try
            {
                Banco.Open();
                string cmdText = "INSERT INTO VENDA(seqcliente,dtavenda,qtdeitens,vlrtotal) " + 
                    "VALUES (?seqcliente,?dta, ?qtde, ?total);";
                MySqlCommand cmd = new MySqlCommand(cmdText, Banco.connection);
                cmd.Parameters.AddWithValue("?seqcliente", v.SeqCliente);
                cmd.Parameters.AddWithValue("?dta", v.DtaVenda);
                cmd.Parameters.AddWithValue("?qtde", v.QtdeItens);
                cmd.Parameters.AddWithValue("?total", v.VlrTotal);
                cmd.ExecuteNonQuery();
                Banco.Close();
                MessageBox.Show("Venda inserida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return false;
            }
        }

        public int getMaxSeqVenda()
        {
            int seq = 0;
            string strSQL = "Select MAX(seqvenda) as seq from venda";
            try
            {
                Banco.Open();
                MySqlCommand comando = new MySqlCommand(strSQL, Banco.connection);
                MySqlDataReader Reader = comando.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        seq = Reader.GetInt16("seq");
                    }
                }
                Reader.Close();
                Banco.Close();
                return seq;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Banco.Close();
                return seq;
            }
        }

        public Venda.Model.Venda GetVenda(int seq)
        {
            string strSQL = "SELECT a.seqvenda, a.seqcliente, a.dtavenda , a.qtdeitens , a.vlrtotal FROM pim1.venda a where a.seqvenda = " + seq;
            Venda.Model.Venda p = null;
            try
            {
                Banco.Open();
                MySqlCommand comando = new MySqlCommand(strSQL, Banco.connection);
                MySqlDataReader Reader = comando.ExecuteReader();

                if (Reader.HasRows)
                {
                    p = new Venda.Model.Venda();
                    while (Reader.Read())
                    {
                        p.SeqVenda = Reader.GetInt16("seqvenda");
                        p.DtaVenda = Reader.GetDateTime("dtavenda");
                        p.QtdeItens = Reader.GetInt16("qtdeitens");
                        p.VlrTotal= Reader.GetDecimal("vlrtotal");
                       
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

        public DataTable GetVendas()
        {
            DataTable dt = new DataTable();
            try
            {
                string strSQL = "SELECT a.seqvenda, a.dtavenda, b.nomerazao, a.qtdeitens , a.vlrtotal FROM pim1.venda a, pim1.ge_cliente b where b.seq = a.seqcliente order by a.dtavenda desc";
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
