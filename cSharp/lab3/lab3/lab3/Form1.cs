using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
  public partial class Form1 : Form
  {
    protected MDataBaseManager mDataManager = new MDataBaseManager();
    protected SellerDialog dlgSeller;

    public Form1()
    {
      InitializeComponent();
    }

    private void connectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ConnectDataBaseDlg dlg = new ConnectDataBaseDlg();
      DialogResult res = dlg.ShowDialog();
      if(res == DialogResult.Yes)
      {
        mDataManager.conenct(dlg.getSetting());
        mDataManager.initDataSet();
        dataGridView1.DataSource = mDataManager.getSellerTable();
      }
    }

    private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      mDataManager.cLoseConenction();
    }

    private void OnCLickDataGrid1(object sender, EventArgs e)
    {
     if (dataGridView1.CurrentRow == null)
        return;
      string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
      dataGridView2.DataSource = mDataManager.getPeoductSource(id);
    }

    private void OnDataGridViewClick2(object sender, EventArgs e)
    {

    }

    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
      dlgSeller = new SellerDialog();
      dlgSeller.ShowDialog();
      if(dlgSeller.DialogResult == DialogResult.OK)
      {
        try {
          mDataManager.addSeller(dlgSeller.Name, dlgSeller.SecondName);
        } catch(System.Exception exp) {
          MessageBox.Show("Error added seller: \n" + exp.Message);
        }
      }
      dataGridView1.DataSource = mDataManager.getSellerTable();
      dlgSeller = null;
    }

    private void updateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int row = dataGridView1.CurrentRow.Index;
      if (row < 0)
        return;
      string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
      string secondName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
      dlgSeller = new SellerDialog();
      dlgSeller.setData(name, secondName);
      dlgSeller.ShowDialog();
      if(dlgSeller.DialogResult == DialogResult.OK)
      {
        try {
          mDataManager.updateSeller(row, dlgSeller.Name, dlgSeller.SecondName);
        } catch(System.Exception exp) {
          MessageBox.Show("Error update seller: \n" + exp.Message);
        }
      }
      dataGridView1.DataSource = mDataManager.getSellerTable();
      dlgSeller = null;
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int row = dataGridView1.CurrentRow.Index;
      if (row < 0)
        return;
      try {
        mDataManager.removeSeller(row);
       } catch (System.Exception exp) {
         MessageBox.Show("Error remove seller: \n" + exp.Message);
       }
      dataGridView1.DataSource = mDataManager.getSellerTable();
    }

    private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      int row = dataGridView1.CurrentRow.Index;
      if (row < 0)
        return;
      string idSeller = dataGridView1.CurrentRow.Cells[0].Value.ToString();
      string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
      ProductDialog dlg = new ProductDialog();
      if (DialogResult.Cancel == dlg.ShowDialog())
      {
        return;
      }
      mDataManager.updateProduct(id, idSeller, dlg.Name, dlg.Price);
      dataGridView2.DataSource = mDataManager.getPeoductSource(idSeller);
    }

    private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      int row = dataGridView2.CurrentRow.Index;
      if (row < 0)
        return;
      mDataManager.removeProduct(row.ToString());
    }

    private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int row = dataGridView1.CurrentRow.Index;
      if (row < 0)
        return;
      string idSeller = dataGridView1.CurrentRow.Cells[0].Value.ToString();
      ProductDialog dlg = new ProductDialog();
      if(DialogResult.Cancel == dlg.ShowDialog())
      {
        return;
      }
      mDataManager.addProduct(idSeller, dlg.Name, dlg.Price);
      dataGridView2.DataSource = mDataManager.getPeoductSource(idSeller);
    }
  }
}
