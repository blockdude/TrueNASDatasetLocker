namespace TrueNASLocker
{
    partial class LockerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("jam");
            ListViewItem listViewItem2 = new ListViewItem("cas");
            ListViewItem listViewItem3 = new ListViewItem("drv");
            ListViewItem listViewItem4 = new ListViewItem("12341");
            ListViewItem listViewItem5 = new ListViewItem("123414");
            unlock_button = new Button();
            password_textbox = new TextBox();
            checkBox1 = new CheckBox();
            dataset_form = new Panel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            default_panel = new GroupBox();
            textBox7 = new TextBox();
            user_panel = new GroupBox();
            textBox6 = new TextBox();
            button7 = new Button();
            textBox9 = new TextBox();
            pwdchg_panel = new GroupBox();
            checkBox4 = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            lock_panel = new GroupBox();
            button5 = new Button();
            checkBox2 = new CheckBox();
            button3 = new Button();
            unlock_panel = new GroupBox();
            label4 = new Label();
            loginBox1 = new TrueNASLocker.UI.LoginBox();
            dataset_form.SuspendLayout();
            default_panel.SuspendLayout();
            user_panel.SuspendLayout();
            pwdchg_panel.SuspendLayout();
            lock_panel.SuspendLayout();
            unlock_panel.SuspendLayout();
            SuspendLayout();
            // 
            // unlock_button
            // 
            unlock_button.Location = new Point(6, 22);
            unlock_button.Name = "unlock_button";
            unlock_button.Size = new Size(117, 23);
            unlock_button.TabIndex = 1;
            unlock_button.Text = "unlock";
            unlock_button.UseVisualStyleBackColor = true;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(6, 66);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(117, 23);
            password_textbox.TabIndex = 4;
            password_textbox.Tag = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 95);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataset_form
            // 
            dataset_form.Controls.Add(listView1);
            dataset_form.Controls.Add(default_panel);
            dataset_form.Controls.Add(user_panel);
            dataset_form.Controls.Add(pwdchg_panel);
            dataset_form.Controls.Add(lock_panel);
            dataset_form.Controls.Add(unlock_panel);
            dataset_form.Location = new Point(12, 12);
            dataset_form.Name = "dataset_form";
            dataset_form.Size = new Size(857, 320);
            dataset_form.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.FullRowSelect = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(311, 314);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Dataset";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            // 
            // default_panel
            // 
            default_panel.Controls.Add(textBox7);
            default_panel.Location = new Point(725, 3);
            default_panel.Name = "default_panel";
            default_panel.Size = new Size(129, 196);
            default_panel.TabIndex = 9;
            default_panel.TabStop = false;
            default_panel.Text = "select dataset";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Enabled = false;
            textBox7.Location = new Point(6, 84);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(117, 34);
            textBox7.TabIndex = 0;
            textBox7.Text = "Select a dataset to get started...";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // user_panel
            // 
            user_panel.Controls.Add(textBox6);
            user_panel.Controls.Add(button7);
            user_panel.Controls.Add(textBox9);
            user_panel.Location = new Point(320, 205);
            user_panel.Name = "user_panel";
            user_panel.Size = new Size(129, 112);
            user_panel.TabIndex = 8;
            user_panel.TabStop = false;
            user_panel.Text = "user";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(6, 51);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(117, 23);
            textBox6.TabIndex = 1;
            textBox6.Text = "admin";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // button7
            // 
            button7.Location = new Point(6, 80);
            button7.Name = "button7";
            button7.Size = new Size(117, 23);
            button7.TabIndex = 0;
            button7.Text = "logout";
            button7.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(6, 22);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(117, 23);
            textBox9.TabIndex = 10;
            textBox9.Text = "cobalt.snow.io";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // pwdchg_panel
            // 
            pwdchg_panel.Controls.Add(checkBox4);
            pwdchg_panel.Controls.Add(label6);
            pwdchg_panel.Controls.Add(label5);
            pwdchg_panel.Controls.Add(textBox3);
            pwdchg_panel.Controls.Add(button4);
            pwdchg_panel.Controls.Add(button2);
            pwdchg_panel.Controls.Add(textBox2);
            pwdchg_panel.Location = new Point(590, 3);
            pwdchg_panel.Name = "pwdchg_panel";
            pwdchg_panel.Size = new Size(129, 196);
            pwdchg_panel.TabIndex = 7;
            pwdchg_panel.TabStop = false;
            pwdchg_panel.Text = "change password";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 110);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(107, 19);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "show password";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 63);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 5;
            label6.Text = "confirm password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "new password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(6, 164);
            button4.Name = "button4";
            button4.Size = new Size(117, 23);
            button4.TabIndex = 3;
            button4.Text = "cancel";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 135);
            button2.Name = "button2";
            button2.Size = new Size(117, 23);
            button2.TabIndex = 0;
            button2.Text = "change";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 1;
            // 
            // lock_panel
            // 
            lock_panel.Controls.Add(button5);
            lock_panel.Controls.Add(checkBox2);
            lock_panel.Controls.Add(button3);
            lock_panel.Location = new Point(455, 3);
            lock_panel.Name = "lock_panel";
            lock_panel.Size = new Size(129, 196);
            lock_panel.TabIndex = 6;
            lock_panel.TabStop = false;
            lock_panel.Text = "dataset options";
            // 
            // button5
            // 
            button5.Location = new Point(6, 164);
            button5.Name = "button5";
            button5.Size = new Size(117, 23);
            button5.TabIndex = 3;
            button5.Text = "change password";
            button5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 51);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(95, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "force locking";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 22);
            button3.Name = "button3";
            button3.Size = new Size(117, 23);
            button3.TabIndex = 1;
            button3.Text = "lock";
            button3.UseVisualStyleBackColor = true;
            // 
            // unlock_panel
            // 
            unlock_panel.Controls.Add(label4);
            unlock_panel.Controls.Add(checkBox1);
            unlock_panel.Controls.Add(unlock_button);
            unlock_panel.Controls.Add(password_textbox);
            unlock_panel.Location = new Point(320, 3);
            unlock_panel.Name = "unlock_panel";
            unlock_panel.Size = new Size(129, 196);
            unlock_panel.TabIndex = 0;
            unlock_panel.TabStop = false;
            unlock_panel.Text = "unlock dataset";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "password";
            // 
            // loginBox1
            // 
            loginBox1.Location = new Point(265, 344);
            loginBox1.Margin = new Padding(0);
            loginBox1.Name = "loginBox1";
            loginBox1.Size = new Size(156, 261);
            loginBox1.TabIndex = 10;
            // 
            // LockerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 635);
            Controls.Add(loginBox1);
            Controls.Add(dataset_form);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LockerForm";
            Text = "TrueNAS Locker";
            Load += LockerForm_Load;
            dataset_form.ResumeLayout(false);
            default_panel.ResumeLayout(false);
            default_panel.PerformLayout();
            user_panel.ResumeLayout(false);
            user_panel.PerformLayout();
            pwdchg_panel.ResumeLayout(false);
            pwdchg_panel.PerformLayout();
            lock_panel.ResumeLayout(false);
            lock_panel.PerformLayout();
            unlock_panel.ResumeLayout(false);
            unlock_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button unlock_button;
        private TextBox password_textbox;
        private CheckBox checkBox1;
        private Panel dataset_form;
        private CheckBox checkBox2;
        private Button button3;
        private Button button5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private GroupBox unlock_panel;
        private Button button4;
        private GroupBox pwdchg_panel;
        private GroupBox lock_panel;
        private GroupBox user_panel;
        private Button button7;
        private TextBox textBox6;
        private GroupBox default_panel;
        private TextBox textBox7;
        private Label label4;
        private TextBox textBox9;
        private CheckBox checkBox4;
        private Label label6;
        private Label label5;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private UI.LoginBox loginBox1;
    }
}
