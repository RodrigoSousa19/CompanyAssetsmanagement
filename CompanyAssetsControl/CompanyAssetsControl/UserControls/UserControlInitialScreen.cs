using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyAssetsControl
{
    public partial class UserControlInitialScreen : UserControl
    {
        public delegate void OnClickRegisterNewAssets();
        public delegate void OnClickViewAssets();
        public delegate void OnClickRegisterNewRenter();
        public delegate void OnClickAssetDelivery();
        public delegate void OnClickAssetReturn();

        public OnClickRegisterNewAssets clickRegisterNewAssets = null;
        public OnClickViewAssets clickViewAssets = null;
        public OnClickRegisterNewRenter clickRegisterNewRenter = null;
        public OnClickAssetDelivery clickAssetDelivery = null;
        public OnClickAssetReturn clickAssetReturn = null;


        public UserControlInitialScreen(OnClickRegisterNewAssets clickRegisterNewAssets,
                                        OnClickViewAssets clickViewAssets,
                                        OnClickRegisterNewRenter clickRegisterNewRenter,
                                        OnClickAssetDelivery clickAssetDelivery,
                                        OnClickAssetReturn clickAssetReturn)
        {
            InitializeComponent();

            this.clickRegisterNewAssets = clickRegisterNewAssets;
            this.clickViewAssets = clickViewAssets;
            this.clickRegisterNewRenter = clickRegisterNewRenter;
            this.clickAssetDelivery = clickAssetDelivery;
            this.clickAssetReturn = clickAssetReturn;
        }

        private void btnRegisterAssets_Click(object sender, EventArgs e)
        {
            clickViewAssets();
        }

        private void btnViewAssets_Click(object sender, EventArgs e)
        {
            clickViewAssets();
        }

        private void btnRegisterRenter_Click(object sender, EventArgs e)
        {
            clickRegisterNewRenter();
        }

        private void btnDeliveryAsset_Click(object sender, EventArgs e)
        {
            clickAssetDelivery();
        }

        private void btnReturnAsset_Click(object sender, EventArgs e)
        {
            clickAssetReturn();
        }

        #region Visual
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
            this.tableLayoutPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tableLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegisterAssets = new System.Windows.Forms.Button();
            this.btnViewAssets = new System.Windows.Forms.Button();
            this.btnRegisterRenter = new System.Windows.Forms.Button();
            this.btnDeliveryAsset = new System.Windows.Forms.Button();
            this.btnReturnAsset = new System.Windows.Forms.Button();
            this.tableLayoutPrincipal.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.tableLayoutButtons.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPrincipal
            // 
            this.tableLayoutPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.tableLayoutPrincipal.ColumnCount = 2;
            this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPrincipal.Controls.Add(this.panelPrincipal, 0, 1);
            this.tableLayoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPrincipal.Name = "tableLayoutPrincipal";
            this.tableLayoutPrincipal.RowCount = 2;
            this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPrincipal.Size = new System.Drawing.Size(650, 650);
            this.tableLayoutPrincipal.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.tableLayoutPrincipal.SetColumnSpan(this.panelPrincipal, 2);
            this.panelPrincipal.Controls.Add(this.tableLayoutButtons);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(3, 100);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(644, 547);
            this.panelPrincipal.TabIndex = 0;
            // 
            // tableLayoutButtons
            // 
            this.tableLayoutButtons.ColumnCount = 4;
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutButtons.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutButtons.Name = "tableLayoutButtons";
            this.tableLayoutButtons.RowCount = 4;
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutButtons.Size = new System.Drawing.Size(644, 547);
            this.tableLayoutButtons.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutButtons.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnRegisterAssets);
            this.flowLayoutPanel1.Controls.Add(this.btnViewAssets);
            this.flowLayoutPanel1.Controls.Add(this.btnRegisterRenter);
            this.flowLayoutPanel1.Controls.Add(this.btnDeliveryAsset);
            this.flowLayoutPanel1.Controls.Add(this.btnReturnAsset);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(164, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutButtons.SetRowSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 541);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnRegisterAssets
            // 
            this.btnRegisterAssets.AutoSize = true;
            this.btnRegisterAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnRegisterAssets.FlatAppearance.BorderSize = 0;
            this.btnRegisterAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterAssets.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAssets.ForeColor = System.Drawing.Color.White;
            this.btnRegisterAssets.Location = new System.Drawing.Point(3, 3);
            this.btnRegisterAssets.Name = "btnRegisterAssets";
            this.btnRegisterAssets.Size = new System.Drawing.Size(313, 50);
            this.btnRegisterAssets.TabIndex = 1;
            this.btnRegisterAssets.Text = "Cadastrar Ativos";
            this.btnRegisterAssets.UseVisualStyleBackColor = false;
            this.btnRegisterAssets.Click += new System.EventHandler(this.btnRegisterAssets_Click);
            // 
            // btnViewAssets
            // 
            this.btnViewAssets.AutoSize = true;
            this.btnViewAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnViewAssets.FlatAppearance.BorderSize = 0;
            this.btnViewAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAssets.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAssets.ForeColor = System.Drawing.Color.White;
            this.btnViewAssets.Location = new System.Drawing.Point(3, 59);
            this.btnViewAssets.Name = "btnViewAssets";
            this.btnViewAssets.Size = new System.Drawing.Size(313, 50);
            this.btnViewAssets.TabIndex = 0;
            this.btnViewAssets.Text = "Consultar Ativos";
            this.btnViewAssets.UseVisualStyleBackColor = false;
            this.btnViewAssets.Click += new System.EventHandler(this.btnViewAssets_Click);
            // 
            // btnRegisterRenter
            // 
            this.btnRegisterRenter.AutoSize = true;
            this.btnRegisterRenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnRegisterRenter.FlatAppearance.BorderSize = 0;
            this.btnRegisterRenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterRenter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterRenter.ForeColor = System.Drawing.Color.White;
            this.btnRegisterRenter.Location = new System.Drawing.Point(3, 115);
            this.btnRegisterRenter.Name = "btnRegisterRenter";
            this.btnRegisterRenter.Size = new System.Drawing.Size(313, 50);
            this.btnRegisterRenter.TabIndex = 2;
            this.btnRegisterRenter.Text = "Cadastrar Fornecedor";
            this.btnRegisterRenter.UseVisualStyleBackColor = false;
            this.btnRegisterRenter.Click += new System.EventHandler(this.btnRegisterRenter_Click);
            // 
            // btnDeliveryAsset
            // 
            this.btnDeliveryAsset.AutoSize = true;
            this.btnDeliveryAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnDeliveryAsset.FlatAppearance.BorderSize = 0;
            this.btnDeliveryAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveryAsset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveryAsset.ForeColor = System.Drawing.Color.White;
            this.btnDeliveryAsset.Location = new System.Drawing.Point(3, 171);
            this.btnDeliveryAsset.Name = "btnDeliveryAsset";
            this.btnDeliveryAsset.Size = new System.Drawing.Size(313, 50);
            this.btnDeliveryAsset.TabIndex = 3;
            this.btnDeliveryAsset.Text = "Entrega de Ativos";
            this.btnDeliveryAsset.UseVisualStyleBackColor = false;
            this.btnDeliveryAsset.Click += new System.EventHandler(this.btnDeliveryAsset_Click);
            // 
            // btnReturnAsset
            // 
            this.btnReturnAsset.AutoSize = true;
            this.btnReturnAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnReturnAsset.FlatAppearance.BorderSize = 0;
            this.btnReturnAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnAsset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnAsset.ForeColor = System.Drawing.Color.White;
            this.btnReturnAsset.Location = new System.Drawing.Point(3, 227);
            this.btnReturnAsset.Name = "btnReturnAsset";
            this.btnReturnAsset.Size = new System.Drawing.Size(313, 50);
            this.btnReturnAsset.TabIndex = 4;
            this.btnReturnAsset.Text = "Devolução de Ativos";
            this.btnReturnAsset.UseVisualStyleBackColor = false;
            this.btnReturnAsset.Click += new System.EventHandler(this.btnReturnAsset_Click);
            // 
            // UserControlInitialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPrincipal);
            this.Name = "UserControlInitialScreen";
            this.Size = new System.Drawing.Size(650, 650);
            this.tableLayoutPrincipal.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.tableLayoutButtons.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPrincipal;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnViewAssets;
        private System.Windows.Forms.Button btnRegisterAssets;
        private System.Windows.Forms.Button btnRegisterRenter;
        private System.Windows.Forms.Button btnDeliveryAsset;
        private System.Windows.Forms.Button btnReturnAsset;
        #endregion

    }
}
