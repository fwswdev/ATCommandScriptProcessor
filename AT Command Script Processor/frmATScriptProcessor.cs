/* ===================================================== 
Name:       AT Script Processor
Purpose:    This program was created to automate sending
            of batches of serial strings to a device.
            This was tested on GSM modems as well as 
            Dangerous Prototype's Bus Pirate 
Platform:
            Microsoft Visual C# 2010 Express Edition
            .NET Framework 2.0
 
Author:      fwswdev @ github
Copyright:   
Licence:     fwswdev @ github
Revision History:
  00.08.00(7)
      - New Release
  00.08.01(7)
      - Added Handshaking
  00.08.02(7)
      - Added Option to adjust RX Buffer Size
      - TX Buffer Size set to 1000
      - Special Command for sending hex number: __@HEX   Usage: __@HEX=AA|TRUE|100|None  
  00.08.03(7) 
      - Complete the baud rate list
  00.08.04(7)
      - Minor Enhancements
===================================================== */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace AT_Command_Script_Processor
{
    public partial class frmATScriptProcessor : Form
    {
        const string FRM_TITLE="Serial/AT Command Script Processor 00.08.04";

        public frmATScriptProcessor()
        {
        InitializeComponent();
        }

        private void frmATScriptProcessor_Load(object sender, EventArgs e)
        {
        this.Text=FRM_TITLE;
        tssStatusScrFile.Text="";
        cmbSerial.Items.Clear();
        cmbSerial.Items.AddRange(SerialPort.GetPortNames());
        if(cmbSerial.Items.Count!=0)
            cmbSerial.SelectedIndex=0;
        else
            {
            MessageBox.Show("No Serial Port Found\r\nPlease Insert USB to Serial Device To Continue.","No COM Port",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            Application.Exit();
            }

        cmbBaud.Items.Clear();
        cmbBaud.Items.AddRange(new string[]{"110","300","1200","2400","4800","9600","19200","38400","57600","115200"});
        cmbBaud.SelectedIndex=0;

        cmbHandShaking.Items.Clear();
        cmbHandShaking.Items.AddRange(new string[]{"None","RequestToSend","RequestToSendXOnXOff","XOnXOff"});
        cmbHandShaking.SelectedIndex=0;
        }



        private void btnOpenFile_Click(object sender, EventArgs e)
        {
        if(ofdScriptFile.ShowDialog()==DialogResult.OK)
            {
            tssStatusScrFile.Text=ofdScriptFile.FileName;
            }
        }



        private void btnRun_Click(object sender, EventArgs e)
        {
        string SCRFile=tssStatusScrFile.Text.Trim();
        txtResult.Clear();
        Application.DoEvents();
        if(File.Exists(SCRFile)==true)
            {
            SerialPort mySer=new SerialPort(cmbSerial.SelectedItem.ToString(),int.Parse(cmbBaud.SelectedItem.ToString()));
            mySer.WriteBufferSize=1000;
            mySer.ReadBufferSize=(int)numRXBuffSize.Value;
            mySer.Handshake=(Handshake)Enum.Parse( typeof(Handshake),cmbHandShaking.SelectedItem.ToString());
            mySer.WriteTimeout=1000;
            try
                {
                string [] FileAllLines=File.ReadAllLines(SCRFile);
                
                try
                    {mySer.Open();}
                catch
                    {
                    MessageBox.Show("Error Opening Serial Port!");
                    return;
                    }
                btnRun.Enabled=false;
                foreach(string x in FileAllLines)
                    {
                    string temp=x.Trim();
                    if(temp.StartsWith(@"//"))
                        continue;
                    
                    string [] spliString=temp.Split(new char[]{'|'},StringSplitOptions.RemoveEmptyEntries);
                    if(spliString.Length!=4)
                        continue;

                    int delay=0;    
                    bool boolReadRx=false;
                    string ATcmd="";

                    try
                        {
                        delay=int.Parse(spliString[2].Trim());    
                        boolReadRx=Convert.ToBoolean(spliString[1].Trim());
                        ATcmd=spliString[0].Trim();
                        }
                    catch
                        {
                        MessageBox.Show("Error Parsing Data, Please Recheck AT Script File: " + temp,FRM_TITLE,MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        return;
                        }

                    mySer.DiscardInBuffer();

                    if(ATcmd.StartsWith("__@HEX")) // if special command
                        {
                        txtResult.AppendText("Sending Command: " + ATcmd);
                        txtResult.AppendText("\r\n");
                        try
                            {
                            string []splitstr=ATcmd.Split(new char[]{'='},StringSplitOptions.RemoveEmptyEntries);
                            byte ByToSend=Convert.ToByte(splitstr[1],16);
                            temp=String.Format("Special Command: Sending Hex Data 0x{0:X2}\r\n", ByToSend);
                            txtResult.AppendText(temp);
                            mySer.Write(new byte[]{ByToSend},0,1);
                            }
                        catch
                            {
                            MessageBox.Show("Error Parsing Data, Please Recheck AT Script File: " + temp,FRM_TITLE,MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            return;
                            }
                        }
                    else
                        {
                        txtResult.AppendText("Sending Command: " + ATcmd);
                        txtResult.AppendText("\r\n");
                        try
                            {
                            mySer.Write(ATcmd);
                            mySer.Write(new byte[]{0x0D},0,1);
                            }
                        catch
                            {
                            MessageBox.Show("Error Sending Data to GSM Modem!",FRM_TITLE,MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            return;
                            }
                        }

                    txtResult.AppendText("Delay: " + delay + "msec");
                    txtResult.AppendText("\r\n");
                    System.Threading.Thread.Sleep(delay);
                    if(boolReadRx)
                        {
                        string readSer=mySer.ReadExisting();

                        if(chkBinMode.Checked)
                            {
                            char [] readChar= readSer.ToCharArray();
                            StringBuilder strb=new StringBuilder();

                            foreach(char mychar in readChar)
                                {
                                strb.AppendFormat("<0x{0:X2}>",(int)mychar);
                                }
                            readSer=strb.ToString();
                            }

                        else if(chkShowEndHex.Checked)
                            {
                            for(int ctr=0;ctr<0x20;ctr++)
                                {
                                readSer =readSer.Replace(String.Format("{0}",(char)ctr),String.Format("<0x{0:X2}>",ctr));
                                }
                            }
                        txtResult.AppendText("Received Reply:\r\n");
                        txtResult.AppendText(readSer);
                        txtResult.AppendText("\r\n");
                        }
                    txtResult.AppendText("===========================\r\n");
                    }
                }
            finally
                {
                btnRun.Enabled=true;
                mySer.Dispose();
                System.GC.Collect();
                }
            txtResult.AppendText("===========================\r\n");
            txtResult.AppendText("===========END===========\r\n");
            }
        else
            {
            if(SCRFile==String.Empty)
                MessageBox.Show("Choose file first!",FRM_TITLE,MessageBoxButtons.OK,MessageBoxIcon.Stop);
            else
                MessageBox.Show("File does not exist!",FRM_TITLE,MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }   
        }

        private void btnCopyToClipBoard_Click(object sender, EventArgs e)
        {
        if(txtResult.Text.Length!=0)
            {
            Clipboard.Clear();
            Clipboard.SetText(txtResult.Text);
            }
        }

    }
}



// eof

