namespace CompanyAssetsControl.UserControls
{
    partial class UserControlListingAssets
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblServiceTag = new System.Windows.Forms.Label();
            this.lblRenter = new System.Windows.Forms.Label();
            this.lblRentValue = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 4;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.Controls.Add(this.lblModel, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblServiceTag, 1, 0);
            this.tlpPrincipal.Controls.Add(this.lblRenter, 2, 0);
            this.tlpPrincipal.Controls.Add(this.lblRentValue, 3, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(600, 60);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(3, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(144, 60);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Modelo";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServiceTag
            // 
            this.lblServiceTag.AutoSize = true;
            this.lblServiceTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceTag.Location = new System.Drawing.Point(153, 0);
            this.lblServiceTag.Name = "lblServiceTag";
            this.lblServiceTag.Size = new System.Drawing.Size(144, 60);
            this.lblServiceTag.TabIndex = 1;
            this.lblServiceTag.Text = "Service Tag";
            this.lblServiceTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRenter
            // 
            this.lblRenter.AutoSize = true;
            this.lblRenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRenter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenter.Location = new System.Drawing.Point(303, 0);
            this.lblRenter.Name = "lblRenter";
            this.lblRenter.Size = new System.Drawing.Size(144, 60);
            this.lblRenter.TabIndex = 2;
            this.lblRenter.Text = "Fornecedor";
            this.lblRenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRentValue
            // 
            this.lblRentValue.AutoSize = true;
            this.lblRentValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRentValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentValue.Location = new System.Drawing.Point(453, 0);
            this.lblRentValue.Name = "lblRentValue";
            this.lblRentValue.Size = new System.Drawing.Size(144, 60);
            this.lblRentValue.TabIndex = 3;
            this.lblRentValue.Text = "Valor Aluguel";
            this.lblRentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlListingAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlListingAssets";
            this.Size = new System.Drawing.Size(600, 60);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblServiceTag;
        private System.Windows.Forms.Label lblRenter;
        private System.Windows.Forms.Label lblRentValue;
    }
}
