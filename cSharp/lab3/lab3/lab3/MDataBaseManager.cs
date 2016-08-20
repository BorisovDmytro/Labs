using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace lab3
{
  public class MDataBaseManager
  {
    public NpgsqlConnection Connection { get; set; }

    public DataSet mDataSet { get; set; }
    private bool mIsOpen;

    protected NpgsqlDataAdapter adapterSeller;
    protected NpgsqlDataAdapter adapterProduct;

    public MDataBaseManager()
    {
      Connection = null;
      mIsOpen = false;
    }

    ~MDataBaseManager()
    {
      if(mIsOpen)
        Connection.Close();
    }

    public void cLoseConenction()
    {
      if(mIsOpen)
      {
        Connection.Clone();
        mIsOpen = false;
      }
    }

    public bool isOpen()
    {
      return mIsOpen;
    }

    public void conenct(ConnectSetting setting)
    {
      if (mIsOpen)
      {
        Connection.Close();
        mIsOpen = !mIsOpen;
      }

      NpgsqlConnectionStringBuilder strBuilder = new NpgsqlConnectionStringBuilder();
      strBuilder.Host = setting.mHost;
      strBuilder.Port = setting.mPort;
      strBuilder.UserName = setting.mUser;
      strBuilder.Password = setting.mPassword;
      strBuilder.Database = setting.mDataBaseName;
      strBuilder.Timeout = 30;

      Connection = new NpgsqlConnection(strBuilder.ConnectionString);
      Connection.Open();
      mIsOpen = true;
    }

    public DataSet initDataSet()
    {
      if(mDataSet == null)
      {
        mDataSet = new DataSet();
        mDataSet.Tables.Add("seller");
        mDataSet.Tables.Add("product");
      }
      return mDataSet;
    }

    public DataTable getSellerTable()
    {
      mDataSet.Tables["seller"].Clear();
      adapterSeller = new NpgsqlDataAdapter("SELECT * FROM seller", Connection);
      var builderCmd = new NpgsqlCommandBuilder(adapterSeller);
      adapterSeller.InsertCommand = builderCmd.GetInsertCommand();
      adapterSeller.Fill(mDataSet, "seller");
      return mDataSet.Tables["seller"];
    }

    public DataTable getPeoductSource(string sellerID)
    {
      mDataSet.Tables["product"].Clear();
      StringBuilder request = new StringBuilder("SELECT * FROM product WHERE id_seller = @id_seller;");
      request.Replace("@id_seller", sellerID);
      adapterProduct = new NpgsqlDataAdapter(request.ToString(), Connection);
      var builderCmd = new NpgsqlCommandBuilder(adapterProduct);
      adapterProduct.InsertCommand = builderCmd.GetInsertCommand();
      adapterProduct.Fill(mDataSet, "product");
      return mDataSet.Tables["product"];
    }

    public bool addSeller(string name, string secondName)
    {
      StringBuilder request = new StringBuilder("INSERT INTO seller VALUES (DEFAULT, '@name', '@second_name');");
      request.Replace("@name", name);
      request.Replace("@second_name", secondName);
      NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request.ToString(), Connection);
      int res = npgSqlCommand.ExecuteNonQuery();
      if (res == 1)
        return true;
      return false;
    }

    public bool updateSeller(int row, string name, string secondName)
    {
      string id = mDataSet.Tables["seller"].Rows[row]["id"].ToString();
      StringBuilder request = new StringBuilder("UPDATE seller set name='@name', second_name='@secondName' WHERE id=@id;");
      request.Replace("@name", name);
      request.Replace("@secondName", secondName);
      request.Replace("@id", id);
      NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request.ToString(), Connection);
      int res = npgSqlCommand.ExecuteNonQuery();
      if (res == 1)
        return true;
      return false;
    }

    public bool removeSeller(int row)
    {
      string id = mDataSet.Tables["seller"].Rows[row]["id"].ToString();
      StringBuilder request = new StringBuilder("DELETE FROM seller WHERE id = @id");
      request.Replace("@id", id);
      NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request.ToString(), Connection);
      int res = npgSqlCommand.ExecuteNonQuery();
      if (res == 1)
        return true;
      return false;
    }

    public bool addProduct(string idSeller, string name, string price)
    {
      StringBuilder request = new StringBuilder("INSERT INTO product VALUES (DEFAULT, '@name', @price, @idSeller);");
      request.Replace("@name", name);
      request.Replace("@price", price);
      request.Replace("@idSeller", idSeller);
      NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request.ToString(), Connection);
      int res = npgSqlCommand.ExecuteNonQuery();
      if (res == 1)
        return true;
      return false;
    }

    public bool updateProduct(string id, string idSeller, string name, string price)
    {
      StringBuilder request = new StringBuilder("UPDATE product set name='@name', price='@price', id_seller=@idSeller WHERE id=@id;");
      request.Replace("@name", name);
      request.Replace("@price", price);
      request.Replace("@idSeller", idSeller);
      request.Replace("@id", id);
      NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request.ToString(), Connection);
      int res = npgSqlCommand.ExecuteNonQuery();
      if (res == 1)
        return true;
      return false;
    }

    public bool removeProduct(string id)
    {
      StringBuilder request = new StringBuilder("DELETE FROM product WHERE id = @id");
      request.Replace("@id", id);
      NpgsqlCommand npqSqlCommand = new NpgsqlCommand(request.ToString(), Connection);
      int resualt = npqSqlCommand.ExecuteNonQuery();
      if (resualt == 1)
        return true;
      return false;
    }
  }
}
