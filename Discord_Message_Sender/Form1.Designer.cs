
namespace Discord_Message_Sender
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.WebHook = new System.Windows.Forms.TextBox();
            this.BotName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InfoSendView = new System.Windows.Forms.Label();
            this.avatar_Box = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.avatar_url_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(482, 254);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discord Message Sender";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(12, 172);
            this.Message.MaxLength = 2000;
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message.Size = new System.Drawing.Size(367, 105);
            this.Message.TabIndex = 2;
            // 
            // WebHook
            // 
            this.WebHook.AccessibleDescription = "";
            this.WebHook.AccessibleName = "";
            this.WebHook.AutoCompleteCustomSource.AddRange(new string[] {
            "asd"});
            this.WebHook.Location = new System.Drawing.Point(99, 72);
            this.WebHook.Name = "WebHook";
            this.WebHook.Size = new System.Drawing.Size(100, 20);
            this.WebHook.TabIndex = 3;
            this.WebHook.Tag = "";
            // 
            // BotName
            // 
            this.BotName.Location = new System.Drawing.Point(99, 98);
            this.BotName.Name = "BotName";
            this.BotName.Size = new System.Drawing.Size(100, 20);
            this.BotName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "WebHook\r\nDiscord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bot Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message: ";
            // 
            // InfoSendView
            // 
            this.InfoSendView.AutoSize = true;
            this.InfoSendView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InfoSendView.ForeColor = System.Drawing.Color.Orange;
            this.InfoSendView.Location = new System.Drawing.Point(479, 227);
            this.InfoSendView.Name = "InfoSendView";
            this.InfoSendView.Size = new System.Drawing.Size(0, 13);
            this.InfoSendView.TabIndex = 8;
            // 
            // avatar_Box
            // 
            this.avatar_Box.Location = new System.Drawing.Point(448, 65);
            this.avatar_Box.Name = "avatar_Box";
            this.avatar_Box.Size = new System.Drawing.Size(109, 104);
            this.avatar_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar_Box.TabIndex = 10;
            this.avatar_Box.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Avatar:";
            // 
            // avatar_url_box
            // 
            this.avatar_url_box.Location = new System.Drawing.Point(99, 124);
            this.avatar_url_box.Name = "avatar_url_box";
            this.avatar_url_box.Size = new System.Drawing.Size(100, 20);
            this.avatar_url_box.TabIndex = 12;
            this.avatar_url_box.TextChanged += new System.EventHandler(this.avatar_url_box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Avatar URL";
            // 
            // Form1
            // 
            this.AcceptButton = this.SendButton;
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 289);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.avatar_url_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.avatar_Box);
            this.Controls.Add(this.InfoSendView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotName);
            this.Controls.Add(this.WebHook);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Tag = "";
            this.Text = "Discord Message Sender";
            ((System.ComponentModel.ISupportInitialize)(this.avatar_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.TextBox WebHook;
        private System.Windows.Forms.TextBox BotName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label InfoSendView;
        private System.Windows.Forms.PictureBox avatar_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox avatar_url_box;
        private System.Windows.Forms.Label label6;
    }
}

