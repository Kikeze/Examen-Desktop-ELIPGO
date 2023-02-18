namespace Examen.Desktop
{
    partial class MainForm
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.butClose = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpStores = new System.Windows.Forms.TableLayoutPanel();
            this.butStoreRefresh = new System.Windows.Forms.Button();
            this.butStoreNew = new System.Windows.Forms.Button();
            this.butStoreEdit = new System.Windows.Forms.Button();
            this.butStoreDelete = new System.Windows.Forms.Button();
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpArticles = new System.Windows.Forms.TableLayoutPanel();
            this.butArticleRefresh = new System.Windows.Forms.Button();
            this.butArticleNew = new System.Windows.Forms.Button();
            this.butArticleEdit = new System.Windows.Forms.Button();
            this.butArticleDelete = new System.Windows.Forms.Button();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.lblArticleStore = new System.Windows.Forms.Label();
            this.cmbArticleStore = new System.Windows.Forms.ComboBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlpStores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tlpArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 13;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.Controls.Add(this.butClose, 11, 5);
            this.tlpMain.Controls.Add(this.tabMain, 1, 3);
            this.tlpMain.Controls.Add(this.lblOptions, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.Size = new System.Drawing.Size(1184, 761);
            this.tlpMain.TabIndex = 0;
            // 
            // butClose
            // 
            this.butClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butClose.Location = new System.Drawing.Point(985, 721);
            this.butClose.Margin = new System.Windows.Forms.Padding(0);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(185, 30);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // tabMain
            // 
            this.tlpMain.SetColumnSpan(this.tabMain, 11);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(10, 50);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1160, 661);
            this.tabMain.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlpStores);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1152, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpStores
            // 
            this.tlpStores.ColumnCount = 13;
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.Controls.Add(this.butStoreRefresh, 1, 1);
            this.tlpStores.Controls.Add(this.butStoreNew, 7, 1);
            this.tlpStores.Controls.Add(this.butStoreEdit, 9, 1);
            this.tlpStores.Controls.Add(this.butStoreDelete, 11, 1);
            this.tlpStores.Controls.Add(this.dgvStores, 1, 3);
            this.tlpStores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStores.Location = new System.Drawing.Point(3, 3);
            this.tlpStores.Margin = new System.Windows.Forms.Padding(0);
            this.tlpStores.Name = "tlpStores";
            this.tlpStores.RowCount = 5;
            this.tlpStores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStores.Size = new System.Drawing.Size(1146, 627);
            this.tlpStores.TabIndex = 0;
            // 
            // butStoreRefresh
            // 
            this.butStoreRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butStoreRefresh.Location = new System.Drawing.Point(10, 10);
            this.butStoreRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.butStoreRefresh.Name = "butStoreRefresh";
            this.butStoreRefresh.Size = new System.Drawing.Size(179, 30);
            this.butStoreRefresh.TabIndex = 0;
            this.butStoreRefresh.Text = "Refresh";
            this.butStoreRefresh.UseVisualStyleBackColor = true;
            this.butStoreRefresh.Click += new System.EventHandler(this.butStoreRefresh_Click);
            // 
            // butStoreNew
            // 
            this.butStoreNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butStoreNew.Location = new System.Drawing.Point(577, 10);
            this.butStoreNew.Margin = new System.Windows.Forms.Padding(0);
            this.butStoreNew.Name = "butStoreNew";
            this.butStoreNew.Size = new System.Drawing.Size(179, 30);
            this.butStoreNew.TabIndex = 1;
            this.butStoreNew.Text = "New";
            this.butStoreNew.UseVisualStyleBackColor = true;
            this.butStoreNew.Click += new System.EventHandler(this.butStoreNew_Click);
            // 
            // butStoreEdit
            // 
            this.butStoreEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butStoreEdit.Location = new System.Drawing.Point(766, 10);
            this.butStoreEdit.Margin = new System.Windows.Forms.Padding(0);
            this.butStoreEdit.Name = "butStoreEdit";
            this.butStoreEdit.Size = new System.Drawing.Size(179, 30);
            this.butStoreEdit.TabIndex = 2;
            this.butStoreEdit.Text = "Edit";
            this.butStoreEdit.UseVisualStyleBackColor = true;
            this.butStoreEdit.Click += new System.EventHandler(this.butStoreEdit_Click);
            // 
            // butStoreDelete
            // 
            this.butStoreDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butStoreDelete.Location = new System.Drawing.Point(955, 10);
            this.butStoreDelete.Margin = new System.Windows.Forms.Padding(0);
            this.butStoreDelete.Name = "butStoreDelete";
            this.butStoreDelete.Size = new System.Drawing.Size(179, 30);
            this.butStoreDelete.TabIndex = 3;
            this.butStoreDelete.Text = "Delete";
            this.butStoreDelete.UseVisualStyleBackColor = true;
            this.butStoreDelete.Click += new System.EventHandler(this.butStoreDelete_Click);
            // 
            // dgvStores
            // 
            this.dgvStores.AllowUserToAddRows = false;
            this.dgvStores.AllowUserToDeleteRows = false;
            this.dgvStores.AllowUserToResizeColumns = false;
            this.dgvStores.AllowUserToResizeRows = false;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpStores.SetColumnSpan(this.dgvStores, 11);
            this.dgvStores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStores.Location = new System.Drawing.Point(10, 50);
            this.dgvStores.Margin = new System.Windows.Forms.Padding(0);
            this.dgvStores.MultiSelect = false;
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.RowTemplate.Height = 25;
            this.dgvStores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStores.ShowEditingIcon = false;
            this.dgvStores.Size = new System.Drawing.Size(1124, 567);
            this.dgvStores.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tlpArticles);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Articles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tlpArticles
            // 
            this.tlpArticles.ColumnCount = 13;
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpArticles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.Controls.Add(this.butArticleRefresh, 1, 1);
            this.tlpArticles.Controls.Add(this.butArticleNew, 7, 3);
            this.tlpArticles.Controls.Add(this.butArticleEdit, 9, 3);
            this.tlpArticles.Controls.Add(this.butArticleDelete, 11, 3);
            this.tlpArticles.Controls.Add(this.dgvArticles, 1, 5);
            this.tlpArticles.Controls.Add(this.lblArticleStore, 1, 3);
            this.tlpArticles.Controls.Add(this.cmbArticleStore, 3, 3);
            this.tlpArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArticles.Location = new System.Drawing.Point(3, 3);
            this.tlpArticles.Margin = new System.Windows.Forms.Padding(0);
            this.tlpArticles.Name = "tlpArticles";
            this.tlpArticles.RowCount = 7;
            this.tlpArticles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpArticles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpArticles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpArticles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpArticles.Size = new System.Drawing.Size(744, 427);
            this.tlpArticles.TabIndex = 0;
            // 
            // butArticleRefresh
            // 
            this.butArticleRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butArticleRefresh.Location = new System.Drawing.Point(10, 10);
            this.butArticleRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.butArticleRefresh.Name = "butArticleRefresh";
            this.butArticleRefresh.Size = new System.Drawing.Size(112, 30);
            this.butArticleRefresh.TabIndex = 0;
            this.butArticleRefresh.Text = "Refresh";
            this.butArticleRefresh.UseVisualStyleBackColor = true;
            this.butArticleRefresh.Click += new System.EventHandler(this.butArticleRefresh_Click);
            // 
            // butArticleNew
            // 
            this.butArticleNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butArticleNew.Location = new System.Drawing.Point(376, 50);
            this.butArticleNew.Margin = new System.Windows.Forms.Padding(0);
            this.butArticleNew.Name = "butArticleNew";
            this.butArticleNew.Size = new System.Drawing.Size(112, 30);
            this.butArticleNew.TabIndex = 1;
            this.butArticleNew.Text = "New";
            this.butArticleNew.UseVisualStyleBackColor = true;
            this.butArticleNew.Click += new System.EventHandler(this.butArticleNew_Click);
            // 
            // butArticleEdit
            // 
            this.butArticleEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butArticleEdit.Location = new System.Drawing.Point(498, 50);
            this.butArticleEdit.Margin = new System.Windows.Forms.Padding(0);
            this.butArticleEdit.Name = "butArticleEdit";
            this.butArticleEdit.Size = new System.Drawing.Size(112, 30);
            this.butArticleEdit.TabIndex = 2;
            this.butArticleEdit.Text = "Edit";
            this.butArticleEdit.UseVisualStyleBackColor = true;
            this.butArticleEdit.Click += new System.EventHandler(this.butArticleEdit_Click);
            // 
            // butArticleDelete
            // 
            this.butArticleDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butArticleDelete.Location = new System.Drawing.Point(620, 50);
            this.butArticleDelete.Margin = new System.Windows.Forms.Padding(0);
            this.butArticleDelete.Name = "butArticleDelete";
            this.butArticleDelete.Size = new System.Drawing.Size(112, 30);
            this.butArticleDelete.TabIndex = 3;
            this.butArticleDelete.Text = "Delete";
            this.butArticleDelete.UseVisualStyleBackColor = true;
            this.butArticleDelete.Click += new System.EventHandler(this.butArticleDelete_Click);
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.AllowUserToResizeColumns = false;
            this.dgvArticles.AllowUserToResizeRows = false;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpArticles.SetColumnSpan(this.dgvArticles, 11);
            this.dgvArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticles.Location = new System.Drawing.Point(10, 90);
            this.dgvArticles.Margin = new System.Windows.Forms.Padding(0);
            this.dgvArticles.MultiSelect = false;
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.RowTemplate.Height = 25;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.ShowEditingIcon = false;
            this.dgvArticles.Size = new System.Drawing.Size(722, 327);
            this.dgvArticles.TabIndex = 4;
            // 
            // lblArticleStore
            // 
            this.lblArticleStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArticleStore.Location = new System.Drawing.Point(10, 50);
            this.lblArticleStore.Margin = new System.Windows.Forms.Padding(0);
            this.lblArticleStore.Name = "lblArticleStore";
            this.lblArticleStore.Size = new System.Drawing.Size(112, 30);
            this.lblArticleStore.TabIndex = 5;
            this.lblArticleStore.Text = "Store:";
            this.lblArticleStore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbArticleStore
            // 
            this.cmbArticleStore.DisplayMember = "Name";
            this.cmbArticleStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbArticleStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticleStore.FormattingEnabled = true;
            this.cmbArticleStore.Location = new System.Drawing.Point(132, 50);
            this.cmbArticleStore.Margin = new System.Windows.Forms.Padding(0);
            this.cmbArticleStore.Name = "cmbArticleStore";
            this.cmbArticleStore.Size = new System.Drawing.Size(112, 23);
            this.cmbArticleStore.TabIndex = 6;
            this.cmbArticleStore.ValueMember = "Id";
            this.cmbArticleStore.SelectedIndexChanged += new System.EventHandler(this.cmbArticleStore_SelectedIndexChanged);
            // 
            // lblOptions
            // 
            this.tlpMain.SetColumnSpan(this.lblOptions, 11);
            this.lblOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOptions.Location = new System.Drawing.Point(10, 10);
            this.lblOptions.Margin = new System.Windows.Forms.Padding(0);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(1160, 30);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Text = "General Options";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Form Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tlpStores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tlpArticles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Button butClose;
        private TabControl tabMain;
        private TabPage tabPage1;
        private TableLayoutPanel tlpStores;
        private Button butStoreRefresh;
        private Button butStoreNew;
        private Button butStoreEdit;
        private Button butStoreDelete;
        private DataGridView dgvStores;
        private TabPage tabPage2;
        private Label lblOptions;
        private TableLayoutPanel tlpArticles;
        private Button butArticleRefresh;
        private Button butArticleNew;
        private Button butArticleEdit;
        private Button butArticleDelete;
        private DataGridView dgvArticles;
        private Label lblArticleStore;
        private ComboBox cmbArticleStore;
    }
}