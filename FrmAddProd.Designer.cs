namespace ExamenADONET
{
	partial class FrmAddProd
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
			label1 = new Label();
			txtnombre = new TextBox();
			label2 = new Label();
			txtprecio = new TextBox();
			label3 = new Label();
			txtstock = new TextBox();
			label4 = new Label();
			dtfecha = new DateTimePicker();
			btnNew = new Button();
			btnSave = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(25, 21);
			label1.Name = "label1";
			label1.Size = new Size(51, 15);
			label1.TabIndex = 0;
			label1.Text = "Nombre";
			// 
			// txtnombre
			// 
			txtnombre.BorderStyle = BorderStyle.FixedSingle;
			txtnombre.CharacterCasing = CharacterCasing.Upper;
			txtnombre.Location = new Point(85, 17);
			txtnombre.Name = "txtnombre";
			txtnombre.Size = new Size(222, 23);
			txtnombre.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(36, 59);
			label2.Name = "label2";
			label2.Size = new Size(40, 15);
			label2.TabIndex = 2;
			label2.Text = "Precio";
			// 
			// txtprecio
			// 
			txtprecio.BorderStyle = BorderStyle.FixedSingle;
			txtprecio.Location = new Point(85, 56);
			txtprecio.Name = "txtprecio";
			txtprecio.Size = new Size(100, 23);
			txtprecio.TabIndex = 3;
			txtprecio.KeyPress += txtprecio_KeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(36, 94);
			label3.Name = "label3";
			label3.Size = new Size(36, 15);
			label3.TabIndex = 4;
			label3.Text = "Stock";
			// 
			// txtstock
			// 
			txtstock.BorderStyle = BorderStyle.FixedSingle;
			txtstock.Location = new Point(85, 89);
			txtstock.Name = "txtstock";
			txtstock.Size = new Size(100, 23);
			txtstock.TabIndex = 5;
			txtstock.KeyPress += txtstock_KeyPress;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(34, 123);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 6;
			label4.Text = "Fecha";
			// 
			// dtfecha
			// 
			dtfecha.Format = DateTimePickerFormat.Short;
			dtfecha.Location = new Point(85, 119);
			dtfecha.Name = "dtfecha";
			dtfecha.Size = new Size(103, 23);
			dtfecha.TabIndex = 7;
			// 
			// btnNew
			// 
			btnNew.Location = new Point(25, 163);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(74, 28);
			btnNew.TabIndex = 8;
			btnNew.Text = "Nuevo";
			btnNew.UseVisualStyleBackColor = true;
			btnNew.Click += btnNew_Click;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(113, 163);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 28);
			btnSave.TabIndex = 9;
			btnSave.Text = "Guardar";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// FrmAddProd
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(343, 201);
			Controls.Add(btnSave);
			Controls.Add(btnNew);
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
			Name = "FrmAddProd";
			Text = "Agregar Producto";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtnombre;
		private Label label2;
		private TextBox txtprecio;
		private Label label3;
		private TextBox txtstock;
		private Label label4;
		private DateTimePicker dtfecha;
		private Button btnNew;
		private Button btnSave;
	}
}