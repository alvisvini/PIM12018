using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace MiniPack.Categoria.Controller
{
  public class Categoriacontroller
    {
      
        public bool Insert(Model.Categoria p)
        {
            try
            {
                Banco.Open();
                string cmdText = "INSERT INTO GE_CATEGORIA (descricao) VALUES (?descricao);";
                MySqlCommand cmd = new MySqlCommand(cmdText, Banco.connection);
                cmd.Parameters.AddWithValue("?descricao", p.Descricao);
                    
                cmd.ExecuteNonQuery();
                Banco.Close();
                MessageBox.Show("Categoria inserida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(Model.Categoria p)
        {
            try
            {
                string vsSql = "DELETE FROM GE_CATEGORIA WHERE SEQ = " + p.Seq;
                Banco.Open();
                MySqlCommand command = new MySqlCommand(vsSql, Banco.connection);
                command.ExecuteNonQuery();
                Banco.Close();
                MessageBox.Show("Categoria excluída com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Model.Categoria Pesquisar(int seq)
        {
            string strSQL = "Select seq,descricao From ge_categoria where seq = " + seq;
            Model.Categoria p = null;
            try
            {
                Banco.Open();
                MySqlCommand comando = new MySqlCommand(strSQL, Banco.connection);
                MySqlDataReader Reader = comando.ExecuteReader();

                if (Reader.HasRows)
                {
                    p = new Model.Categoria();
                    while (Reader.Read())
                    {
                        p.Seq = Reader.GetInt16("seq");
                        p.Descricao = Reader.GetString("descricao");
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

        public DataTable GetCategorias()
        {
            DataTable dt = new DataTable();
            try
            {
                string strSQL = "Select seq,descricao from ge_categoria";

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
