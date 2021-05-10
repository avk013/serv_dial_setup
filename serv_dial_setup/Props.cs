using System;
//надо добавить для работы класса
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace serv_dial_setup
{
    //Класс определяющий какие настройки есть в программе
    public class PropsFields
    {
        public String XMLFileName = "";// Environment.CurrentDirectory + "\\settings.xml";
        //Чтобы добавить настройку в программу просто добавьте туда строку вида -
        //public ТИП ИМЯ_ПЕРЕМЕННОЙ = значение_переменной_по_умолчанию;
        public String user = @"user1", pass = "password1";        
        public String locIP = "127.0.0.1";
        public string[] VPNname_locIP_inIP1 = { "pro1", "192.168.1.11", "172.16.1.11" };
        public string[] VPNname_locIP_inIP2 = { "pro2", "192.168.1.12", "172.16.1.12" };
        public string[] VPNname_locIP_inIP3 = { "pro3","192.168.1.13", "172.16.1.13"} ;
        public String mail_user, mail_server, mail_port, mail_pass;
        public String mail_2user, mail_captionmessage;
        public Boolean mail_TLS;        
        // public DateTime DateValue = new DateTime(2011, 1, 1);
        //public Decimal DecimalValue = 555;
        //public Boolean BoolValue = true;
        //public string log_file = @"C:\dial\log.txt";
    }
    //Класс работы с настройками
    public class Props
    {
        public PropsFields Fields;

        public Props()
        {
            Fields = new PropsFields();
        }
        //Запись настроек в файл
        public void WriteXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(PropsFields));

            using (TextWriter writer = new StreamWriter(Fields.XMLFileName))
            {
                ser.Serialize(writer, Fields);
                // writer.Flush(); // writer.Close();
            }
            //   MessageBox.Show("ok "); //MessageBox.Show(Fields.XMLFileName);
        }
        //Чтение насроек из файла
        public void ReadXml()
        {  if (File.Exists(Fields.XMLFileName))
                   {//но если файл с внутренними ошибками, то нужно удалять xml  
                        XmlSerializer ser = new XmlSerializer(typeof(PropsFields));
                        TextReader reader = new StreamReader(Fields.XMLFileName);
                        Fields = ser.Deserialize(reader) as PropsFields;
                        reader.Close();
                    }             
            else
            {
                MessageBox.Show("no Settings XML file, creating defaults file");
                //можно написать вывод сообщения если файла не существует
            }
        }        
    }
}