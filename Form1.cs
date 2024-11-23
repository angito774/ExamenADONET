using static System.Windows.Forms.DataFormats;

namespace ExamenADONET
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FrmAddProd form = new FrmAddProd();
			form.ShowDialog();
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			FrmFindProd form = new FrmFindProd();
			form.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			FrmUpdateProd form = new FrmUpdateProd();
			form.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			FrmDeleteProd form = new FrmDeleteProd();
			form.ShowDialog();
		}
	}
}
