using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenADONET
{
	public partial class FrmAddProd : Form
	{
		public FrmAddProd()
		{
			InitializeComponent();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			txtnombre.Clear();
			txtprecio.Clear();
			txtstock.Clear();
			btnSave.Enabled = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int resultado = 0;
			try
			{				
				using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
				{
					SqlCommand cmd = conexion.CreateCommand();
					cmd.CommandTimeout = 120;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "usp_Productos_Insert";
					cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtnombre.Text.Trim();
					cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Convert.ToDecimal(txtprecio.Text);
					cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = Convert.ToInt32(txtstock.Text);
					cmd.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = dtfecha.Value;
					if (conexion.State == ConnectionState.Closed) conexion.Open();
					resultado = Convert.ToInt32(cmd.ExecuteNonQuery());
					cmd.Dispose();
				}
				if (resultado > 0) MessageBox.Show("Se Registro Correctamente","Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error comunicarse con el Administrador" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				btnSave.Enabled = false;
			}
		}
	}
}
