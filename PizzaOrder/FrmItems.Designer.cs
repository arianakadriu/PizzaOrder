
namespace PizzaOrder
{
    partial class FrmItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboFilterCat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BtnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2TxtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TxtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TxtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvProducts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.comboFilterCat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.guna2DgvProducts);
            this.panel1.Controls.Add(this.guna2BtnUpdate);
            this.panel1.Controls.Add(this.guna2BtnDelete);
            this.panel1.Controls.Add(this.guna2BtnReset);
            this.panel1.Controls.Add(this.guna2BtnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.guna2TxtPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guna2TxtQty);
            this.panel1.Controls.Add(this.comboCategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.guna2TxtItemName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 533);
            this.panel1.TabIndex = 0;
            // 
            // comboFilterCat
            // 
            this.comboFilterCat.ForeColor = System.Drawing.Color.DarkOrange;
            this.comboFilterCat.FormattingEnabled = true;
            this.comboFilterCat.Items.AddRange(new object[] {
            "Pizza",
            "Drinks"});
            this.comboFilterCat.Location = new System.Drawing.Point(368, 268);
            this.comboFilterCat.Name = "comboFilterCat";
            this.comboFilterCat.Size = new System.Drawing.Size(142, 29);
            this.comboFilterCat.TabIndex = 28;
            this.comboFilterCat.Text = "Category";
            this.comboFilterCat.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboFilterCat.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(883, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(372, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Products List";
            // 
            // guna2DgvProducts
            // 
            this.guna2DgvProducts.AllowUserToAddRows = false;
            this.guna2DgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.guna2DgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DgvProducts.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DgvProducts.EnableHeadersVisualStyles = false;
            this.guna2DgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DgvProducts.Location = new System.Drawing.Point(33, 303);
            this.guna2DgvProducts.Name = "guna2DgvProducts";
            this.guna2DgvProducts.ReadOnly = true;
            this.guna2DgvProducts.RowHeadersVisible = false;
            this.guna2DgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DgvProducts.Size = new System.Drawing.Size(790, 216);
            this.guna2DgvProducts.TabIndex = 21;
            this.guna2DgvProducts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2DgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DgvProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DgvProducts.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DgvProducts.ThemeStyle.ReadOnly = true;
            this.guna2DgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DgvProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2DgvProducts.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DgvProducts_CellContentClick);
            // 
            // guna2BtnUpdate
            // 
            this.guna2BtnUpdate.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnUpdate.BorderRadius = 20;
            this.guna2BtnUpdate.BorderThickness = 1;
            this.guna2BtnUpdate.CheckedState.Parent = this.guna2BtnUpdate;
            this.guna2BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2BtnUpdate.CustomImages.Parent = this.guna2BtnUpdate;
            this.guna2BtnUpdate.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.guna2BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.guna2BtnUpdate.HoverState.Parent = this.guna2BtnUpdate;
            this.guna2BtnUpdate.Location = new System.Drawing.Point(253, 180);
            this.guna2BtnUpdate.Name = "guna2BtnUpdate";
            this.guna2BtnUpdate.ShadowDecoration.Parent = this.guna2BtnUpdate;
            this.guna2BtnUpdate.Size = new System.Drawing.Size(123, 40);
            this.guna2BtnUpdate.TabIndex = 20;
            this.guna2BtnUpdate.Text = "Update";
            this.guna2BtnUpdate.Click += new System.EventHandler(this.guna2BtnUpdate_Click);
            // 
            // guna2BtnDelete
            // 
            this.guna2BtnDelete.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnDelete.BorderRadius = 20;
            this.guna2BtnDelete.BorderThickness = 1;
            this.guna2BtnDelete.CheckedState.Parent = this.guna2BtnDelete;
            this.guna2BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2BtnDelete.CustomImages.Parent = this.guna2BtnDelete;
            this.guna2BtnDelete.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnDelete.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.guna2BtnDelete.ForeColor = System.Drawing.Color.White;
            this.guna2BtnDelete.HoverState.Parent = this.guna2BtnDelete;
            this.guna2BtnDelete.Location = new System.Drawing.Point(410, 180);
            this.guna2BtnDelete.Name = "guna2BtnDelete";
            this.guna2BtnDelete.ShadowDecoration.Parent = this.guna2BtnDelete;
            this.guna2BtnDelete.Size = new System.Drawing.Size(123, 40);
            this.guna2BtnDelete.TabIndex = 19;
            this.guna2BtnDelete.Text = "Delete";
            this.guna2BtnDelete.Click += new System.EventHandler(this.guna2BtnDelete_Click);
            // 
            // guna2BtnReset
            // 
            this.guna2BtnReset.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnReset.BorderRadius = 20;
            this.guna2BtnReset.BorderThickness = 1;
            this.guna2BtnReset.CheckedState.Parent = this.guna2BtnReset;
            this.guna2BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2BtnReset.CustomImages.Parent = this.guna2BtnReset;
            this.guna2BtnReset.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnReset.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.guna2BtnReset.ForeColor = System.Drawing.Color.White;
            this.guna2BtnReset.HoverState.Parent = this.guna2BtnReset;
            this.guna2BtnReset.Location = new System.Drawing.Point(565, 180);
            this.guna2BtnReset.Name = "guna2BtnReset";
            this.guna2BtnReset.ShadowDecoration.Parent = this.guna2BtnReset;
            this.guna2BtnReset.Size = new System.Drawing.Size(123, 40);
            this.guna2BtnReset.TabIndex = 18;
            this.guna2BtnReset.Text = "Reset";
            this.guna2BtnReset.Click += new System.EventHandler(this.guna2BtnReset_Click);
            // 
            // guna2BtnSave
            // 
            this.guna2BtnSave.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnSave.BorderRadius = 20;
            this.guna2BtnSave.BorderThickness = 1;
            this.guna2BtnSave.CheckedState.Parent = this.guna2BtnSave;
            this.guna2BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2BtnSave.CustomImages.Parent = this.guna2BtnSave;
            this.guna2BtnSave.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnSave.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.guna2BtnSave.ForeColor = System.Drawing.Color.White;
            this.guna2BtnSave.HoverState.Parent = this.guna2BtnSave;
            this.guna2BtnSave.Location = new System.Drawing.Point(103, 180);
            this.guna2BtnSave.Name = "guna2BtnSave";
            this.guna2BtnSave.ShadowDecoration.Parent = this.guna2BtnSave;
            this.guna2BtnSave.Size = new System.Drawing.Size(123, 40);
            this.guna2BtnSave.TabIndex = 17;
            this.guna2BtnSave.Text = "Save";
            this.guna2BtnSave.Click += new System.EventHandler(this.guna2BtnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(451, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Price";
            // 
            // guna2TxtPrice
            // 
            this.guna2TxtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtPrice.DefaultText = "";
            this.guna2TxtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtPrice.DisabledState.Parent = this.guna2TxtPrice;
            this.guna2TxtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtPrice.FocusedState.Parent = this.guna2TxtPrice;
            this.guna2TxtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TxtPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2TxtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtPrice.HoverState.Parent = this.guna2TxtPrice;
            this.guna2TxtPrice.Location = new System.Drawing.Point(455, 120);
            this.guna2TxtPrice.Name = "guna2TxtPrice";
            this.guna2TxtPrice.PasswordChar = '\0';
            this.guna2TxtPrice.PlaceholderText = "";
            this.guna2TxtPrice.SelectedText = "";
            this.guna2TxtPrice.ShadowDecoration.Parent = this.guna2TxtPrice;
            this.guna2TxtPrice.Size = new System.Drawing.Size(118, 30);
            this.guna2TxtPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(605, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantity";
            // 
            // guna2TxtQty
            // 
            this.guna2TxtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtQty.DefaultText = "";
            this.guna2TxtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtQty.DisabledState.Parent = this.guna2TxtQty;
            this.guna2TxtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtQty.FocusedState.Parent = this.guna2TxtQty;
            this.guna2TxtQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TxtQty.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2TxtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtQty.HoverState.Parent = this.guna2TxtQty;
            this.guna2TxtQty.Location = new System.Drawing.Point(609, 118);
            this.guna2TxtQty.Name = "guna2TxtQty";
            this.guna2TxtQty.PasswordChar = '\0';
            this.guna2TxtQty.PlaceholderText = "";
            this.guna2TxtQty.SelectedText = "";
            this.guna2TxtQty.ShadowDecoration.Parent = this.guna2TxtQty;
            this.guna2TxtQty.Size = new System.Drawing.Size(116, 30);
            this.guna2TxtQty.TabIndex = 4;
            // 
            // comboCategory
            // 
            this.comboCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Pizza",
            "Drinks"});
            this.comboCategory.Location = new System.Drawing.Point(267, 120);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(142, 29);
            this.comboCategory.TabIndex = 2;
            this.comboCategory.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(29, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product Name";
            // 
            // guna2TxtItemName
            // 
            this.guna2TxtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtItemName.DefaultText = "";
            this.guna2TxtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtItemName.DisabledState.Parent = this.guna2TxtItemName;
            this.guna2TxtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtItemName.FocusedState.Parent = this.guna2TxtItemName;
            this.guna2TxtItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TxtItemName.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2TxtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtItemName.HoverState.Parent = this.guna2TxtItemName;
            this.guna2TxtItemName.Location = new System.Drawing.Point(33, 118);
            this.guna2TxtItemName.Name = "guna2TxtItemName";
            this.guna2TxtItemName.PasswordChar = '\0';
            this.guna2TxtItemName.PlaceholderText = "";
            this.guna2TxtItemName.SelectedText = "";
            this.guna2TxtItemName.ShadowDecoration.Parent = this.guna2TxtItemName;
            this.guna2TxtItemName.Size = new System.Drawing.Size(193, 30);
            this.guna2TxtItemName.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 2);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(479, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(267, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 2);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(263, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::PizzaOrder.Properties.Resources.PngItem_2203551;
            this.pictureBox4.Location = new System.Drawing.Point(526, 268);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::PizzaOrder.Properties.Resources.PngItem_5493525;
            this.pictureBox3.Location = new System.Drawing.Point(842, 482);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PizzaOrder.Properties.Resources.PngItem_2071396;
            this.pictureBox2.Location = new System.Drawing.Point(414, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaOrder.Properties.Resources.pngfind_com_pizza_slice_clipart_png_6230713;
            this.pictureBox1.Location = new System.Drawing.Point(198, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(266, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Category";
            // 
            // FrmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(935, 557);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmItems";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtItemName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtPrice;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtQty;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DgvProducts;
        private Guna.UI2.WinForms.Guna2Button guna2BtnUpdate;
        private Guna.UI2.WinForms.Guna2Button guna2BtnDelete;
        private Guna.UI2.WinForms.Guna2Button guna2BtnReset;
        private Guna.UI2.WinForms.Guna2Button guna2BtnSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboFilterCat;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
    }
}