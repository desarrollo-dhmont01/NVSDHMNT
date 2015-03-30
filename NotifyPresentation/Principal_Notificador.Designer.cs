namespace NotifyPresentation
{
    partial class Principal_Notificador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Notificador));
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnIniciar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.txtUsuario = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.ntiNotificar = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            resources.ApplyResources(this.radPageView1, "radPageView1");
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.ThemeName = "TelerikMetroBlue";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.txtPassword);
            this.radPageViewPage1.Controls.Add(this.txtUsuario);
            this.radPageViewPage1.Controls.Add(this.btnCancelar);
            this.radPageViewPage1.Controls.Add(this.radLabel2);
            this.radPageViewPage1.Controls.Add(this.btnIniciar);
            this.radPageViewPage1.Controls.Add(this.radLabel1);
            resources.ApplyResources(this.radPageViewPage1, "radPageViewPage1");
            this.radPageViewPage1.Name = "radPageViewPage1";
            // 
            // radLabel1
            // 
            resources.ApplyResources(this.radLabel1, "radLabel1");
            this.radLabel1.Name = "radLabel1";
            // 
            // btnIniciar
            // 
            resources.ApplyResources(this.btnIniciar, "btnIniciar");
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.ThemeName = "TelerikMetroBlue";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // radLabel2
            // 
            resources.ApplyResources(this.radLabel2, "radLabel2");
            this.radLabel2.Name = "radLabel2";
            // 
            // 
            // 
            this.radLabel2.RootElement.AccessibleDescription = resources.GetString("radLabel2.RootElement.AccessibleDescription");
            this.radLabel2.RootElement.AccessibleName = resources.GetString("radLabel2.RootElement.AccessibleName");
            this.radLabel2.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radLabel2.RootElement.Alignment")));
            this.radLabel2.RootElement.AngleTransform = ((float)(resources.GetObject("radLabel2.RootElement.AngleTransform")));
            this.radLabel2.RootElement.FlipText = ((bool)(resources.GetObject("radLabel2.RootElement.FlipText")));
            this.radLabel2.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radLabel2.RootElement.Margin")));
            this.radLabel2.RootElement.Text = resources.GetString("radLabel2.RootElement.Text");
            this.radLabel2.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radLabel2.RootElement.TextOrientation")));
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            // 
            // 
            // 
            this.btnCancelar.RootElement.AccessibleDescription = resources.GetString("radButton1.RootElement.AccessibleDescription");
            this.btnCancelar.RootElement.AccessibleName = resources.GetString("radButton1.RootElement.AccessibleName");
            this.btnCancelar.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radButton1.RootElement.Alignment")));
            this.btnCancelar.RootElement.AngleTransform = ((float)(resources.GetObject("radButton1.RootElement.AngleTransform")));
            this.btnCancelar.RootElement.FlipText = ((bool)(resources.GetObject("radButton1.RootElement.FlipText")));
            this.btnCancelar.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radButton1.RootElement.Margin")));
            this.btnCancelar.RootElement.Text = resources.GetString("radButton1.RootElement.Text");
            this.btnCancelar.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radButton1.RootElement.TextOrientation")));
            this.btnCancelar.ThemeName = "TelerikMetroBlue";
            this.btnCancelar.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ThemeName = "TelerikMetroBlue";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            // 
            // 
            // 
            this.txtPassword.RootElement.AccessibleDescription = resources.GetString("radTextBox1.RootElement.AccessibleDescription");
            this.txtPassword.RootElement.AccessibleName = resources.GetString("radTextBox1.RootElement.AccessibleName");
            this.txtPassword.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radTextBox1.RootElement.Alignment")));
            this.txtPassword.RootElement.AngleTransform = ((float)(resources.GetObject("radTextBox1.RootElement.AngleTransform")));
            this.txtPassword.RootElement.FlipText = ((bool)(resources.GetObject("radTextBox1.RootElement.FlipText")));
            this.txtPassword.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radTextBox1.RootElement.Margin")));
            this.txtPassword.RootElement.Text = resources.GetString("radTextBox1.RootElement.Text");
            this.txtPassword.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radTextBox1.RootElement.TextOrientation")));
            this.txtPassword.ThemeName = "TelerikMetroBlue";
            // 
            // ntiNotificar
            // 
            resources.ApplyResources(this.ntiNotificar, "ntiNotificar");
            this.ntiNotificar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntiNotificar_MouseDoubleClick);
            // 
            // Principal_Notificador
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPageView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Principal_Notificador";
            this.Load += new System.EventHandler(this.Principal_Notificador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadButton btnIniciar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtUsuario;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.NotifyIcon ntiNotificar;
    }
}