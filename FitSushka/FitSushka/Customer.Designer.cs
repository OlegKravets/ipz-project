namespace FitSushka
{
    partial class Customer
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
            if(disposing && (components != null))
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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.navPageData = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.navPageTraining = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.navPageSale = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.tabPane1.Controls.Add(this.navPageData);
            this.tabPane1.Controls.Add(this.navPageTraining);
            this.tabPane1.Controls.Add(this.navPageSale);
            this.tabPane1.Location = new System.Drawing.Point(191, 46);
            this.tabPane1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.tabPane1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.AllowBorderColorBlending = true;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPageData,
            this.navPageTraining,
            this.navPageSale});
            this.tabPane1.RegularSize = new System.Drawing.Size(527, 355);
            this.tabPane1.SelectedPage = this.navPageTraining;
            this.tabPane1.Size = new System.Drawing.Size(527, 355);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.TransitionType = DevExpress.Utils.Animation.Transitions.Comb;
            // 
            // navPageData
            // 
            this.navPageData.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navPageData.Appearance.Options.UseBackColor = true;
            this.navPageData.Appearance.Options.UseFont = true;
            this.navPageData.Caption = "tabNavigationPage1";
            this.navPageData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navPageData.Name = "navPageData";
            this.navPageData.PageText = "Данные";
            this.navPageData.Size = new System.Drawing.Size(509, 310);
            // 
            // navPageTraining
            // 
            this.navPageTraining.Caption = "tabNavigationPage2";
            this.navPageTraining.Name = "navPageTraining";
            this.navPageTraining.PageText = "Тренировка";
            this.navPageTraining.Size = new System.Drawing.Size(509, 310);
            // 
            // navPageSale
            // 
            this.navPageSale.Caption = "navPageSale";
            this.navPageSale.Name = "navPageSale";
            this.navPageSale.PageText = "Скидки";
            this.navPageSale.Size = new System.Drawing.Size(509, 310);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 113);
            this.panel1.TabIndex = 2;
            // 
            // Customer
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabPane1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage navPageData;
        private DevExpress.XtraBars.Navigation.TabNavigationPage navPageTraining;
        private DevExpress.XtraBars.Navigation.TabNavigationPage navPageSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}