namespace ExamenADONET
{
	partial class FrmUpdateProd
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
			dtfecha = new DateTimePicker();
			label4 = new Label();
			txtstock = new TextBox();
			label3 = new Label();
			txtprecio = new TextBox();
			label2 = new Label();
			txtnombre = new TextBox();
			label1 = new Label();
			btnUpdate = new Button();
			SuspendLayout();
			// 
			// btnFind
			// 
			btnFind.Location = new Point(197, 8);
			btnFind.Name = "btnFind";
			btnFind.Size = new Size(75, 28);
			btnFind.TabIndex = 29;
			btnFind.Text = "Consultar";
			btnFind.UseVisualStyleBackColor = true;
			btnFind.Click += btnFind_Click;
			// 
			// txtId
			// 
			txtId.Location = new Point(87, 12);
			txtId.Name = "txtId";
			txtId.Size = new Size(100, 23);
			txtId.TabIndex = 28;
			txtId.KeyPress += txtId_KeyPress;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 15);
			label5.Name = "label5";
			label5.Size = new Size(66, 15);
			label5.TabIndex = 27;
			label5.Text = "IdProducto";
			// 
			// dtfecha
			// 
			dtfecha.Format = DateTimePickerFormat.Short;
			dtfecha.Location = new Point(87, 158);
			dtfecha.Name = "dtfecha";
			dtfecha.Size = new Size(103, 23);
			dtfecha.TabIndex = 26;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(36, 162);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 25;
			label4.Text = "Fecha";
			// 
			// txtstock
			// 
			txtstock.BorderStyle = BorderStyle.FixedSingle;
			txtstock.Location = new Point(87, 128);
			txtstock.Name = "txtstock";
			txtstock.Size = new Size(100, 23);
			txtstock.TabIndex = 24;
			txtstock.KeyPress += txtstock_KeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(38, 133);
			label3.Name = "label3";
			label3.Size = new Size(36, 15);
			label3.TabIndex = 23;
			label3.Text = "Stock";
			// 
			// txtprecio
			// 
			txtprecio.BorderStyle = BorderStyle.FixedSingle;
			txtprecio.Location = new Point(87, 95);
			txtprecio.Name = "txtprecio";
			txtprecio.Size = new Size(100, 23);
			txtprecio.TabIndex = 22;
			txtprecio.KeyPress += txtprecio_KeyPress;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(38, 98);
			label2.Name = "label2";
			label2.Size = new Size(40, 15);
			label2.TabIndex = 21;
			label2.Text = "Precio";
			// 
			// txtnombre
			// 
			txtnombre.BorderStyle = BorderStyle.FixedSingle;
			txtnombre.CharacterCasing = CharacterCasing.Upper;
			txtnombre.Location = new Point(87, 56);
			txtnombre.Name = "txtnombre";
			txtnombre.Size = new Size(222, 23);
			txtnombre.TabIndex = 20;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(27, 60);
			label1.Name = "label1";
			label1.Size = new Size(51, 15);
			label1.TabIndex = 19;
			label1.Text = "Nombre";
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(95, 198);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(92, 29);
			btnUpdate.TabIndex = 30;
			btnUpdate.Text = "Actualizar";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// FrmUpdateProd
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(316, 239);
			Controls.Add(btnUpdate);
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
			Name = "FrmUpdateProd";
			Text = "Actualizar Producto";
			Load += FrmUpdateProd_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnFind;
		private TextBox txtId;
		private Label label5;
		private DateTimePicker dtfecha;
		private Label label4;
		private TextBox txtstock;
		private Label label3;
		private TextBox txtprecio;
		private Label label2;
		private TextBox txtnombre;
		private Label label1;
		private Button btnUpdate;
	}
}