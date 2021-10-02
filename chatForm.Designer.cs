
namespace kokonut
{
    partial class chatForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.l_userList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_send = new System.Windows.Forms.Button();
            this.b_exitChat = new System.Windows.Forms.Button();
            this.g_chat = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.g_chat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(4, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 316);
            this.listBox1.TabIndex = 0;
            // 
            // l_userList
            // 
            this.l_userList.FormattingEnabled = true;
            this.l_userList.ItemHeight = 12;
            this.l_userList.Location = new System.Drawing.Point(5, 17);
            this.l_userList.Name = "l_userList";
            this.l_userList.Size = new System.Drawing.Size(140, 316);
            this.l_userList.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 21);
            this.textBox1.TabIndex = 2;
            // 
            // b_send
            // 
            this.b_send.Location = new System.Drawing.Point(327, 340);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(38, 23);
            this.b_send.TabIndex = 3;
            this.b_send.Text = "전송";
            this.b_send.UseVisualStyleBackColor = true;
            // 
            // b_exitChat
            // 
            this.b_exitChat.Location = new System.Drawing.Point(5, 342);
            this.b_exitChat.Name = "b_exitChat";
            this.b_exitChat.Size = new System.Drawing.Size(139, 23);
            this.b_exitChat.TabIndex = 4;
            this.b_exitChat.Text = "채팅방 나가기";
            this.b_exitChat.UseVisualStyleBackColor = true;
            this.b_exitChat.Click += new System.EventHandler(this.b_exitChat_Click);
            // 
            // g_chat
            // 
            this.g_chat.Controls.Add(this.l_userList);
            this.g_chat.Controls.Add(this.b_exitChat);
            this.g_chat.Location = new System.Drawing.Point(12, 12);
            this.g_chat.Name = "g_chat";
            this.g_chat.Size = new System.Drawing.Size(150, 371);
            this.g_chat.TabIndex = 5;
            this.g_chat.TabStop = false;
            this.g_chat.Text = "채팅방";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.b_send);
            this.groupBox1.Location = new System.Drawing.Point(168, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 371);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "채팅";
            // 
            // chatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.g_chat);
            this.Name = "chatForm";
            this.Text = "chatForm";
            this.g_chat.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox l_userList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_send;
        private System.Windows.Forms.Button b_exitChat;
        private System.Windows.Forms.GroupBox g_chat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}