﻿using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MiniPack.Produto.control
{
    public class ProdutoController
    {
        public bool Insert(model.Produto p)
        {
            try
            {
                Banco.Open();
                string cmdText = "INSERT INTO GE_PRODUTO(descricao,marca,obs,seqcategoria,preco) VALUES (?desc,?marca, ?obs, ?seqcateg, ?preco);";
                MySqlCommand cmd = new MySqlCommand(cmdText, Banco.connection);
                cmd.Parameters.AddWithValue("?desc", p.Desc);
                cmd.Parameters.AddWithValue("?marca", p.Marca);
                cmd.Parameters.AddWithValue("?obs", p.Obs);
                cmd.Parameters.AddWithValue("?seqcateg", p.Seqcategoria);
                cmd.Parameters.AddWithValue("?preco", p.Preco);
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

        public bool Update(model.Produto p)
        {
            try
            {
                Banco.Open();
                string cmdText = "update GE_PRODUTO set descricao = ?desc, marca = ?marca, obs = ?obs, seqcategoria = ?categ where seq = ?seq, preco = ?preco;";
                MySqlCommand cmd = new MySqlCommand(cmdText, Banco.connection);
                cmd.Parameters.AddWithValue("?desc", p.Desc);
                cmd.Parameters.AddWithValue("?marca", p.Marca);
                cmd.Parameters.AddWithValue("?obs", p.Obs);
                cmd.Parameters.AddWithValue("?categ", p.Seqcategoria);
                cmd.Parameters.AddWithValue("?seq", p.Seq);
                cmd.Parameters.AddWithValue("?preco", p.Preco);
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

        public bool Delete(model.Produto p)
        {
            try
            {
                string vsSql = "DELETE FROM GE_PRODUTO WHERE SEQ = " + p.Seq;
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

        public model.Produto Pesquisar(int seq)
        {
            string strSQL = "Select seq,descricao,marca,obs,seqcategoria From ge_produto where seq = " + seq;
            model.Produto p = null;
            try
            {
                Banco.Open();
                MySqlCommand comando = new MySqlCommand(strSQL, Banco.connection);
                MySqlDataReader Reader = comando.ExecuteReader();

                if (Reader.HasRows)
                {
                    p = new model.Produto();
                    while (Reader.Read())
                    {
                        p.Seq = Reader.GetInt16("seq");
                        p.Desc = Reader.GetString("descricao");
                        p.Marca = Reader.GetString("marca");
                        p.Obs = Reader.GetString("obs");
                        p.Preco = Reader.GetUInt16("preco");
                        p.Seqcategoria = Reader.GetInt16("seqcategoria");
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


        public DataTable GetProdutos(string where)
        {
            DataTable dt = new DataTable();
            try
            {
                string strSQL = "Select seq,descricao,marca,seqcategoria from ge_produto";
                if (where != "")
                    strSQL += " where descricao like'%" + where + "%'";
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
