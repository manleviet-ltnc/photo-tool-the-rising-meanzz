namespace MyAlbumEditor
{
    partial class EditorForm
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
            this.grpAlbums = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbAlbums = new System.Windows.Forms.ComboBox();
            this.btnAlbumProps = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
            this.tcPhotos = new System.Windows.Forms.TabControl();
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.tcPhotos = new System.Windows.Forms.TabControl();
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.tcPhotos = new System.Windows.Forms.TabControl();
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.pagePhotos = new System.Windows.Forms.TabPage();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnPhotoProps = new System.Windows.Forms.Button();
            this.lstPhotos = new System.Windows.Forms.ListBox();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.tcPhotos = new System.Windows.Forms.TabControl();
            this.pageDates = new System.Windows.Forms.TabPage();
            this.albCalendar = new MyAlbumEditor.AlbumCalendar();
            this.pageImages = new System.Windows.Forms.TabPage();
            this.albumImages = new MyAlbumEditor.AlbumImage();
            this.grpAlbums.SuspendLayout();
            this.pagePhotos.SuspendLayout();
            this.tcPhotos.SuspendLayout();
            this.pageDates.SuspendLayout();
            this.pageImages.SuspendLayout();
=======
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.pageDates = new System.Windows.Forms.TabPage();
            this.albCalendar = new MyAlbumEditor.AlbumCalendar();
            this.grpAlbums.SuspendLayout();
            this.tcPhotos.SuspendLayout();
            this.pagePhotos.SuspendLayout();
            this.pageDates.SuspendLayout();
<<<<<<< HEAD
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.pageDates = new System.Windows.Forms.TabPage();
            this.albCalendar = new MyAlbumEditor.AlbumCalendar();
            this.grpAlbums.SuspendLayout();
            this.tcPhotos.SuspendLayout();
            this.pagePhotos.SuspendLayout();
            this.pageDates.SuspendLayout();
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.SuspendLayout();
            // 
            // grpAlbums
            // 
            this.grpAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAlbums.Controls.Add(this.btnBrowse);
            this.grpAlbums.Controls.Add(this.cmbAlbums);
            this.grpAlbums.Controls.Add(this.btnAlbumProps);
            this.grpAlbums.Location = new System.Drawing.Point(16, 15);
            this.grpAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAlbums.Name = "grpAlbums";
            this.grpAlbums.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAlbums.Size = new System.Drawing.Size(480, 62);
            this.grpAlbums.TabIndex = 0;
            this.grpAlbums.TabStop = false;
            this.grpAlbums.Text = "&Albums";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnBrowse.Location = new System.Drawing.Point(194, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
=======
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.btnBrowse.Location = new System.Drawing.Point(259, 22);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbAlbums
            // 
            this.cmbAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlbums.DropDownWidth = 400;
            this.cmbAlbums.FormattingEnabled = true;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.cmbAlbums.Location = new System.Drawing.Point(6, 19);
            this.cmbAlbums.Name = "cmbAlbums";
            this.cmbAlbums.Size = new System.Drawing.Size(182, 21);
=======
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.cmbAlbums.Location = new System.Drawing.Point(8, 23);
            this.cmbAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAlbums.Name = "cmbAlbums";
            this.cmbAlbums.Size = new System.Drawing.Size(241, 24);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.cmbAlbums.TabIndex = 2;
            this.cmbAlbums.SelectionChangeCommitted += new System.EventHandler(this.cmbAlbums_SelectionChangeCommitted);
            // 
            // btnAlbumProps
            // 
            this.btnAlbumProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlbumProps.Enabled = false;
            this.btnAlbumProps.Location = new System.Drawing.Point(368, 23);
            this.btnAlbumProps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlbumProps.Name = "btnAlbumProps";
            this.btnAlbumProps.Size = new System.Drawing.Size(100, 28);
            this.btnAlbumProps.TabIndex = 1;
            this.btnAlbumProps.Text = "Propertie&s";
            this.btnAlbumProps.UseVisualStyleBackColor = true;
            this.btnAlbumProps.Click += new System.EventHandler(this.btnAlbumProps_Click);
            // 
            // btnClose
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(154, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
=======
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(205, 278);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
<<<<<<< HEAD
=======
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(205, 278);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcPhotos
            // 
=======
            // 
            // tcPhotos
            // 
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.tcPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPhotos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcPhotos.Controls.Add(this.pagePhotos);
            this.tcPhotos.Controls.Add(this.pageDates);
            this.tcPhotos.Location = new System.Drawing.Point(24, 94);
            this.tcPhotos.Name = "tcPhotos";
            this.tcPhotos.SelectedIndex = 0;
            this.tcPhotos.Size = new System.Drawing.Size(460, 166);
            this.tcPhotos.TabIndex = 3;
            this.tcPhotos.SelectedIndexChanged += new System.EventHandler(this.tcPhotos_SelectedIndexChanged);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            // 
            // pagePhotos
            // 
            this.pagePhotos.Controls.Add(this.btnMoveDown);
            this.pagePhotos.Controls.Add(this.btnRemove);
            this.pagePhotos.Controls.Add(this.btnMoveUp);
            this.pagePhotos.Controls.Add(this.btnPhotoProps);
            this.pagePhotos.Controls.Add(this.lstPhotos);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.pagePhotos.Location = new System.Drawing.Point(4, 25);
            this.pagePhotos.Name = "pagePhotos";
            this.pagePhotos.Padding = new System.Windows.Forms.Padding(3);
            this.pagePhotos.Size = new System.Drawing.Size(343, 122);
=======
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.pagePhotos.Location = new System.Drawing.Point(4, 28);
            this.pagePhotos.Name = "pagePhotos";
            this.pagePhotos.Padding = new System.Windows.Forms.Padding(3);
            this.pagePhotos.Size = new System.Drawing.Size(452, 134);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.pagePhotos.TabIndex = 0;
            this.pagePhotos.Text = "Photos";
            this.pagePhotos.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnMoveDown.Location = new System.Drawing.Point(269, 36);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
=======
            this.btnMoveDown.Location = new System.Drawing.Point(356, 36);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.btnMoveDown.Location = new System.Drawing.Point(356, 36);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.btnMoveDown.Location = new System.Drawing.Point(356, 36);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.btnMoveDown.TabIndex = 9;
            this.btnMoveDown.Text = "Move &Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnRemove
            // 
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnRemove.Location = new System.Drawing.Point(269, 65);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
=======
            this.btnRemove.Location = new System.Drawing.Point(356, 72);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.btnRemove.Location = new System.Drawing.Point(356, 72);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.btnRemove.Location = new System.Drawing.Point(356, 72);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnMoveUp.Location = new System.Drawing.Point(269, 7);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
=======
            this.btnMoveUp.Location = new System.Drawing.Point(356, 1);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.btnMoveUp.Location = new System.Drawing.Point(356, 1);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.btnMoveUp.Location = new System.Drawing.Point(356, 1);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.btnMoveUp.TabIndex = 7;
            this.btnMoveUp.Text = "Move &Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnPhotoProps
            // 
            this.btnPhotoProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnPhotoProps.Location = new System.Drawing.Point(269, 92);
            this.btnPhotoProps.Name = "btnPhotoProps";
            this.btnPhotoProps.Size = new System.Drawing.Size(75, 23);
=======
            this.btnPhotoProps.Location = new System.Drawing.Point(356, 105);
            this.btnPhotoProps.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhotoProps.Name = "btnPhotoProps";
            this.btnPhotoProps.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.btnPhotoProps.Location = new System.Drawing.Point(356, 105);
            this.btnPhotoProps.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhotoProps.Name = "btnPhotoProps";
            this.btnPhotoProps.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.btnPhotoProps.Location = new System.Drawing.Point(356, 105);
            this.btnPhotoProps.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhotoProps.Name = "btnPhotoProps";
            this.btnPhotoProps.Size = new System.Drawing.Size(100, 28);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.btnPhotoProps.TabIndex = 6;
            this.btnPhotoProps.Text = "Properti&es";
            this.btnPhotoProps.UseVisualStyleBackColor = true;
            this.btnPhotoProps.Click += new System.EventHandler(this.btnPhotoProps_Click);
            // 
            // lstPhotos
            // 
            this.lstPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPhotos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstPhotos.FormattingEnabled = true;
            this.lstPhotos.HorizontalScrollbar = true;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.lstPhotos.Location = new System.Drawing.Point(-1, 7);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPhotos.Size = new System.Drawing.Size(264, 108);
=======
            this.lstPhotos.ItemHeight = 16;
            this.lstPhotos.Location = new System.Drawing.Point(-4, 1);
            this.lstPhotos.Margin = new System.Windows.Forms.Padding(4);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPhotos.Size = new System.Drawing.Size(351, 132);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.lstPhotos.ItemHeight = 16;
            this.lstPhotos.Location = new System.Drawing.Point(-4, 1);
            this.lstPhotos.Margin = new System.Windows.Forms.Padding(4);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPhotos.Size = new System.Drawing.Size(351, 132);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.lstPhotos.ItemHeight = 16;
            this.lstPhotos.Location = new System.Drawing.Point(-4, 1);
            this.lstPhotos.Margin = new System.Windows.Forms.Padding(4);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPhotos.Size = new System.Drawing.Size(351, 132);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.lstPhotos.TabIndex = 5;
            this.lstPhotos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPhotos_DrawItem);
            this.lstPhotos.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstPhotos_MeasureItem);
            this.lstPhotos.SelectedIndexChanged += new System.EventHandler(this.lstPhotos_SelectedIndexChanged);
            this.lstPhotos.DoubleClick += new System.EventHandler(this.lstPhotos_DoubleClick);
            // 
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            // tcPhotos
            // 
            this.tcPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPhotos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcPhotos.Controls.Add(this.pagePhotos);
            this.tcPhotos.Controls.Add(this.pageDates);
            this.tcPhotos.Controls.Add(this.pageImages);
            this.tcPhotos.Location = new System.Drawing.Point(12, 69);
            this.tcPhotos.Name = "tcPhotos";
            this.tcPhotos.SelectedIndex = 0;
            this.tcPhotos.Size = new System.Drawing.Size(351, 151);
            this.tcPhotos.TabIndex = 3;
            this.tcPhotos.SelectedIndexChanged += new System.EventHandler(this.tcPhotos_SelectedIndexChanged);
            // 
            // pageDates
            // 
            this.pageDates.Controls.Add(this.albCalendar);
            this.pageDates.Location = new System.Drawing.Point(4, 25);
            this.pageDates.Name = "pageDates";
            this.pageDates.Padding = new System.Windows.Forms.Padding(3);
            this.pageDates.Size = new System.Drawing.Size(343, 122);
=======
            // pageDates
            // 
            this.pageDates.Controls.Add(this.albCalendar);
            this.pageDates.Location = new System.Drawing.Point(4, 28);
            this.pageDates.Name = "pageDates";
            this.pageDates.Padding = new System.Windows.Forms.Padding(3);
            this.pageDates.Size = new System.Drawing.Size(452, 134);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.pageDates.TabIndex = 1;
            this.pageDates.Text = "Dates";
            this.pageDates.UseVisualStyleBackColor = true;
            // 
            // albCalendar
            // 
=======
            // pageDates
            // 
            this.pageDates.Controls.Add(this.albCalendar);
            this.pageDates.Location = new System.Drawing.Point(4, 28);
            this.pageDates.Name = "pageDates";
            this.pageDates.Padding = new System.Windows.Forms.Padding(3);
            this.pageDates.Size = new System.Drawing.Size(452, 134);
            this.pageDates.TabIndex = 1;
            this.pageDates.Text = "Dates";
            this.pageDates.UseVisualStyleBackColor = true;
            // 
            // albCalendar
            // 
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            // pageDates
            // 
            this.pageDates.Controls.Add(this.albCalendar);
            this.pageDates.Location = new System.Drawing.Point(4, 28);
            this.pageDates.Name = "pageDates";
            this.pageDates.Padding = new System.Windows.Forms.Padding(3);
            this.pageDates.Size = new System.Drawing.Size(452, 134);
            this.pageDates.TabIndex = 1;
            this.pageDates.Text = "Dates";
            this.pageDates.UseVisualStyleBackColor = true;
            // 
            // albCalendar
            // 
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.albCalendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.albCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albCalendar.Location = new System.Drawing.Point(3, 3);
            this.albCalendar.Name = "albCalendar";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.albCalendar.Size = new System.Drawing.Size(337, 116);
            this.albCalendar.TabIndex = 0;
            // 
            // pageImages
            // 
            this.pageImages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageImages.Controls.Add(this.albumImages);
            this.pageImages.Location = new System.Drawing.Point(4, 25);
            this.pageImages.Name = "pageImages";
            this.pageImages.Padding = new System.Windows.Forms.Padding(3);
            this.pageImages.Size = new System.Drawing.Size(343, 122);
            this.pageImages.TabIndex = 2;
            this.pageImages.Text = "Images";
            this.pageImages.UseVisualStyleBackColor = true;
            // 
            // albumImages
            // 
            this.albumImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumImages.Location = new System.Drawing.Point(3, 3);
            this.albumImages.Margin = new System.Windows.Forms.Padding(5);
            this.albumImages.Name = "albumImages";
            this.albumImages.Size = new System.Drawing.Size(333, 112);
            this.albumImages.TabIndex = 0;
=======
            this.albCalendar.Size = new System.Drawing.Size(446, 128);
            this.albCalendar.TabIndex = 0;
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.albCalendar.Size = new System.Drawing.Size(446, 128);
            this.albCalendar.TabIndex = 0;
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.albCalendar.Size = new System.Drawing.Size(446, 128);
            this.albCalendar.TabIndex = 0;
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            // 
            // EditorForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(384, 261);
=======
            this.ClientSize = new System.Drawing.Size(512, 321);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.ClientSize = new System.Drawing.Size(512, 321);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.ClientSize = new System.Drawing.Size(512, 321);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.Controls.Add(this.tcPhotos);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpAlbums);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditorForm";
            this.Text = "MyAlbumEditor";
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.grpAlbums.ResumeLayout(false);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.pagePhotos.ResumeLayout(false);
            this.tcPhotos.ResumeLayout(false);
            this.pageDates.ResumeLayout(false);
            this.pageImages.ResumeLayout(false);
=======
            this.tcPhotos.ResumeLayout(false);
            this.pagePhotos.ResumeLayout(false);
            this.pageDates.ResumeLayout(false);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.tcPhotos.ResumeLayout(false);
            this.pagePhotos.ResumeLayout(false);
            this.pageDates.ResumeLayout(false);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
            this.tcPhotos.ResumeLayout(false);
            this.pagePhotos.ResumeLayout(false);
            this.pageDates.ResumeLayout(false);
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlbums;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAlbumProps;
        private System.Windows.Forms.ComboBox cmbAlbums;
        private System.Windows.Forms.Button btnBrowse;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        private System.Windows.Forms.TabControl tcPhotos;
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
        private System.Windows.Forms.TabControl tcPhotos;
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
        private System.Windows.Forms.TabControl tcPhotos;
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
        private System.Windows.Forms.TabPage pagePhotos;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnPhotoProps;
        private System.Windows.Forms.ListBox lstPhotos;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        private System.Windows.Forms.TabControl tcPhotos;
        private System.Windows.Forms.TabPage pageDates;
        private AlbumCalendar albCalendar;
        private System.Windows.Forms.TabPage pageImages;
        private AlbumImage albumImages;
=======
        private System.Windows.Forms.TabPage pageDates;
        private AlbumCalendar albCalendar;
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
        private System.Windows.Forms.TabPage pageDates;
        private AlbumCalendar albCalendar;
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
=======
        private System.Windows.Forms.TabPage pageDates;
        private AlbumCalendar albCalendar;
>>>>>>> 23a8ee08d31b3d98008f39085f027f4aec949a4d
    }
}

