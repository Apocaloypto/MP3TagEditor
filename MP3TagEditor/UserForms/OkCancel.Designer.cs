namespace MP3TagEditor.UserForms
{
   partial class OkCancel
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnQuit = new System.Windows.Forms.Button();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 3;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.btnQuit, 2, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 29);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // btnSave
         // 
         this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btnSave.Location = new System.Drawing.Point(511, 3);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(94, 23);
         this.btnSave.TabIndex = 0;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.OnClickedSave);
         // 
         // btnQuit
         // 
         this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btnQuit.Location = new System.Drawing.Point(611, 3);
         this.btnQuit.Name = "btnQuit";
         this.btnQuit.Size = new System.Drawing.Size(94, 23);
         this.btnQuit.TabIndex = 1;
         this.btnQuit.Text = "Quit";
         this.btnQuit.UseVisualStyleBackColor = true;
         this.btnQuit.Click += new System.EventHandler(this.OnClickedQuit);
         // 
         // OkCancel
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "OkCancel";
         this.Size = new System.Drawing.Size(708, 29);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private TableLayoutPanel tableLayoutPanel1;
      private Button btnSave;
      private Button btnQuit;
   }
}
