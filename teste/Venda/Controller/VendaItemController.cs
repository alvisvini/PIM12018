using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MiniPack.Venda.Controller
{
    public class VendaItemController
    {
        public bool Insert(Model.VendaItem v)
        {
            try
            {
                Banco.Open();
                string cmdText = "INSERT INTO VENDAITEM(seqproduto,qtde,vlrproduto,vlrsubtotal,seqvenda) " +
                    "VALUES (?seq, ?qtde, ?vlr, ?total, ?seqVenda);";
                MySqlCommand cmd = new MySqlCommand(cmdText, Banco.connection);
                cmd.Parameters.AddWithValue("?seq", v.SeqProduto);
                cmd.Parameters.AddWithValue("?qtde", v.Qtde);
                cmd.Parameters.AddWithValue("?vlr", v.VlrProduto);
                cmd.Parameters.AddWithValue("?total", v.VlrSubtotal);
                cmd.Parameters.AddWithValue("?seqVenda", v.SeqVenda);
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
        public DataTable GetVendaItens(int seqVenda)
        {
            DataTable dt = new DataTable();
            try
            {
                string strSQL = "Select b.seq, b.cod as CODIGO, b.descricao, a.qtde, a.vlrproduto as VLRUNITARIO,a.vlrsubtotal as SUBTOTALITEM " +
                    "from pim1.vendaitem a, pim1.ge_produto b where b.seq = a.seqproduto and a.seqvenda = " + seqVenda;

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
