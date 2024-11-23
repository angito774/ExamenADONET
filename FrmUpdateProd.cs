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
	public partial class FrmUpdateProd : Form
	{
		public FrmUpdateProd()
		{
			InitializeComponent();
		}

		private void FrmUpdateProd_Load(object sender, EventArgs e)
		{

		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			txtnombre.Clear(); txtprecio.Clear(); txtstock.Clear();
			if (txtId.Text.Trim().Length <= 0)
			{
				MessageBox.Show("Ingrese un ID Producto a Consultar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			try
			{
				var listproducto = new List<ProductoEN>();
				using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
				{
					SqlCommand cmd = conexion.CreateCommand();
					cmd.CommandTimeout = 120;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "usp_Producto_Buscar";
					cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = Convert.ToInt32(txtId.Text);
					if (conexion.State == ConnectionState.Closed) conexion.Open();

					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							listproducto.Add(new ProductoEN
							{
								Nombre = Convert.ToString(dr["Nombre"])!,
								Precio = Convert.ToDecimal(dr["Precio"])!,
								Stock = Convert.ToInt32(dr["Stock"])!,
								//activo = dr["Activo"] == DBNull.Value ? false : Convert.ToBoolean(dr["Activo"])!,
								FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"])!,
							});
						}
					}
					cmd.Dispose();

					if (listproducto.Count > 0)
					{
						foreach (var item in listproducto)
						{
							txtnombre.Text = item.Nombre;
							txtprecio.Text = item.Precio.ToString();
							txtstock.Text = item.Stock.ToString();
							dtfecha.Value = Convert.ToDateTime(item.FechaCreacion);
						}
						btnUpdate.Enabled = true;
					}
					else
					{
						btnUpdate.Enabled = false;
						MessageBox.Show("IdProducto No Existe en la BD", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
			catch (Exception ex)
			{
				btnUpdate.Enabled = false;
				MessageBox.Show("Error comunicarse con el Administrador" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int resultado = 0;
			try
			{
				using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
				{
					SqlCommand cmd = conexion.CreateCommand();
					cmd.CommandTimeout = 120;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "usp_Productos_Update";
					cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = Convert.ToInt32(txtId.Text);
					cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtnombre.Text.Trim();
					cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Convert.ToDecimal(txtprecio.Text);
					cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = Convert.ToInt32(txtstock.Text);
					cmd.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = dtfecha.Value;
					if (conexion.State == ConnectionState.Closed) conexion.Open();
					resultado = Convert.ToInt32(cmd.ExecuteNonQuery());
					cmd.Dispose();
				}
				if (resultado > 0) MessageBox.Show("Se Actualizo Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error comunicarse con el Administrador" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				btnUpdate.Enabled = false;
			}
		}
	}
}
