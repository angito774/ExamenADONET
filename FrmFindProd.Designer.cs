namespace ExamenADONET
{
	partial class FrmFindProd
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
			dtfecha = new DateTimePicker();
			label4 = new Label();
			txtstock = new TextBox();
			label3 = new Label();
			txtprecio = new TextBox();
			label2 = new Label();
			txtnombre = new TextBox();
			label1 = new Label();
			label5 = new Label();
			txtId = new TextBox();
			btnFind = new Button();
			SuspendLayout();
			// 
			// dtfecha
			// 
			dtfecha.Enabled = false;
			dtfecha.Format = DateTimePickerFormat.Short;
			dtfecha.Location = new Point(90, 170);
			dtfecha.Name = "dtfecha";
			dtfecha.Size = new Size(103, 23);
			dtfecha.TabIndex = 15;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(39, 174);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 14;
			label4.Text = "Fecha";
			// 
			// txtstock
			// 
			txtstock.BorderStyle = BorderStyle.FixedSingle;
			txtstock.Location = new Point(90, 140);
			txtstock.Name = "txtstock";
			txtstock.ReadOnly = true;
			txtstock.Size = new Size(100, 23);
			txtstock.TabIndex = 13;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(41, 145);
			label3.Name = "label3";
			label3.Size = new Size(36, 15);
			label3.TabIndex = 12;
			label3.Text = "Stock";
			// 
			// txtprecio
			// 
			txtprecio.BorderStyle = BorderStyle.FixedSingle;
			txtprecio.Location = new Point(90, 107);
			txtprecio.Name = "txtprecio";
			txtprecio.ReadOnly = true;
			txtprecio.Size = new Size(100, 23);
			txtprecio.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(41, 110);
			label2.Name = "label2";
			label2.Size = new Size(40, 15);
			label2.TabIndex = 10;
			label2.Text = "Precio";
			// 
			// txtnombre
			// 
			txtnombre.BorderStyle = BorderStyle.FixedSingle;
			txtnombre.CharacterCasing = CharacterCasing.Upper;
			txtnombre.Location = new Point(90, 68);
			txtnombre.Name = "txtnombre";
			txtnombre.ReadOnly = true;
			txtnombre.Size = new Size(222, 23);
			txtnombre.TabIndex = 9;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 72);
			label1.Name = "label1";
			label1.Size = new Size(51, 15);
			label1.TabIndex = 8;
			label1.Text = "Nombre";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(15, 27);
			label5.Name = "label5";
			label5.Size = new Size(66, 15);
			label5.TabIndex = 16;
			label5.Text = "IdProducto";
			// 
			// txtId
			// 
			txtId.Location = new Point(90, 24);
			txtId.Name = "txtId";
			txtId.Size = new Size(100, 23);
			txtId.TabIndex = 17;
			// 
			// btnFind
			// 
			btnFind.Location = new Point(200, 20);
			btnFind.Name = "btnFind";
			btnFind.Size = new Size(75, 28);
			btnFind.TabIndex = 18;
			btnFind.Text = "Consultar";
			btnFind.UseVisualStyleBackColor = true;
			btnFind.Click += btnFind_Click;
			// 
			// FrmFindProd
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(319, 206);
			Controls.Add(btnFind);
			Controls.Add(txtId);
			Controls.Add(label5);
			Controls.Add(dtfecha);
			Controls.Add(label4);
			Controls.Add(txtstock);
			Controls.Add(label3);
			Controls.Add(txtprecio);
			Controls.Add(label2);
			Controls.Add(txtnombre);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FrmFindProd";
			Text = "Consultar Producto";
			Load += FrmFindProd_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dtfecha;
		private Label label4;
		private TextBox txtstock;
		private Label label3;
		private TextBox txtprecio;
		private Label label2;
		private TextBox txtnombre;
		private Label label1;
		private Label label5;
		private TextBox txtId;
		private Button btnFind;
	}
}