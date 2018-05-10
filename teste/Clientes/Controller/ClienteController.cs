using MySql.Data.MySqlClient;
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
                string cmdText = "INSERT INTO GE_CLIENTE(nomerazao) VALUES (?nome);";
                MySqlCommand cmd = new MySqlCommand(cmdText, Banco.connection);
                cmd.Parameters.AddWithValue("?nome", p.NomeRazao);
                cmd.ExecuteNonQuery();
                Banco.Close();
                return true;
            }
            catch (MySqlException e)
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
                        p.NomeRazao = Reader.GetString("nomerazao");
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


        public DataTable GetClientes(string where)
        {
            DataTable dt = new DataTable();
            try
            {
                string strSQL = "Select nomerazao from ge_cliente";
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
