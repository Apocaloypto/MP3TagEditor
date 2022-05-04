namespace MP3TagEditor.UserForms
{
   partial class DirectorySelector
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
         this.label1 = new System.Windows.Forms.Label();
         this.tbxDir = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 3;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.tbxDir, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 27);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label1.Location = new System.Drawing.Point(3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(94, 27);
         this.label1.TabIndex = 0;
         this.label1.Text = "Directory:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // tbxDir
         // 
         this.tbxDir.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxDir.Location = new System.Drawing.Point(103, 3);
         this.tbxDir.Name = "tbxDir";
         this.tbxDir.ReadOnly = true;
         this.tbxDir.Size = new System.Drawing.Size(647, 23);
         this.tbxDir.TabIndex = 1;
         this.tbxDir.Click += new System.EventHandler(this.OnSearchFileClicked);
         // 
         // button1
         // 
         this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.button1.Location = new System.Drawing.Point(756, 3);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(24, 21);
         this.button1.TabIndex = 2;
         this.button1.Text = "...";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.OnSearchFileClicked);
         // 
         // DirectorySelector
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "DirectorySelector";
         this.Size = new System.Drawing.Size(783, 27);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private TableLayoutPanel tableLayoutPanel1;
      private Label label1;
      private TextBox tbxDir;
      private Button button1;
   }
}
