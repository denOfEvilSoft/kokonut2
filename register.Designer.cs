
namespace kokonut
{
    partial class register
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.t_inputId = new System.Windows.Forms.TextBox();
            this.t_inputPassword = new System.Windows.Forms.TextBox();
            this.t_cheakPassword = new System.Windows.Forms.TextBox();
            this.c_list = new System.Windows.Forms.ComboBox();
            this.b_creat = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.t_listInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // t_inputId
            // 
            this.t_inputId.Location = new System.Drawing.Point(117, 81);
            this.t_inputId.Name = "t_inputId";
            this.t_inputId.Size = new System.Drawing.Size(100, 21);
            this.t_inputId.TabIndex = 0;
            // 
            // t_inputPassword
            // 
            this.t_inputPassword.Location = new System.Drawing.Point(117, 108);
            this.t_inputPassword.Name = "t_inputPassword";
            this.t_inputPassword.Size = new System.Drawing.Size(100, 21);
            this.t_inputPassword.TabIndex = 1;
            // 
            // t_cheakPassword
            // 
            this.t_cheakPassword.Location = new System.Drawing.Point(117, 135);
            this.t_cheakPassword.Name = "t_cheakPassword";
            this.t_cheakPassword.Size = new System.Drawing.Size(100, 21);
            this.t_cheakPassword.TabIndex = 2;
            // 
            // c_list
            // 
            this.c_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_list.FormattingEnabled = true;
            this.c_list.Items.AddRange(new object[] {
            "태어난 곳",
            "지금 사는 지역",
            "첫 애완동물 이름"});
            this.c_list.Location = new System.Drawing.Point(117, 163);
            this.c_list.Name = "c_list";
            this.c_list.Size = new System.Drawing.Size(100, 20);
            this.c_list.TabIndex = 3;
            // 
            // b_creat
            // 
            this.b_creat.Location = new System.Drawing.Point(117, 229);
            this.b_creat.Name = "b_creat";
            this.b_creat.Size = new System.Drawing.Size(75, 23);
            this.b_creat.TabIndex = 4;
            this.b_creat.Text = "button1";
            this.b_creat.UseVisualStyleBackColor = true;
            this.b_creat.Click += new System.EventHandler(this.b_creat_Click);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(198, 229);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(75, 23);
            this.b_exit.TabIndex = 5;
            this.b_exit.Text = "button2";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // t_listInput
            // 
            this.t_listInput.Location = new System.Drawing.Point(117, 189);
            this.t_listInput.Name = "t_listInput";
            this.t_listInput.Size = new System.Drawing.Size(100, 21);
            this.t_listInput.TabIndex = 6;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 345);
            this.Controls.Add(this.t_listInput);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_creat);
            this.Controls.Add(this.c_list);
            this.Controls.Add(this.t_cheakPassword);
            this.Controls.Add(this.t_inputPassword);
            this.Controls.Add(this.t_inputId);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_inputId;
        private System.Windows.Forms.TextBox t_inputPassword;
        private System.Windows.Forms.TextBox t_cheakPassword;
        private System.Windows.Forms.ComboBox c_list;
        private System.Windows.Forms.Button b_creat;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.TextBox t_listInput;
    }
}