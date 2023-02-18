namespace Examen.Desktop
{
    partial class StoreForm
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
            this.tlpStore = new System.Windows.Forms.TableLayoutPanel();
            this.lblStoreEditing = new System.Windows.Forms.Label();
            this.lblStoreId = new System.Windows.Forms.Label();
            this.txtStoreId = new System.Windows.Forms.TextBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.lblStoreAddress = new System.Windows.Forms.Label();
            this.txtStoreAddress = new System.Windows.Forms.TextBox();
            this.butStoreSave = new System.Windows.Forms.Button();
            this.butStoreCancel = new System.Windows.Forms.Button();
            this.tlpStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpStore
            // 
            this.tlpStore.ColumnCount = 9;
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.Controls.Add(this.lblStoreEditing, 1, 1);
            this.tlpStore.Controls.Add(this.lblStoreId, 1, 3);
            this.tlpStore.Controls.Add(this.txtStoreId, 3, 3);
            this.tlpStore.Controls.Add(this.lblStoreName, 1, 5);
            this.tlpStore.Controls.Add(this.txtStoreName, 3, 5);
            this.tlpStore.Controls.Add(this.lblStoreAddress, 1, 7);
            this.tlpStore.Controls.Add(this.txtStoreAddress, 3, 7);
            this.tlpStore.Controls.Add(this.butStoreSave, 3, 9);
            this.tlpStore.Controls.Add(this.butStoreCancel, 7, 9);
            this.tlpStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStore.Location = new System.Drawing.Point(0, 0);
            this.tlpStore.Margin = new System.Windows.Forms.Padding(0);
            this.tlpStore.Name = "tlpStore";
            this.tlpStore.RowCount = 11;
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpStore.Size = new System.Drawing.Size(424, 221);
            this.tlpStore.TabIndex = 0;
            // 
            // lblStoreEditing
            // 
            this.tlpStore.SetColumnSpan(this.lblStoreEditing, 7);
            this.lblStoreEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStoreEditing.Location = new System.Drawing.Point(10, 10);
            this.lblStoreEditing.Margin = new System.Windows.Forms.Padding(0);
            this.lblStoreEditing.Name = "lblStoreEditing";
            this.lblStoreEditing.Size = new System.Drawing.Size(402, 30);
            this.lblStoreEditing.TabIndex = 0;
            this.lblStoreEditing.Text = "Create New Store";
            this.lblStoreEditing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStoreId
            // 
            this.lblStoreId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStoreId.Location = new System.Drawing.Point(10, 50);
            this.lblStoreId.Margin = new System.Windows.Forms.Padding(0);
            this.lblStoreId.Name = "lblStoreId";
            this.lblStoreId.Size = new System.Drawing.Size(93, 30);
            this.lblStoreId.TabIndex = 1;
            this.lblStoreId.Text = "Id:";
            this.lblStoreId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStoreId
            // 
            this.txtStoreId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStoreId.Location = new System.Drawing.Point(113, 50);
            this.txtStoreId.Margin = new System.Windows.Forms.Padding(0);
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.ReadOnly = true;
            this.txtStoreId.Size = new System.Drawing.Size(93, 23);
            this.txtStoreId.TabIndex = 2;
            this.txtStoreId.TabStop = false;
            this.txtStoreId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStoreName
            // 
            this.lblStoreName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStoreName.Location = new System.Drawing.Point(10, 90);
            this.lblStoreName.Margin = new System.Windows.Forms.Padding(0);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(93, 30);
            this.lblStoreName.TabIndex = 3;
            this.lblStoreName.Text = "Name:";
            this.lblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStoreName
            // 
            this.tlpStore.SetColumnSpan(this.txtStoreName, 5);
            this.txtStoreName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStoreName.Location = new System.Drawing.Point(113, 90);
            this.txtStoreName.Margin = new System.Windows.Forms.Padding(0);
            this.txtStoreName.MaxLength = 100;
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(299, 23);
            this.txtStoreName.TabIndex = 4;
            // 
            // lblStoreAddress
            // 
            this.lblStoreAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStoreAddress.Location = new System.Drawing.Point(10, 130);
            this.lblStoreAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lblStoreAddress.Name = "lblStoreAddress";
            this.lblStoreAddress.Size = new System.Drawing.Size(93, 30);
            this.lblStoreAddress.TabIndex = 5;
            this.lblStoreAddress.Text = "Address:";
            this.lblStoreAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStoreAddress
            // 
            this.tlpStore.SetColumnSpan(this.txtStoreAddress, 5);
            this.txtStoreAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStoreAddress.Location = new System.Drawing.Point(113, 130);
            this.txtStoreAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtStoreAddress.MaxLength = 200;
            this.txtStoreAddress.Name = "txtStoreAddress";
            this.txtStoreAddress.Size = new System.Drawing.Size(299, 23);
            this.txtStoreAddress.TabIndex = 6;
            // 
            // butStoreSave
            // 
            this.tlpStore.SetColumnSpan(this.butStoreSave, 3);
            this.butStoreSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butStoreSave.Location = new System.Drawing.Point(113, 170);
            this.butStoreSave.Margin = new System.Windows.Forms.Padding(0);
            this.butStoreSave.Name = "butStoreSave";
            this.butStoreSave.Size = new System.Drawing.Size(196, 41);
            this.butStoreSave.TabIndex = 7;
            this.butStoreSave.Text = "Save";
            this.butStoreSave.UseVisualStyleBackColor = true;
            this.butStoreSave.Click += new System.EventHandler(this.butStoreSave_Click);
            // 
            // butStoreCancel
            // 
            this.butStoreCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butStoreCancel.Location = new System.Drawing.Point(319, 170);
            this.butStoreCancel.Margin = new System.Windows.Forms.Padding(0);
            this.butStoreCancel.Name = "butStoreCancel";
            this.butStoreCancel.Size = new System.Drawing.Size(93, 41);
            this.butStoreCancel.TabIndex = 8;
            this.butStoreCancel.Text = "Cancel";
            this.butStoreCancel.UseVisualStyleBackColor = true;
            this.butStoreCancel.Click += new System.EventHandler(this.butStoreCancel_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 221);
            this.ControlBox = false;
            this.Controls.Add(this.tlpStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Store Options";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.tlpStore.ResumeLayout(false);
            this.tlpStore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpStore;
        private Label lblStoreEditing;
        private Label lblStoreId;
        private TextBox txtStoreId;
        private Label lblStoreName;
        private TextBox txtStoreName;
        private Label lblStoreAddress;
        private TextBox txtStoreAddress;
        private Button butStoreSave;
        private Button butStoreCancel;
    }
}