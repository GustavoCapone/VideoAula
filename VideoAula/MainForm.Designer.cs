/*
 * Criado por SharpDevelop.
 * Usuário: nti
 * Data: 18/10/2022
 * Hora: 09:05
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace VideoAula
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox carro;
		private System.Windows.Forms.CheckBox aviao;
		private System.Windows.Forms.CheckBox moto;
		private System.Windows.Forms.Button play;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.carro = new System.Windows.Forms.CheckBox();
			this.aviao = new System.Windows.Forms.CheckBox();
			this.moto = new System.Windows.Forms.CheckBox();
			this.play = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// carro
			// 
			this.carro.Location = new System.Drawing.Point(13, 13);
			this.carro.Name = "carro";
			this.carro.Size = new System.Drawing.Size(104, 24);
			this.carro.TabIndex = 0;
			this.carro.Text = "carro";
			this.carro.UseVisualStyleBackColor = true;
			this.carro.CheckedChanged += new System.EventHandler(this.CarroCheckedChanged);
			// 
			// aviao
			// 
			this.aviao.Location = new System.Drawing.Point(13, 44);
			this.aviao.Name = "aviao";
			this.aviao.Size = new System.Drawing.Size(104, 24);
			this.aviao.TabIndex = 1;
			this.aviao.Text = "aviao";
			this.aviao.UseVisualStyleBackColor = true;
			// 
			// moto
			// 
			this.moto.Location = new System.Drawing.Point(13, 75);
			this.moto.Name = "moto";
			this.moto.Size = new System.Drawing.Size(104, 24);
			this.moto.TabIndex = 2;
			this.moto.Text = "moto";
			this.moto.UseVisualStyleBackColor = true;
			// 
			// play
			// 
			this.play.Location = new System.Drawing.Point(147, 44);
			this.play.Name = "play";
			this.play.Size = new System.Drawing.Size(75, 23);
			this.play.TabIndex = 3;
			this.play.Text = "play";
			this.play.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.play);
			this.Controls.Add(this.moto);
			this.Controls.Add(this.aviao);
			this.Controls.Add(this.carro);
			this.Name = "MainForm";
			this.Text = "VideoAula";
			this.ResumeLayout(false);

		}
	}
}
