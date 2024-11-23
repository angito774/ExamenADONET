namespace ExamenADONET
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnAdd = new Button();
			btnConsultar = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
			SuspendLayout();
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(170, 29);
			btnAdd.Margin = new Padding(4, 3, 4, 3);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(156, 56);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "Agregar";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnConsultar
			// 
			btnConsultar.Location = new Point(170, 102);
			btnConsultar.Margin = new Padding(4, 3, 4, 3);
			btnConsultar.Name = "btnConsultar";
			btnConsultar.Size = new Size(156, 58);
			btnConsultar.TabIndex = 1;
			btnConsultar.Text = "Consultar";
			btnConsultar.UseVisualStyleBackColor = true;
			btnConsultar.Click += btnConsultar_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(170, 183);
			btnUpdate.Margin = new Padding(4, 3, 4, 3);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(156, 66);
			btnUpdate.TabIndex = 2;
			btnUpdate.Text = "Actualizar";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(170, 278);
			btnDelete.Margin = new Padding(4, 3, 4, 3);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(156, 66);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "Eliminar";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(546, 408);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnConsultar);
			Controls.Add(btnAdd);
			Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Menu Principal";
			Load += Form1_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnAdd;
		private Button btnConsultar;
		private Button btnUpdate;
		private Button btnDelete;
	}
}
