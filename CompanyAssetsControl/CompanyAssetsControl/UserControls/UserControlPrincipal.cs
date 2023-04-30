using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyAssetsControl.UserControls
{
    public partial class UserControlPrincipal : UserControl
    {
        public enum STEP_SET
        {
            NONE,
            INITIAL_SCREEN,
        }

        public STEP_SET StepSet = STEP_SET.INITIAL_SCREEN;

        public UserControlInitialScreen userControlInitialScreen = null;


        public UserControlPrincipal()
        {
            InitializeComponent();
        }

        #region AddUserControls
        public void AddInitialScreenUserControl()
        {
            userControlInitialScreen = new UserControlInitialScreen(OnClickRegisterNewAssets, OnClickViewAssets, OnClickRegisterNewRenter, OnClickAssetDelivery, OnClickAssetReturn);
            userControlInitialScreen.Dock = DockStyle.Fill;
            userControlInitialScreen.SendToBack();
            userControlInitialScreen.Visible = false;
        }
        #endregion

        public void GetExecuteScreen()
        {
            switch (StepSet)
            {
                case STEP_SET.NONE:
                    {
                        break;
                    }
                case STEP_SET.INITIAL_SCREEN:
                    {
                        break;
                    }
            }
        }

        public void OnClickRegisterNewAssets()
        {

        }
        public void OnClickViewAssets()
        {

        }
        public void OnClickRegisterNewRenter()
        {

        }
        public void OnClickAssetDelivery()
        {

        }
        public void OnClickAssetReturn()
        {

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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion

        #endregion
    }
}
