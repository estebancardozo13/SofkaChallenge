
namespace Sofka_challenge
{
    partial class FormVerHistoricos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerHistoricos));
            this.lstHistoricos = new System.Windows.Forms.ListView();
            this.colJugador = new System.Windows.Forms.ColumnHeader();
            this.colPuntos = new System.Windows.Forms.ColumnHeader();
            this.colFecha = new System.Windows.Forms.ColumnHeader();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHistoricos
            // 
            this.lstHistoricos.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstHistoricos.AllowColumnReorder = true;
            this.lstHistoricos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lstHistoricos.BackgroundImage = global::Sofka_challenge.Properties.Resources.background;
            this.lstHistoricos.BackgroundImageTiled = true;
            this.lstHistoricos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHistoricos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colJugador,
            this.colPuntos,
            this.colFecha});
            this.lstHistoricos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstHistoricos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(102)))), ((int)(((byte)(68)))));
            this.lstHistoricos.FullRowSelect = true;
            this.lstHistoricos.HideSelection = false;
            this.lstHistoricos.Location = new System.Drawing.Point(2, 0);
            this.lstHistoricos.Name = "lstHistoricos";
            this.lstHistoricos.Size = new System.Drawing.Size(388, 391);
            this.lstHistoricos.TabIndex = 0;
            this.lstHistoricos.UseCompatibleStateImageBehavior = false;
            this.lstHistoricos.View = System.Windows.Forms.View.Details;
            // 
            // colJugador
            // 
            this.colJugador.Text = "Jugador";
            this.colJugador.Width = 100;
            // 
            // colPuntos
            // 
            this.colPuntos.Text = "Puntos";
            this.colPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFecha.Width = 225;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(102)))), ((int)(((byte)(68)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(18, 394);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(161, 47);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormVerHistoricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sofka_challenge.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstHistoricos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerHistoricos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVerHistoricos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVerHistoricos_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstHistoricos;
        private System.Windows.Forms.ColumnHeader colJugador;
        private System.Windows.Forms.ColumnHeader colPuntos;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.Button btnVolver;
    }
}