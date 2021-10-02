
namespace kokonut
{
    partial class login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_openRegister = new System.Windows.Forms.Label();
            this.t_idInput = new System.Windows.Forms.TextBox();
            this.t_passwordInput = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_openRegister
            // 
            this.l_openRegister.AutoSize = true;
            this.l_openRegister.Location = new System.Drawing.Point(172, 147);
            this.l_openRegister.Name = "l_openRegister";
            this.l_openRegister.Size = new System.Drawing.Size(53, 12);
            this.l_openRegister.TabIndex = 0;
            this.l_openRegister.Text = "회원가입";
            this.l_openRegister.Click += new System.EventHandler(this.l_openRegister_Click);
            // 
            // t_idInput
            // 
            this.t_idInput.Location = new System.Drawing.Point(183, 40);
            this.t_idInput.Name = "t_idInput";
            this.t_idInput.Size = new System.Drawing.Size(100, 21);
            this.t_idInput.TabIndex = 1;
            // 
            // t_passwordInput
            // 
            this.t_passwordInput.Location = new System.Drawing.Point(183, 67);
            this.t_passwordInput.Name = "t_passwordInput";
            this.t_passwordInput.Size = new System.Drawing.Size(100, 21);
            this.t_passwordInput.TabIndex = 2;
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(174, 251);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(75, 23);
            this.b_login.TabIndex = 3;
            this.b_login.Text = "button1";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(255, 251);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(75, 23);
            this.b_exit.TabIndex = 4;
            this.b_exit.Text = "button2";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 364);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.t_passwordInput);
            this.Controls.Add(this.t_idInput);
            this.Controls.Add(this.l_openRegister);
            this.Name = "login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_openRegister;
        private System.Windows.Forms.TextBox t_passwordInput;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Button b_exit;
        public System.Windows.Forms.TextBox t_idInput;
    }
}

