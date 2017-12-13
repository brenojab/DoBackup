namespace DoBackup
{
  partial class Main
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
      this.btnBkpNuvem = new System.Windows.Forms.Button();
      this.txtLog = new System.Windows.Forms.TextBox();
      this.btnGeraBKPCliente = new System.Windows.Forms.Button();
      this.btnBKPFtp = new System.Windows.Forms.Button();
      this.txtGUIDCliente = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtFTPCliente = new System.Windows.Forms.TextBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.btnParams = new System.Windows.Forms.Button();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnBkpNuvem
      // 
      this.btnBkpNuvem.Location = new System.Drawing.Point(12, 12);
      this.btnBkpNuvem.Name = "btnBkpNuvem";
      this.btnBkpNuvem.Size = new System.Drawing.Size(75, 23);
      this.btnBkpNuvem.TabIndex = 0;
      this.btnBkpNuvem.Text = "BKP Nuvem";
      this.btnBkpNuvem.UseVisualStyleBackColor = true;
      this.btnBkpNuvem.Click += new System.EventHandler(this.btnBKPNuvem_Click);
      // 
      // txtLog
      // 
      this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtLog.Location = new System.Drawing.Point(12, 159);
      this.txtLog.Multiline = true;
      this.txtLog.Name = "txtLog";
      this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtLog.Size = new System.Drawing.Size(529, 385);
      this.txtLog.TabIndex = 1;
      this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
      // 
      // btnGeraBKPCliente
      // 
      this.btnGeraBKPCliente.Location = new System.Drawing.Point(106, 12);
      this.btnGeraBKPCliente.Name = "btnGeraBKPCliente";
      this.btnGeraBKPCliente.Size = new System.Drawing.Size(75, 23);
      this.btnGeraBKPCliente.TabIndex = 2;
      this.btnGeraBKPCliente.Text = "BKP Cliente";
      this.btnGeraBKPCliente.UseVisualStyleBackColor = true;
      this.btnGeraBKPCliente.Click += new System.EventHandler(this.btnGeraBKPCliente_Click);
      // 
      // btnBKPFtp
      // 
      this.btnBKPFtp.Location = new System.Drawing.Point(197, 12);
      this.btnBKPFtp.Name = "btnBKPFtp";
      this.btnBKPFtp.Size = new System.Drawing.Size(75, 23);
      this.btnBKPFtp.TabIndex = 3;
      this.btnBKPFtp.Text = "BKP FTP";
      this.btnBKPFtp.UseVisualStyleBackColor = true;
      this.btnBKPFtp.Click += new System.EventHandler(this.btnBKPFtp_Click);
      // 
      // txtGUIDCliente
      // 
      this.txtGUIDCliente.Location = new System.Drawing.Point(12, 81);
      this.txtGUIDCliente.Name = "txtGUIDCliente";
      this.txtGUIDCliente.Size = new System.Drawing.Size(529, 20);
      this.txtGUIDCliente.TabIndex = 4;
      this.txtGUIDCliente.Text = "TOTVSDEVBATISTA";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 65);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "GUID:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 143);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Log:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 104);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "FTP Cliente:";
      // 
      // txtFTPCliente
      // 
      this.txtFTPCliente.Location = new System.Drawing.Point(12, 120);
      this.txtFTPCliente.Name = "txtFTPCliente";
      this.txtFTPCliente.Size = new System.Drawing.Size(529, 20);
      this.txtFTPCliente.TabIndex = 7;
      this.txtFTPCliente.Text = "C:\\sqlFTPClientBackup";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
      this.statusStrip1.Location = new System.Drawing.Point(0, 601);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(553, 22);
      this.statusStrip1.TabIndex = 9;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tssStatus
      // 
      this.tssStatus.Name = "tssStatus";
      this.tssStatus.Size = new System.Drawing.Size(134, 17);
      this.tssStatus.Text = "Aguardando execução...";
      // 
      // btnParams
      // 
      this.btnParams.Location = new System.Drawing.Point(466, 12);
      this.btnParams.Name = "btnParams";
      this.btnParams.Size = new System.Drawing.Size(75, 23);
      this.btnParams.TabIndex = 10;
      this.btnParams.Text = "Params";
      this.btnParams.UseVisualStyleBackColor = true;
      this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(553, 623);
      this.Controls.Add(this.btnParams);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtFTPCliente);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtGUIDCliente);
      this.Controls.Add(this.btnBKPFtp);
      this.Controls.Add(this.btnGeraBKPCliente);
      this.Controls.Add(this.txtLog);
      this.Controls.Add(this.btnBkpNuvem);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Main";
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnBkpNuvem;
    private System.Windows.Forms.TextBox txtLog;
    private System.Windows.Forms.Button btnGeraBKPCliente;
    private System.Windows.Forms.Button btnBKPFtp;
    private System.Windows.Forms.TextBox txtGUIDCliente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtFTPCliente;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tssStatus;
    private System.Windows.Forms.Button btnParams;
  }
}

