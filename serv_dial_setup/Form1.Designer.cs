namespace serv_dial_setup
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.save_set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_gIP1 = new System.Windows.Forms.TextBox();
            this.tb_rIP1 = new System.Windows.Forms.TextBox();
            this.tb_gIP2 = new System.Windows.Forms.TextBox();
            this.tb_rIP2 = new System.Windows.Forms.TextBox();
            this.tb_gIP3 = new System.Windows.Forms.TextBox();
            this.tb_rIP3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.install_service = new System.Windows.Forms.Button();
            this.remove_service = new System.Windows.Forms.Button();
            this.stop_servive = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_n1 = new System.Windows.Forms.TextBox();
            this.tb_n2 = new System.Windows.Forms.TextBox();
            this.tb_n3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save_set
            // 
            this.save_set.Location = new System.Drawing.Point(12, 189);
            this.save_set.Name = "save_set";
            this.save_set.Size = new System.Drawing.Size(353, 28);
            this.save_set.TabIndex = 0;
            this.save_set.Text = "save_settings";
            this.save_set.UseVisualStyleBackColor = true;
            this.save_set.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP VPN client_adr_local";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "global_IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "remote_IP_vpn";
            // 
            // tb_gIP1
            // 
            this.tb_gIP1.Location = new System.Drawing.Point(45, 107);
            this.tb_gIP1.Name = "tb_gIP1";
            this.tb_gIP1.Size = new System.Drawing.Size(100, 20);
            this.tb_gIP1.TabIndex = 9;
            // 
            // tb_rIP1
            // 
            this.tb_rIP1.Location = new System.Drawing.Point(154, 107);
            this.tb_rIP1.Name = "tb_rIP1";
            this.tb_rIP1.Size = new System.Drawing.Size(100, 20);
            this.tb_rIP1.TabIndex = 10;
            // 
            // tb_gIP2
            // 
            this.tb_gIP2.Location = new System.Drawing.Point(45, 133);
            this.tb_gIP2.Name = "tb_gIP2";
            this.tb_gIP2.Size = new System.Drawing.Size(100, 20);
            this.tb_gIP2.TabIndex = 11;
            // 
            // tb_rIP2
            // 
            this.tb_rIP2.Location = new System.Drawing.Point(154, 133);
            this.tb_rIP2.Name = "tb_rIP2";
            this.tb_rIP2.Size = new System.Drawing.Size(100, 20);
            this.tb_rIP2.TabIndex = 12;
            // 
            // tb_gIP3
            // 
            this.tb_gIP3.Location = new System.Drawing.Point(45, 159);
            this.tb_gIP3.Name = "tb_gIP3";
            this.tb_gIP3.Size = new System.Drawing.Size(100, 20);
            this.tb_gIP3.TabIndex = 13;
            // 
            // tb_rIP3
            // 
            this.tb_rIP3.Location = new System.Drawing.Point(154, 159);
            this.tb_rIP3.Name = "tb_rIP3";
            this.tb_rIP3.Size = new System.Drawing.Size(100, 20);
            this.tb_rIP3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "serv1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "serv2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "serv3";
            // 
            // install_service
            // 
            this.install_service.Location = new System.Drawing.Point(12, 223);
            this.install_service.Name = "install_service";
            this.install_service.Size = new System.Drawing.Size(353, 28);
            this.install_service.TabIndex = 18;
            this.install_service.Text = "install_service & start_service";
            this.install_service.UseVisualStyleBackColor = true;
            this.install_service.Click += new System.EventHandler(this.button2_Click);
            // 
            // remove_service
            // 
            this.remove_service.Location = new System.Drawing.Point(231, 274);
            this.remove_service.Name = "remove_service";
            this.remove_service.Size = new System.Drawing.Size(134, 28);
            this.remove_service.TabIndex = 19;
            this.remove_service.Text = "remove_service";
            this.remove_service.UseVisualStyleBackColor = true;
            this.remove_service.Click += new System.EventHandler(this.button3_Click);
            // 
            // stop_servive
            // 
            this.stop_servive.Location = new System.Drawing.Point(9, 274);
            this.stop_servive.Name = "stop_servive";
            this.stop_servive.Size = new System.Drawing.Size(134, 28);
            this.stop_servive.TabIndex = 20;
            this.stop_servive.Text = "stop_service";
            this.stop_servive.UseVisualStyleBackColor = true;
            this.stop_servive.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(343, 42);
            this.label9.TabIndex = 21;
            this.label9.Text = "запускай с правами администратора!!!! для работы с сервисами";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "name_dial";
            // 
            // tb_n1
            // 
            this.tb_n1.Location = new System.Drawing.Point(260, 107);
            this.tb_n1.Name = "tb_n1";
            this.tb_n1.Size = new System.Drawing.Size(100, 20);
            this.tb_n1.TabIndex = 23;
            // 
            // tb_n2
            // 
            this.tb_n2.Location = new System.Drawing.Point(260, 133);
            this.tb_n2.Name = "tb_n2";
            this.tb_n2.Size = new System.Drawing.Size(100, 20);
            this.tb_n2.TabIndex = 24;
            // 
            // tb_n3
            // 
            this.tb_n3.Location = new System.Drawing.Point(260, 159);
            this.tb_n3.Name = "tb_n3";
            this.tb_n3.Size = new System.Drawing.Size(100, 20);
            this.tb_n3.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "открыть расположение соединений VPN польз и  общее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 307);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_n3);
            this.Controls.Add(this.tb_n2);
            this.Controls.Add(this.tb_n1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stop_servive);
            this.Controls.Add(this.remove_service);
            this.Controls.Add(this.install_service);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_rIP3);
            this.Controls.Add(this.tb_gIP3);
            this.Controls.Add(this.tb_rIP2);
            this.Controls.Add(this.tb_gIP2);
            this.Controls.Add(this.tb_rIP1);
            this.Controls.Add(this.tb_gIP1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_set);
            this.Name = "Form1";
            this.Text = "serv_dial_setup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_gIP1;
        private System.Windows.Forms.TextBox tb_rIP1;
        private System.Windows.Forms.TextBox tb_gIP2;
        private System.Windows.Forms.TextBox tb_rIP2;
        private System.Windows.Forms.TextBox tb_gIP3;
        private System.Windows.Forms.TextBox tb_rIP3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button install_service;
        private System.Windows.Forms.Button remove_service;
        private System.Windows.Forms.Button stop_servive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_n1;
        private System.Windows.Forms.TextBox tb_n2;
        private System.Windows.Forms.TextBox tb_n3;
        private System.Windows.Forms.Button button1;
    }
}

