namespace ExamenADONET
{
	partial class FrmDeleteProd
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
			btnFind = new Button();
			txtId = new TextBox();
			label5 = new Label();
			txtnombre = new TextBox();
			label1 = new Label();
			btnDelete = new Button();
			SuspendLayout();
			// 
			// btnFind
			// 
			btnFind.Location = new Point(200, 8);
			btnFind.Name = "btnFind";
			btnFind.Size = new Size(75, 28);
			btnFind.TabIndex = 23;
			btnFind.Text = "Consultar";
			btnFind.UseVisualStyleBackColor = true;
			btnFind.Click += btnFind_Click;
			// 
			// txtId
			// 
			txtId.Location = new Point(90, 12);
			txtId.Name = "txtId";
			txtId.Size = new Size(100, 23);
			txtId.TabIndex = 22;
			txtId.KeyPress += txtId_KeyPress;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(15, 15);
			label5.Name = "label5";
			label5.Size = new Size(66, 15);
			label5.TabIndex = 21;
			label5.Text = "IdProducto";
			// 
			// txtnombre
			// 
			txtnombre.BorderStyle = BorderStyle.FixedSingle;
			txtnombre.CharacterCasing = CharacterCasing.Upper;
			txtnombre.Location = new Point(90, 56);
			txtnombre.Name = "txtnombre";
			txtnombre.ReadOnly = true;
			txtnombre.Size = new Size(222, 23);
			txtnombre.TabIndex = 20;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 60);
			label1.Name = "label1";
			label1.Size = new Size(51, 15);
			label1.TabIndex = 19;
			label1.Text = "Nombre";
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(97, 107);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(93, 32);
			btnDelete.TabIndex = 24;
			btnDelete.Text = "Eliminar";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// FrmDeleteProd
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(338, 151);
			Controls.Add(btnDelete);
			Controls.Add(btnFind);
			Controls.Add(txtId);
			Controls.Add(label5);
			Controls.Add(txtnombre);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FrmDeleteProd";
			Text = "Eliminar Producto";
			Load += FrmDeleteProd_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnFind;
		private TextBox txtId;
		private Label label5;
		private TextBox txtnombre;
		private Label label1;
		private Button btnDelete;
	}
}