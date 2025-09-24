namespace TrueNASLocker.UI
{
    partial class DatasetViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem6 = new ListViewItem("jam");
            ListViewItem listViewItem7 = new ListViewItem("cas");
            ListViewItem listViewItem8 = new ListViewItem("drv");
            ListViewItem listViewItem9 = new ListViewItem("12341");
            ListViewItem listViewItem10 = new ListViewItem("123414");
            dataset_form = new Panel();
            userAccountBox1 = new UserAccountBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
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
            checkBox1 = new CheckBox();
            unlock_button = new Button();
            password_textbox = new TextBox();
            datasetUnselectedBox1 = new DatasetUnselectedBox();
            dataset_form.SuspendLayout();
            pwdchg_panel.SuspendLayout();
            lock_panel.SuspendLayout();
            unlock_panel.SuspendLayout();
            SuspendLayout();
            // 
            // dataset_form
            // 
            dataset_form.Controls.Add(datasetUnselectedBox1);
            dataset_form.Controls.Add(userAccountBox1);
            dataset_form.Controls.Add(listView1);
            dataset_form.Controls.Add(pwdchg_panel);
            dataset_form.Controls.Add(lock_panel);
            dataset_form.Controls.Add(unlock_panel);
            dataset_form.Dock = DockStyle.Fill;
            dataset_form.Location = new Point(0, 0);
            dataset_form.Name = "dataset_form";
            dataset_form.Size = new Size(725, 461);
            dataset_form.TabIndex = 8;
            // 
            // userAccountBox1
            // 
            userAccountBox1.Host = "localhost";
            userAccountBox1.Location = new Point(172, 237);
            userAccountBox1.Name = "userAccountBox1";
            userAccountBox1.Size = new Size(129, 147);
            userAccountBox1.TabIndex = 11;
            userAccountBox1.Username = "user";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.FullRowSelect = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(163, 381);
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
            // pwdchg_panel
            // 
            pwdchg_panel.Controls.Add(checkBox4);
            pwdchg_panel.Controls.Add(label6);
            pwdchg_panel.Controls.Add(label5);
            pwdchg_panel.Controls.Add(textBox3);
            pwdchg_panel.Controls.Add(button4);
            pwdchg_panel.Controls.Add(button2);
            pwdchg_panel.Controls.Add(textBox2);
            pwdchg_panel.Location = new Point(442, 3);
            pwdchg_panel.Name = "pwdchg_panel";
            pwdchg_panel.Size = new Size(129, 228);
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
            button4.Location = new Point(6, 185);
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
            lock_panel.Location = new Point(307, 3);
            lock_panel.Name = "lock_panel";
            lock_panel.Size = new Size(129, 228);
            lock_panel.TabIndex = 6;
            lock_panel.TabStop = false;
            lock_panel.Text = "dataset options";
            // 
            // button5
            // 
            button5.Location = new Point(6, 185);
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
            unlock_panel.Location = new Point(172, 3);
            unlock_panel.Name = "unlock_panel";
            unlock_panel.Size = new Size(129, 228);
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
            // datasetUnselectedBox1
            // 
            datasetUnselectedBox1.Location = new Point(577, 5);
            datasetUnselectedBox1.Name = "datasetUnselectedBox1";
            datasetUnselectedBox1.Size = new Size(129, 226);
            datasetUnselectedBox1.TabIndex = 12;
            // 
            // DatasetViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataset_form);
            Name = "DatasetViewer";
            Size = new Size(725, 461);
            dataset_form.ResumeLayout(false);
            pwdchg_panel.ResumeLayout(false);
            pwdchg_panel.PerformLayout();
            lock_panel.ResumeLayout(false);
            lock_panel.PerformLayout();
            unlock_panel.ResumeLayout(false);
            unlock_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel dataset_form;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox pwdchg_panel;
        private CheckBox checkBox4;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private Button button4;
        private Button button2;
        private TextBox textBox2;
        private GroupBox lock_panel;
        private Button button5;
        private CheckBox checkBox2;
        private Button button3;
        private GroupBox unlock_panel;
        private Label label4;
        private CheckBox checkBox1;
        private Button unlock_button;
        private TextBox password_textbox;
        private UserAccountBox userAccountBox1;
        private DatasetUnselectedBox datasetUnselectedBox1;
    }
}
