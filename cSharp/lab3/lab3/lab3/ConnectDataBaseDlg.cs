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
  public partial class ConnectDataBaseDlg : Form
  {
    protected ConnectSetting mSetting;

    public ConnectDataBaseDlg()
    {
      InitializeComponent();
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Yes;
      bool isOk = true;
      try
      {
        mSetting = new ConnectSetting();
        mSetting.mHost = boxHost.Text;
        mSetting.mPort = Int32.Parse(boxPort.Text);
        mSetting.mDataBaseName = boxName.Text;
        mSetting.mUser = boxUser.Text;
        mSetting.mPassword = boxPass.Text;
      } catch(System.Exception exp) {
        MessageBox.Show("Error input data base connect option: " + exp.Message);
        isOk = false;
      }
      if (isOk)
        Close();
    }

    private void btnCansel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }

    public ConnectSetting getSetting()  
    {
      return mSetting;
    } 
  }
}
