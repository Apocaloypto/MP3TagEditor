namespace MP3TagEditor
{
   partial class Form1
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
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.directorySelector1 = new MP3TagEditor.UserForms.DirectorySelector();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.albumGeneral1 = new MP3TagEditor.UserForms.AlbumGeneral();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.trackGrid1 = new MP3TagEditor.UserForms.TrackGrid();
         this.okCancel1 = new MP3TagEditor.UserForms.OkCancel();
         this.tableLayoutPanel1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.okCancel1, 0, 3);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.directorySelector1);
         this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox1.Location = new System.Drawing.Point(3, 3);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(770, 49);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Directory";
         // 
         // directorySelector1
         // 
         this.directorySelector1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.directorySelector1.Location = new System.Drawing.Point(3, 19);
         this.directorySelector1.Name = "directorySelector1";
         this.directorySelector1.Size = new System.Drawing.Size(764, 27);
         this.directorySelector1.TabIndex = 0;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.albumGeneral1);
         this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox2.Location = new System.Drawing.Point(3, 58);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(770, 49);
         this.groupBox2.TabIndex = 1;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "General Info";
         // 
         // albumGeneral1
         // 
         this.albumGeneral1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.albumGeneral1.Location = new System.Drawing.Point(3, 19);
         this.albumGeneral1.Name = "albumGeneral1";
         this.albumGeneral1.Size = new System.Drawing.Size(764, 27);
         this.albumGeneral1.TabIndex = 0;
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.trackGrid1);
         this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox3.Location = new System.Drawing.Point(3, 113);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(770, 275);
         this.groupBox3.TabIndex = 2;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Songs";
         // 
         // trackGrid1
         // 
         this.trackGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.trackGrid1.Location = new System.Drawing.Point(3, 19);
         this.trackGrid1.Name = "trackGrid1";
         this.trackGrid1.Size = new System.Drawing.Size(764, 253);
         this.trackGrid1.TabIndex = 0;
         // 
         // okCancel1
         // 
         this.okCancel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.okCancel1.Location = new System.Drawing.Point(3, 394);
         this.okCancel1.Name = "okCancel1";
         this.okCancel1.Size = new System.Drawing.Size(770, 29);
         this.okCancel1.TabIndex = 3;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "Form1";
         this.Text = "MP3 Tag Editor";
         this.tableLayoutPanel1.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.groupBox3.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private TableLayoutPanel tableLayoutPanel1;
      private GroupBox groupBox1;
      private GroupBox groupBox2;
      private GroupBox groupBox3;
      private UserForms.DirectorySelector directorySelector1;
      private UserForms.AlbumGeneral albumGeneral1;
      private UserForms.TrackGrid trackGrid1;
      private UserForms.OkCancel okCancel1;
   }
}