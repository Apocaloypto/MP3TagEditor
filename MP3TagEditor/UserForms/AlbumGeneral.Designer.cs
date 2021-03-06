namespace MP3TagEditor.UserForms
{
   partial class AlbumGeneral
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
         this.label2 = new System.Windows.Forms.Label();
         this.tbxArtist = new System.Windows.Forms.TextBox();
         this.tbxAlbum = new System.Windows.Forms.TextBox();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 4;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.tbxArtist, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.tbxAlbum, 3, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 27);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label1.Location = new System.Drawing.Point(3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(94, 27);
         this.label1.TabIndex = 0;
         this.label1.Text = "Artist:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label2
         // 
         this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label2.Location = new System.Drawing.Point(324, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(94, 27);
         this.label2.TabIndex = 1;
         this.label2.Text = "Album:";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // tbxArtist
         // 
         this.tbxArtist.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxArtist.Location = new System.Drawing.Point(103, 3);
         this.tbxArtist.Name = "tbxArtist";
         this.tbxArtist.Size = new System.Drawing.Size(215, 23);
         this.tbxArtist.TabIndex = 2;
         // 
         // tbxAlbum
         // 
         this.tbxAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxAlbum.Location = new System.Drawing.Point(424, 3);
         this.tbxAlbum.Name = "tbxAlbum";
         this.tbxAlbum.Size = new System.Drawing.Size(216, 23);
         this.tbxAlbum.TabIndex = 3;
         // 
         // AlbumGeneral
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "AlbumGeneral";
         this.Size = new System.Drawing.Size(643, 27);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private TableLayoutPanel tableLayoutPanel1;
      private Label label1;
      private Label label2;
      private TextBox tbxArtist;
      private TextBox tbxAlbum;
   }
}
