
namespace Awesomeness
{
    partial class formAwesomeness
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
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonLeftNo = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonRightNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(33, 180);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(131, 40);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "&Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonLeftNo
            // 
            this.buttonLeftNo.Location = new System.Drawing.Point(170, 180);
            this.buttonLeftNo.Name = "buttonLeftNo";
            this.buttonLeftNo.Size = new System.Drawing.Size(131, 40);
            this.buttonLeftNo.TabIndex = 1;
            this.buttonLeftNo.Text = "&No";
            this.buttonLeftNo.UseVisualStyleBackColor = true;
            this.buttonLeftNo.VisibleChanged += new System.EventHandler(this.buttonLeftNo_Cck);
            this.buttonLeftNo.Click += new System.EventHandler(this.buttonLeftNo_Click);
            this.buttonLeftNo.MouseEnter += new System.EventHandler(this.buttonLeftNo_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(67, 38);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(350, 90);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "The computer has detected that you\r\nare awesome. Is it possible that you\r\nare awe" +
    "some?";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRightNo
            // 
            this.buttonRightNo.Location = new System.Drawing.Point(307, 180);
            this.buttonRightNo.Name = "buttonRightNo";
            this.buttonRightNo.Size = new System.Drawing.Size(131, 40);
            this.buttonRightNo.TabIndex = 3;
            this.buttonRightNo.Text = "&No";
            this.buttonRightNo.UseVisualStyleBackColor = true;
            this.buttonRightNo.Visible = false;
            this.buttonRightNo.Click += new System.EventHandler(this.buttonRightNo_Click);
            this.buttonRightNo.MouseEnter += new System.EventHandler(this.buttonRightNo_Click);
            // 
            // formAwesomeness
            // 
            this.AcceptButton = this.buttonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 264);
            this.Controls.Add(this.buttonRightNo);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonLeftNo);
            this.Controls.Add(this.buttonYes);
            this.Name = "formAwesomeness";
            this.Text = "Awesomeness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonLeftNo;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonRightNo;
    }
}

