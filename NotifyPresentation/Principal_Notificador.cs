using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;


namespace NotifyPresentation
{
    public partial class Principal_Notificador : Form
    {


        #region "Procedimientos"

        private String LOGIN_LOGUEO(String VL_USUARIO, String VL_PASSWORD)
        {

            BusinessLogicLayer.Global.SrvGlobal VL_SrvGlobal = new BusinessLogicLayer.Global.SrvGlobal();
            EntityLayer.Resultado.BeanResultado.ResultadoSelect VL_BeanResultado = new EntityLayer.Resultado.BeanResultado.ResultadoSelect();
            String Mensaje="";
            try
            {
                VL_BeanResultado = VL_SrvGlobal.FNC_LOGIN_LOGUEO(VL_USUARIO, VL_PASSWORD);

                if (VL_BeanResultado.blnExiste == true)
                {
                    if (VL_BeanResultado.dtResultado.Rows.Count > 0)
                    {
                        Mensaje = "BIENVENIDO " + VL_BeanResultado.dtResultado.Rows[0][4].ToString();
                    }else
	                {
                        Mensaje = "EL USUARIO Y/O LA CONTRASEÑA NO COINCIDEN";
	                }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.ToString();
            }

            return Mensaje;

        }

    #endregion


        public Principal_Notificador()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
        }

        private void Principal_Notificador_Load(object sender, EventArgs e)
        {

            ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";

            Rectangle workingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            int left = workingArea.Width - this.Width;
            int top = workingArea.Height - this.Height;
            this.Location = new Point(left, top);

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show( LOGIN_LOGUEO(txtUsuario.Text, txtPassword.Text));

            this.Hide();
            ntiNotificar.Visible = true;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ntiNotificar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ntiNotificar.Visible = false;
            this.Show();
        }
    }
}
