namespace DoBackup
{
  partial class ParamsForm
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
      this.btnSalvar = new System.Windows.Forms.Button();
      this.btnCarregar = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnSalvar
      // 
      this.btnSalvar.Location = new System.Drawing.Point(495, 556);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(75, 23);
      this.btnSalvar.TabIndex = 0;
      this.btnSalvar.Text = "&Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // btnCarregar
      // 
      this.btnCarregar.Location = new System.Drawing.Point(16, 556);
      this.btnCarregar.Name = "btnCarregar";
      this.btnCarregar.Size = new System.Drawing.Size(75, 23);
      this.btnCarregar.TabIndex = 1;
      this.btnCarregar.Text = "&Carregar";
      this.btnCarregar.UseVisualStyleBackColor = true;
      this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(558, 538);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(550, 512);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // ParamsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 591);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.btnCarregar);
      this.Controls.Add(this.btnSalvar);
      this.Name = "ParamsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ParamsForm";
      this.tabControl1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.Button btnCarregar;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
  }
}