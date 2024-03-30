namespace NetSimpleGUI
{
    partial class Form1
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
            this.getValueBtn = new System.Windows.Forms.Button();
            this.lblContractValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.privateKeyInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apiLinkInput = new System.Windows.Forms.TextBox();
            this.txHashLbl = new System.Windows.Forms.Label();
            this.setValueBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.setValueInput = new System.Windows.Forms.TextBox();
            this.getPKeyAPI = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getValueBtn
            // 
            this.getValueBtn.Location = new System.Drawing.Point(44, 213);
            this.getValueBtn.Name = "getValueBtn";
            this.getValueBtn.Size = new System.Drawing.Size(143, 23);
            this.getValueBtn.TabIndex = 0;
            this.getValueBtn.Text = "Get Value From Contract";
            this.getValueBtn.UseVisualStyleBackColor = true;
            this.getValueBtn.Click += new System.EventHandler(this.getValueBtn_Click);
            // 
            // lblContractValue
            // 
            this.lblContractValue.AutoSize = true;
            this.lblContractValue.Location = new System.Drawing.Point(41, 249);
            this.lblContractValue.Name = "lblContractValue";
            this.lblContractValue.Size = new System.Drawing.Size(106, 13);
            this.lblContractValue.TabIndex = 1;
            this.lblContractValue.Text = "Value from Contract: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your private key:";
            // 
            // privateKeyInput
            // 
            this.privateKeyInput.Location = new System.Drawing.Point(160, 12);
            this.privateKeyInput.Name = "privateKeyInput";
            this.privateKeyInput.Size = new System.Drawing.Size(301, 20);
            this.privateKeyInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your API link: ";
            // 
            // apiLinkInput
            // 
            this.apiLinkInput.Location = new System.Drawing.Point(160, 48);
            this.apiLinkInput.Name = "apiLinkInput";
            this.apiLinkInput.Size = new System.Drawing.Size(301, 20);
            this.apiLinkInput.TabIndex = 5;
            // 
            // txHashLbl
            // 
            this.txHashLbl.Location = new System.Drawing.Point(41, 399);
            this.txHashLbl.Name = "txHashLbl";
            this.txHashLbl.Size = new System.Drawing.Size(420, 18);
            this.txHashLbl.TabIndex = 0;
            this.txHashLbl.Text = "Transaction Hash: ";
            // 
            // setValueBtn
            // 
            this.setValueBtn.Location = new System.Drawing.Point(296, 361);
            this.setValueBtn.Name = "setValueBtn";
            this.setValueBtn.Size = new System.Drawing.Size(152, 23);
            this.setValueBtn.TabIndex = 6;
            this.setValueBtn.Text = "Call setValue Function";
            this.setValueBtn.UseVisualStyleBackColor = true;
            this.setValueBtn.Click += new System.EventHandler(this.setValueBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter value to be set: ";
            // 
            // setValueInput
            // 
            this.setValueInput.Location = new System.Drawing.Point(165, 363);
            this.setValueInput.Name = "setValueInput";
            this.setValueInput.Size = new System.Drawing.Size(83, 20);
            this.setValueInput.TabIndex = 8;
            // 
            // getPKeyAPI
            // 
            this.getPKeyAPI.Location = new System.Drawing.Point(84, 83);
            this.getPKeyAPI.Name = "getPKeyAPI";
            this.getPKeyAPI.Size = new System.Drawing.Size(213, 23);
            this.getPKeyAPI.TabIndex = 9;
            this.getPKeyAPI.Text = "Submit PrivateKey and API Link";
            this.getPKeyAPI.UseVisualStyleBackColor = true;
            this.getPKeyAPI.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(698, 415);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(90, 23);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit Program";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.getPKeyAPI);
            this.Controls.Add(this.setValueInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setValueBtn);
            this.Controls.Add(this.txHashLbl);
            this.Controls.Add(this.apiLinkInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.privateKeyInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContractValue);
            this.Controls.Add(this.getValueBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getValueBtn;
        private System.Windows.Forms.Label lblContractValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox privateKeyInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apiLinkInput;
        private System.Windows.Forms.Label txHashLbl;
        private System.Windows.Forms.Button setValueBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox setValueInput;
        private System.Windows.Forms.Button getPKeyAPI;
        private System.Windows.Forms.Button exitBtn;
    }
}

