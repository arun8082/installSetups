using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace dco_setup
{
    public partial class Form1 : Form
    {
        private int checkedCount = 0;
        private string[] driversList = new string[11];
        private string driverFor = "";
        public Form1()
        {
            InitializeComponent();
            driverFor = "DCO";
            loadDCODriversList();
            txt_driverPath.Text = @"E:\BSID_1\sid drivers";
            rdbtn_dco.Checked = true;
        }

        private void loadDCODriversList()
        {           
            chkList_drivers.Items.Add("Camera Canon");
            chkList_drivers.Items.Add("Fortis Client");
            chkList_drivers.Items.Add("OpenCV 2.4.11");
            chkList_drivers.Items.Add("Scanner Epson");
            chkList_drivers.Items.Add("Signature Pad");
            chkList_drivers.Items.Add("Anaconda3");
            chkList_drivers.Items.Add("Test Setup");
        }

        private void loadPODriversList()
        {
            chkList_drivers.Items.Add("Fortis Client");
            chkList_drivers.Items.Add("Printer");
            chkList_drivers.Items.Add("Java JDK");
            chkList_drivers.Items.Add("Token");
            chkList_drivers.Items.Add("PKCS Config");
            chkList_drivers.Items.Add("gpj");
            chkList_drivers.Items.Add("Encode Printer");
        }

        private void btn_driverPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_driverPath.Text = browserDialog.SelectedPath;
            }
        }

        private void btn_verifyDrivers_Click(object sender, EventArgs e)
        {
            checkedCount = 0;
            string[] directories;
            try
            {
                directories = Directory.GetDirectories(txt_driverPath.Text);
            }catch(Exception ex)
            {
                DialogResult dr = MessageBox.Show("Verify Drivers: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (driverFor.Equals("DCO"))
            {
                foreach (string directory in directories)
                {
                    //Console.WriteLine(directory);
                    setDCOCheckedToDriver(directory);
                }
                if (checkedCount == 7)
                {
                    btn_install.Enabled = true;
                    chkList_drivers.Enabled = true;
                }
            }
            else if (driverFor.Equals("PO"))
            {
                foreach (string directory in directories)
                {
                    //Console.WriteLine(directory);
                    setPOCheckedToDriver(directory);
                }
                //Console.WriteLine(checkedCount);
                if (checkedCount == 7)
                {
                    string jrePath = Environment.GetEnvironmentVariable("JRE_HOME");
                    if (string.IsNullOrEmpty(jrePath))
                    {
                        DialogResult dr = MessageBox.Show("Please set JRE_HOME environment variable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    btn_install.Enabled = true;
                    chkList_drivers.Enabled = true;
                }
            }
        }

        private void setDCOCheckedToDriver(string directory)
        {
            string dir=directory.Substring(directory.LastIndexOf('\\')+1).ToLower();
            switch (dir)
            {
                case "canon eos 1200 sdk":
                    if (File.Exists(directory + @"\setup.exe"))
                    {
                        chkList_drivers.SetItemChecked(0, true);
                        driversList[0] = directory + @"\setup.exe";
                        checkedCount++;
                    }
                    break;
                case "fortis client":
                    if (File.Exists(directory + @"\FortiClientOnlineInstaller.exe"))
                    {
                        chkList_drivers.SetItemChecked(2, true);
                        driversList[1] = directory + @"\FortiClientOnlineInstaller.exe";
                        checkedCount++;
                    }
                    break;
                case "opencv":
                    if (File.Exists(directory + @"\opencv-2.4.11.exe"))
                    {
                        chkList_drivers.SetItemChecked(3, true);
                        driversList[2] = directory + @"\opencv-2.4.11.exe";
                        checkedCount++;
                    }
                    break;
                case "scanner driver":
                    if (File.Exists(directory + @"\setup_full_5590_20_0_0_002.exe"))
                    {
                        chkList_drivers.SetItemChecked(4, true);
                        driversList[3] = directory + @"\setup_full_5590_20_0_0_002.exe";
                        checkedCount++;
                    }
                    break;
                case "signature pad":
                    if (File.Exists(directory + @"\sigplusnet.exe"))
                    {
                        chkList_drivers.SetItemChecked(5, true);
                        driversList[4] = directory + @"\sigplusnet.exe";
                        checkedCount++;
                    }
                    break;
                case "anaconda3":
                    if (File.Exists(directory + @"\Anaconda3-4.3.0.1-Windows-x86_64.exe"))
                    {
                        chkList_drivers.SetItemChecked(1, true);
                        driversList[5] = directory + @"\Anaconda3-4.3.0.1-Windows-x86_64.exe";
                        checkedCount++;
                    }
                    break;
                case "test1":
                    if (File.Exists(directory + @"\setup.exe"))
                    {
                        chkList_drivers.SetItemChecked(6, true);
                        driversList[6] = directory + @"\setup.exe";
                        checkedCount++;
                    }
                    break;
            }
        }

        private void setPOCheckedToDriver(string directory)
        {
            string dir = directory.Substring(directory.LastIndexOf('\\') + 1).ToLower();
            //Console.WriteLine("switch: " + dir);
            switch (dir)
            {
                case "fortis client":
                    if (File.Exists(directory + @"\FortiClientOnlineInstaller.exe"))
                    {
                        chkList_drivers.SetItemChecked(0, true);
                        driversList[0] = directory + @"\FortiClientOnlineInstaller.exe";
                        checkedCount++;
                    }
                    break;
                case "printer":
                    int j = 1;
                    int count = 0;
                    string[] printerDrivers = new string[] {"510994_RevF_FargoSDK_v2.1.0.5.exe","511191W_RevF_HDP5000_v2.7.0.3.4_Setup (1).exe","hdp5000_drv_2305.exe","HID_OMNIKEY5x2x_x64_W8_R1_2_26_140.exe" };
                    foreach(string printerDriver in printerDrivers)
                    {
                        if (File.Exists(directory +@"\"+printerDriver))
                        {
                            driversList[j++] = directory + @"\" + printerDriver;
                            count++;
                        }
                    }
                    if (count == printerDrivers.Length)
                    {
                        chkList_drivers.SetItemChecked(1, true);
                        checkedCount++;
                    }                    
                    break;
                case "jdk":
                    if (File.Exists(directory + @"\jdk-8u151-windows-x64.exe"))
                    {
                        chkList_drivers.SetItemChecked(2, true);
                        driversList[5] = directory + @"\jdk-8u151-windows-x64.exe";
                        checkedCount++;
                    }
                    break;
                case "token":
                    j = 6;
                    count = 0;
                    string[] tokenDrivers = new string[] { "eToken_PKIClient-x64bit-5.1SP1-Beta.msi", "SafeNetAuthenticationClient-x64-8.3.msi" };
                    foreach(string tokenDriver in tokenDrivers)
                    {
                        if (File.Exists(directory + @"\" + tokenDriver))
                        {
                            driversList[j++] = directory + @"\" + tokenDriver;
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        chkList_drivers.SetItemChecked(3, true);
                        checkedCount++;
                    }
                    break;
                case "pkcs config":
                    if (File.Exists(directory + @"\pkcs11.cfg"))
                    {
                        chkList_drivers.SetItemChecked(4, true);
                        driversList[8] = directory + @"\pkcs11.cfg";
                        checkedCount++;
                    }
                    break;
                case "gpj":
                    if (File.Exists(directory + @"\AppletRun.bat"))
                    {
                        chkList_drivers.SetItemChecked(5, true);
                        driversList[9] = directory + @"\AppletRun.bat";
                        checkedCount++;
                    }
                    break;
                case "encode printer":
                    if (File.Exists(directory + @"\EncodePrinter.exe"))
                    {
                        chkList_drivers.SetItemChecked(6, true);
                        driversList[10] = directory + @"\EncodePrinter.exe";
                        checkedCount++;
                    }
                    break;
            }
        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            Process p;
            int installedCounter = 0;
            List<int> list = new List<int>();

            chkList_drivers.Enabled = false;
            foreach (int itemChecked in chkList_drivers.CheckedIndices)
            {
                list.Add(itemChecked);
            }

            for (int i=0; i<driversList.Length;i++)
            {
                try
                {
                    if (driverFor.Equals("PO") && (i==8||i==9))
                    {
                        //Console.WriteLine(driversList[i]);
                        continue;
                    }
                    if (driverFor.Equals("DCO"))
                    {
                        if (!list.Contains(i))
                        {
                            continue;
                        }
                    }
                    //Console.WriteLine(driversList[i]);
                    /*
                    p = new Process();
                    p.StartInfo.FileName = driversList[i];
                    p.Start();
                    while (true)
                    {
                        if (p.HasExited == true)
                        {
                            break;
                        }
                    }
                    p.WaitForExit();
                    */
                }catch(Exception ex)
                {
                    DialogResult dr = MessageBox.Show("Install: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                installedCounter++;
            }

            if (driverFor.Equals("PO"))
            {
                //copy pkcs11.cfg
                string jrePath = Environment.GetEnvironmentVariable("JRE_HOME");
                if (string.IsNullOrEmpty(jrePath))
                {
                    DialogResult dr = MessageBox.Show("Please set JRE_HOME environment variable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string pkcsPath = jrePath+@"lib\security\pkcs11.cfg";
                File.Copy(driversList[8], pkcsPath, true);
                string javaSecurity= jrePath+ @"lib\security\java.security";
                string key = "security.provider.11=sun.security.pkcs11.SunPKCS11 "+jrePath+@"lib\security";
                if (!File.Exists(javaSecurity))
                {
                    DialogResult dr = MessageBox.Show("java.security file doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    File.AppendAllText(javaSecurity, "\n"+key);
                }catch(Exception ex)
                {
                    DialogResult dr = MessageBox.Show("Unable to write security path in java.security", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                installedCounter++;

                //copy gpj files
                try
                {
                    string desktopLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\gpj\";
                    string gpjFilesPath = driversList[9].Substring(0, driversList[9].LastIndexOf('\\'));
                    if (!Directory.Exists(desktopLocation))
                    {
                        Directory.CreateDirectory(desktopLocation);
                    }

                    DirectoryInfo source = new DirectoryInfo(gpjFilesPath);
                    foreach (FileInfo file in source.GetFiles())
                    {
                        file.CopyTo(desktopLocation + file, true);
                    }
                    installedCounter++;
                }catch(Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    DialogResult dr = MessageBox.Show("Copy gpj: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Console.WriteLine("count:"+installedCounter);
            if (driverFor.Equals("DCO") && installedCounter == 7)
            {
                lbl_status.Text = "Installation completed successfully";
                lbl_status.ForeColor = Color.ForestGreen;
            }
            else if (driverFor.Equals("PO") && installedCounter == 11) {
                lbl_status.Text = "Installation completed successfully";
                lbl_status.ForeColor = Color.ForestGreen;
            }
            else
            {
                lbl_status.Text = "Error: All drivers are not installed";
                lbl_status.ForeColor = Color.DarkRed;
            }
        }

        private void rdbtn_po_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_po.Checked)
            {
                driverFor = rdbtn_po.Text;
                chkList_drivers.Items.Clear();
                loadPODriversList();
            }
        }

        private void rdbtn_dco_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_dco.Checked)
            {
                driverFor = rdbtn_dco.Text;
                chkList_drivers.Items.Clear();
                loadDCODriversList();
            }
        }
    }
}
