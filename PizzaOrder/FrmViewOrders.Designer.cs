
namespace PizzaOrder
{
    partial class FrmViewOrders
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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DgvSells = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2BtnBack = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvSells)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.guna2BtnBack);
            this.panel1.Controls.Add(this.guna2DgvSells);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 331);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(314, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Orders List";
            // 
            // guna2DgvSells
            // 
            this.guna2DgvSells.AllowUserToAddRows = false;
            this.guna2DgvSells.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DgvSells.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DgvSells.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DgvSells.BackgroundColor = System.Drawing.Color.White;
            this.guna2DgvSells.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DgvSells.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DgvSells.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DgvSells.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DgvSells.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DgvSells.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DgvSells.EnableHeadersVisualStyles = false;
            this.guna2DgvSells.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DgvSells.Location = new System.Drawing.Point(3, 48);
            this.guna2DgvSells.Name = "guna2DgvSells";
            this.guna2DgvSells.ReadOnly = true;
            this.guna2DgvSells.RowHeadersVisible = false;
            this.guna2DgvSells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DgvSells.Size = new System.Drawing.Size(704, 234);
            this.guna2DgvSells.TabIndex = 22;
            this.guna2DgvSells.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DgvSells.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvSells.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DgvSells.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DgvSells.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DgvSells.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DgvSells.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvSells.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DgvSells.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2DgvSells.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DgvSells.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DgvSells.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DgvSells.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DgvSells.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DgvSells.ThemeStyle.ReadOnly = true;
            this.guna2DgvSells.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvSells.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DgvSells.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DgvSells.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2DgvSells.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DgvSells.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DgvSells.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DgvSells.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DgvSells_CellContentClick);
            // 
            // guna2BtnBack
            // 
            this.guna2BtnBack.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnBack.BorderRadius = 20;
            this.guna2BtnBack.BorderThickness = 1;
            this.guna2BtnBack.CheckedState.Parent = this.guna2BtnBack;
            this.guna2BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2BtnBack.CustomImages.Parent = this.guna2BtnBack;
            this.guna2BtnBack.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2BtnBack.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.guna2BtnBack.ForeColor = System.Drawing.Color.White;
            this.guna2BtnBack.HoverState.Parent = this.guna2BtnBack;
            this.guna2BtnBack.Location = new System.Drawing.Point(306, 288);
            this.guna2BtnBack.Name = "guna2BtnBack";
            this.guna2BtnBack.ShadowDecoration.Parent = this.guna2BtnBack;
            this.guna2BtnBack.Size = new System.Drawing.Size(123, 40);
            this.guna2BtnBack.TabIndex = 23;
            this.guna2BtnBack.Text = "Back";
            this.guna2BtnBack.Click += new System.EventHandler(this.guna2BtnBack_Click);
            // 
            // FrmViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(734, 355);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViewBills";
            this.Load += new System.EventHandler(this.FrmViewOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvSells)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DgvSells;
        private Guna.UI2.WinForms.Guna2Button guna2BtnBack;
    }
}