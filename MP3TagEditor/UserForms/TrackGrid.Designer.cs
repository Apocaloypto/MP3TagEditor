namespace MP3TagEditor.UserForms
{
   partial class TrackGrid
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
         this.gridSongs = new System.Windows.Forms.DataGridView();
         this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colOldFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colTrackname = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colNewFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.gridSongs)).BeginInit();
         this.SuspendLayout();
         // 
         // gridSongs
         // 
         this.gridSongs.AllowUserToAddRows = false;
         this.gridSongs.AllowUserToDeleteRows = false;
         this.gridSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.gridSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gridSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colOldFilename,
            this.colTrackname,
            this.colNewFilename});
         this.gridSongs.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridSongs.Location = new System.Drawing.Point(0, 0);
         this.gridSongs.Name = "gridSongs";
         this.gridSongs.RowTemplate.Height = 25;
         this.gridSongs.Size = new System.Drawing.Size(709, 275);
         this.gridSongs.TabIndex = 0;
         this.gridSongs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEndEdit);
         // 
         // colNo
         // 
         this.colNo.FillWeight = 101.5228F;
         this.colNo.HeaderText = "#";
         this.colNo.Name = "colNo";
         this.colNo.ReadOnly = true;
         // 
         // colOldFilename
         // 
         this.colOldFilename.FillWeight = 99.49239F;
         this.colOldFilename.HeaderText = "Original Filename";
         this.colOldFilename.Name = "colOldFilename";
         this.colOldFilename.ReadOnly = true;
         // 
         // colTrackname
         // 
         this.colTrackname.FillWeight = 99.49239F;
         this.colTrackname.HeaderText = "Trackname";
         this.colTrackname.Name = "colTrackname";
         // 
         // colNewFilename
         // 
         this.colNewFilename.FillWeight = 99.49239F;
         this.colNewFilename.HeaderText = "New Filename";
         this.colNewFilename.Name = "colNewFilename";
         this.colNewFilename.ReadOnly = true;
         // 
         // TrackGrid
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.gridSongs);
         this.Name = "TrackGrid";
         this.Size = new System.Drawing.Size(709, 275);
         ((System.ComponentModel.ISupportInitialize)(this.gridSongs)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DataGridView gridSongs;
      private DataGridViewTextBoxColumn colNo;
      private DataGridViewTextBoxColumn colOldFilename;
      private DataGridViewTextBoxColumn colTrackname;
      private DataGridViewTextBoxColumn colNewFilename;
   }
}
