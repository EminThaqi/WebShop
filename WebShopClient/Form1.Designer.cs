namespace WebShopClient
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
            this.btn_getName = new System.Windows.Forms.Button();
            this.btn_getInventory = new System.Windows.Forms.Button();
            this.txtBox_itemName = new System.Windows.Forms.TextBox();
            this.btn_buy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_getName
            // 
            this.btn_getName.Location = new System.Drawing.Point(15, 72);
            this.btn_getName.Name = "btn_getName";
            this.btn_getName.Size = new System.Drawing.Size(100, 23);
            this.btn_getName.TabIndex = 0;
            this.btn_getName.Text = "get name";
            this.btn_getName.UseVisualStyleBackColor = true;
            this.btn_getName.Click += new System.EventHandler(this.btn_getName_Click);
            // 
            // btn_getInventory
            // 
            this.btn_getInventory.Location = new System.Drawing.Point(15, 115);
            this.btn_getInventory.Name = "btn_getInventory";
            this.btn_getInventory.Size = new System.Drawing.Size(100, 23);
            this.btn_getInventory.TabIndex = 2;
            this.btn_getInventory.Text = "get inventory";
            this.btn_getInventory.UseVisualStyleBackColor = true;
            this.btn_getInventory.Click += new System.EventHandler(this.btn_getInventory_Click);
            // 
            // txtBox_itemName
            // 
            this.txtBox_itemName.Location = new System.Drawing.Point(15, 175);
            this.txtBox_itemName.Name = "txtBox_itemName";
            this.txtBox_itemName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_itemName.TabIndex = 3;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(137, 172);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(75, 23);
            this.btn_buy.TabIndex = 4;
            this.btn_buy.Text = "buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.txtBox_itemName);
            this.Controls.Add(this.btn_getInventory);
            this.Controls.Add(this.btn_getName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getName;
        private System.Windows.Forms.Button btn_getInventory;
        private System.Windows.Forms.TextBox txtBox_itemName;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

