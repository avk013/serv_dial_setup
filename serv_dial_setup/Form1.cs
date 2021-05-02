using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace serv_dial_setup
{
    public partial class Form1 : Form
    {
        public string[] data1;
        public string[] data2;
        public string[] data3;
        #region Settings action
        Props props = new Props(); //экземпляр класса с настройками 
        //Запись настроек
        private void WriteSetting()
        {
            //Запись значения в ComboBox1
            // props.Fields.TextValue = comboBox1.Text;
            //Запись значения в checkBox1
            //  props.Fields.BoolValue = checkBox1.Checked;
            // props.Fields.TextValue2 = textBox1.Text;
            props.Fields.user = textBox1.Text;
            props.Fields.pass = textBox2.Text;
            props.Fields.locIP = textBox3.Text ;
            data1[2] = tb_gIP1.Text;
            data1[1] = tb_rIP1.Text;
            data2[2] = tb_gIP2.Text;
            data2[1] = tb_rIP2.Text;
            data3[2] = tb_gIP3.Text;
            data3[1] = tb_rIP3.Text;
            props.Fields.VPNname_locIP_inIP1 = data1;
            props.Fields.VPNname_locIP_inIP2 = data2;
            props.Fields.VPNname_locIP_inIP3 = data3;
            props.WriteXml();
        }
        //Чтение настроек
        private void ReadSetting()
        {
            props.ReadXml();
            textBox1.Text=props.Fields.user ;
            textBox2.Text=props.Fields.pass;
            textBox3.Text = props.Fields.locIP;
            data1 = props.Fields.VPNname_locIP_inIP1;
            data2 = props.Fields.VPNname_locIP_inIP2;
            data3 = props.Fields.VPNname_locIP_inIP3;
            tb_gIP1.Text=data1[2];
            tb_rIP1.Text=data1[1] ;
            tb_gIP2.Text=data2[2];
            tb_rIP2.Text=data2[1] ;
            tb_gIP3.Text=data3[2];
            tb_rIP3.Text=data3[1];
            //comboBox1.Text = props.Fields.TextValue;
            // checkBox1.Checked = props.Fields.BoolValue;
            //  textBox1.Text = props.Fields.TextValue2;
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }      
        string prefix_cmd = @" /c ",fileSettings= @"\settings.xml";
        string serviceName = "!ServDial";
        private void button1_Click(object sender, EventArgs e)
        {
            //readSetting();
            WriteSetting();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //sc create !ServDial start=auto binPath= "c:\dial\dial.exe" DisplayName= "!ServDial" depend=lanmanworkstation obj= "LocalSystem"
            //string commd = "sc create " + serviceName+" start=auto binPath=\"c:\\dial\\dial.exe\" DisplayName=\"!ServDial\" depend=lanmanworkstation obj=\"LocalSystem\"";
            string commd = "sc create " + serviceName + " start=auto binPath=\"c:\\dial\\dial.exe\" DisplayName=\""+serviceName+"\" depend=lanmanworkstation obj=\"LocalSystem\"";
            //MessageBox.Show(commd);
            command_(@"cmd.exe", @" /c "+commd);
            commd = @"sc start "+serviceName;
            command_(@"cmd.exe", @" /c " + commd);
        }
        private void button3_Click(object sender, EventArgs e)
        {//sc delete !ServDial
            string commd = @"sc delete "+serviceName;
            command_(@"cmd.exe", @" /c " + commd);
        }
        private void button4_Click(object sender, EventArgs e)
        {  //sc stop !ServDial
            string commd = @"sc stop "+serviceName;
            command_(@"cmd.exe", @" /c " + commd);
        }
        private void Form1_Load(object sender, EventArgs e)
        {//узнать есть ли прва администратора
         //manifest:<requestedExecutionLevel level="requireAdministrator" uiAccess="false" />
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!hasAdministrativeRight)
            {
                label9.ForeColor = Color.Red;
                install_service.BackColor= stop_servive.BackColor=remove_service.BackColor = Color.LightGray;
                install_service.Enabled = stop_servive.Enabled = remove_service.Enabled = false;
            }
            else label9.Visible = false;
            //
            fileSettings = Environment.CurrentDirectory +fileSettings;
            //MessageBox.Show(fileSettings);
            if (File.Exists(fileSettings)) ReadSetting();
            //иначе будем спрашивать где долежн быть файл, хотя легче этого не делать
            else {
               
        string log_file = @"C:\dial\log.txt";
        string my_ip = "192.168.111.1";
        string[,] datas = { { "nameVPN1", "locIP1", "SerVPN1" },
                            { "nameVPN2", "locIP2", "SerVPN2" },
                            { "nameVPN3","locIP3", "SerVPN3"} };
                textBox1.Text="user";
                textBox2.Text = "passwd";
                textBox3.Text=my_ip;
                tb_gIP1.Text=datas[0,1];
                tb_rIP1.Text = datas[0, 2];
                tb_n1.Text = datas[0, 0];
                tb_gIP2.Text = datas[1, 1];
                tb_rIP2.Text = datas[1, 2];
                tb_n2.Text = datas[1, 0];
                tb_gIP3.Text = datas[2, 1];
                tb_rIP3.Text = datas[2, 2];
                tb_n3.Text = datas[2, 0];
                }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {  // файл настроек ВПН для текущего пользователя - откр.папку
            Process.Start(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\AppData\Roaming\Microsoft\Network\Connections\Pbk"));
            //файл настроек ВПН для всех процессов и польз.  - откр.папку
            Process.Start(@"C:\Windows\System32\ras");
            //%USERPROFILE%\AppData\Roaming\Microsoft\Network\Connections\Pbk\rasphone.pbk
            //может быть сразу копировать!?!? будем думать
        }

        private string command_(string FileName, string Arguments)
        {
            string output;
            using (var p = new System.Diagnostics.Process())
            {   p.StartInfo.FileName = FileName;p.StartInfo.Arguments = Arguments;
                p.StartInfo.UseShellExecute = false;p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.StandardOutputEncoding = Encoding.GetEncoding("CP866");
                p.Start(); output = p.StandardOutput.ReadToEnd();
            }
            return output;
        }
    }
}
