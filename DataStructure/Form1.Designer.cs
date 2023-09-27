namespace DataStructure
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSendPassword = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlInfoData = new System.Windows.Forms.Panel();
            this.lblInfoIndex = new System.Windows.Forms.Label();
            this.pnlIndex = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlInfoData.SuspendLayout();
            this.pnlIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "#NAME";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(25, 4);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(242, 24);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Escribe tu contraseña.";
            // 
            // btnSendPassword
            // 
            this.btnSendPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSendPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSendPassword.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPassword.Location = new System.Drawing.Point(63, 90);
            this.btnSendPassword.Name = "btnSendPassword";
            this.btnSendPassword.Size = new System.Drawing.Size(156, 32);
            this.btnSendPassword.TabIndex = 3;
            this.btnSendPassword.Text = "Enviar";
            this.btnSendPassword.UseVisualStyleBackColor = false;
            this.btnSendPassword.Click += new System.EventHandler(this.btnSendPassword_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pnlInfoData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlIndex);
            this.splitContainer1.Size = new System.Drawing.Size(702, 324);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 4;
            // 
            // pnlInfoData
            // 
            this.pnlInfoData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfoData.AutoScroll = true;
            this.pnlInfoData.Controls.Add(this.lblInfoIndex);
            this.pnlInfoData.Controls.Add(this.lblName);
            this.pnlInfoData.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInfoData.Location = new System.Drawing.Point(4, 4);
            this.pnlInfoData.Name = "pnlInfoData";
            this.pnlInfoData.Size = new System.Drawing.Size(395, 303);
            this.pnlInfoData.TabIndex = 0;
            this.pnlInfoData.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblInfoIndex
            // 
            this.lblInfoIndex.AutoSize = true;
            this.lblInfoIndex.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIndex.Location = new System.Drawing.Point(8, 47);
            this.lblInfoIndex.Name = "lblInfoIndex";
            this.lblInfoIndex.Size = new System.Drawing.Size(71, 24);
            this.lblInfoIndex.TabIndex = 1;
            this.lblInfoIndex.Text = "label1";
            // 
            // pnlIndex
            // 
            this.pnlIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIndex.Controls.Add(this.txtPassword);
            this.pnlIndex.Controls.Add(this.lblInfo);
            this.pnlIndex.Controls.Add(this.btnSendPassword);
            this.pnlIndex.Location = new System.Drawing.Point(3, 12);
            this.pnlIndex.Name = "pnlIndex";
            this.pnlIndex.Size = new System.Drawing.Size(293, 135);
            this.pnlIndex.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(73, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 324);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos 301305 - Aire Tour";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlInfoData.ResumeLayout(false);
            this.pnlInfoData.PerformLayout();
            this.pnlIndex.ResumeLayout(false);
            this.pnlIndex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSendPassword;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlIndex;
        private System.Windows.Forms.Panel pnlInfoData;
        private System.Windows.Forms.Label lblInfoIndex;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

