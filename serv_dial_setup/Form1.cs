using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;

namespace serv_dial_setup
{
    public partial class ServDial_mf : Form
    {
        public string[] data1;
        public string[] data2;
        public string[] data3;
        #region Settings action
        Props props = new Props(); //экземпляр класса с настройками 
        //Запись настроек
        private void WriteSetting(string XMLFile)
        {
            //Запись значения в ComboBox1
            // props.Fields.TextValue = comboBox1.Text;
            //Запись значения в checkBox1
            //  props.Fields.BoolValue = checkBox1.Checked;
            // props.Fields.TextValue2 = textBox1.Text;
            props.Fields.XMLFileName = XMLFile;
            props.Fields.user = textBox1.Text;
            props.Fields.pass = textBox2.Text;
            props.Fields.locIP = textBox3.Text ;            
         string[] data1 = { tb_n1.Text, tb_rIP1.Text, tb_gIP1.Text };
         string[] data2 = { tb_n2.Text, tb_rIP2.Text, tb_gIP2.Text };
         string[] data3 = { tb_n3.Text, tb_rIP3.Text, tb_gIP3.Text };         
            props.Fields.VPNname_locIP_inIP1 = data1;
            props.Fields.VPNname_locIP_inIP2 = data2;
            props.Fields.VPNname_locIP_inIP3 = data3;
            props.Fields.mail_user = mail_user.Text;
            props.Fields.mail_pass = mail_pass.Text;
            props.Fields.mail_server = mail_server.Text;
            props.Fields.mail_port = mail_port.Text;
            props.Fields.mail_2user = mail_2addr.Text;
            props.Fields.mail_captionmessage = mail_captionmessage.Text;
            props.Fields.mail_TLS = mail_TLS.Checked;
            props.WriteXml();
        }
        //Чтение настроек
        private void ReadSetting(string XMLFile)
        {
            props.Fields.XMLFileName = XMLFile;
            props.ReadXml();            
            textBox1.Text=props.Fields.user ;
            textBox2.Text=props.Fields.pass;
            textBox3.Text = props.Fields.locIP;
            data1 = props.Fields.VPNname_locIP_inIP1;
            data2 = props.Fields.VPNname_locIP_inIP2;
            data3 = props.Fields.VPNname_locIP_inIP3;
            tb_n1.Text = data1[0];
            tb_n2.Text = data2[0];
            tb_n3.Text = data3[0];
            tb_gIP1.Text=data1[2];
            tb_rIP1.Text=data1[1] ;
            tb_gIP2.Text=data2[2];
            tb_rIP2.Text=data2[1] ;
            tb_gIP3.Text=data3[2];
            tb_rIP3.Text=data3[1];
            mail_user.Text = props.Fields.mail_user;
            mail_pass.Text=props.Fields.mail_pass;
            mail_server.Text=props.Fields.mail_server;
            mail_port.Text=props.Fields.mail_port;
            mail_2addr.Text=props.Fields.mail_2user;
            mail_captionmessage.Text=props.Fields.mail_captionmessage;
            mail_TLS.Checked=props.Fields.mail_TLS;
            //comboBox1.Text = props.Fields.TextValue;
            // checkBox1.Checked = props.Fields.BoolValue;
            //  textBox1.Text = props.Fields.TextValue2;
        }
        #endregion
        //получаем статус службы ??? а если ее вообще такой нет????
        private string status_process(string name_process)
        { string status="xz";     
            //if (ctl == null)
                ServiceController sc = new ServiceController(name_process);
            bool ServiceIsInstalled = false;
            try
            {
                // actually we need to try access ANY of service properties
                // at least once to trigger an exception
                // not neccessarily its name
                string ServiceName = sc.DisplayName;
                ServiceIsInstalled = true;
                switch (sc.Status)
                {
                    case ServiceControllerStatus.Running:
                        return "Running";
                    case ServiceControllerStatus.Stopped:
                        return "Stopped";
                    case ServiceControllerStatus.Paused:
                        return "Paused";
                    case ServiceControllerStatus.StopPending:
                        return "Stopping";
                    case ServiceControllerStatus.StartPending:
                        return "Starting";
                    default:
                        return "Status Changing";
                }
            }
            catch (InvalidOperationException) { }
            finally
            {

                sc.Close();
                status= "not installed";
            }
            // if (sc.Status.Equals(ServiceControllerStatus.Stopped)) status = "stopped";
            //if (sc.Status.Equals(ServiceControllerStatus.Running)) status = "running";
            //  status=sc.Status.ToString();
            return status;            
            
        }
        public ServDial_mf()
        {
            InitializeComponent();
        }      
        string prefix_cmd = @" /c ",fileSettings= @"\settings.xml";
        string prog_name = @"\serv_dial.exe", prog_name_full;
        string serviceName = "!ServDial";
        private void button1_Click(object sender, EventArgs e)
        {
            //readSetting();
            WriteSetting(fileSettings);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //sc create !ServDial start=auto binPath= "c:\dial\dial.exe" DisplayName= "!ServDial" depend=lanmanworkstation obj= "LocalSystem"
            //string commd = "sc create " + serviceName+" start=auto binPath=\"c:\\dial\\dial.exe\" DisplayName=\"!ServDial\" depend=lanmanworkstation obj=\"LocalSystem\"";          
            //string commd = "sc create " + serviceName + " start=auto binPath=\"c:\\dial\\dial.exe\" DisplayName=\""+serviceName+"\" depend=lanmanworkstation obj=\"LocalSystem\"";
            string commd = "sc create " + serviceName + " start=auto binPath=\""+prog_name_full+"\" DisplayName=\"" + serviceName + "\" depend=lanmanworkstation obj=\"LocalSystem\"";
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
            prog_name_full = Environment.CurrentDirectory + prog_name;
            //MessageBox.Show(fileSettings);
            if (File.Exists(fileSettings)) ReadSetting(fileSettings);
            //иначе будем спрашивать где долежн быть файл, хотя легче этого не делать
            else {
               
       // string log_file = @"C:\dial\log.txt";
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
            string status=status_process(serviceName);
            if (status== "not installed") { stop_servive.Enabled = remove_service.Enabled = false; }
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
