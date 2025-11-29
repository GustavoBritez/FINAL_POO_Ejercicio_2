namespace Granja
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
            Grilla_Granja = new DataGridView();
            label1 = new Label();
            BTN_AGREGAR = new Button();
            TXT_Nombre = new TextBox();
            label2 = new Label();
            BTN_Eliminar = new Button();
            CB_ESPECIE = new ComboBox();
            BTN_ALIMENTAR = new Button();
            ((System.ComponentModel.ISupportInitialize)Grilla_Granja).BeginInit();
            SuspendLayout();
            // 
            // Grilla_Granja
            // 
            Grilla_Granja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Granja.Location = new Point(28, 40);
            Grilla_Granja.Name = "Grilla_Granja";
            Grilla_Granja.Size = new Size(460, 175);
            Grilla_Granja.TabIndex = 0;
            Grilla_Granja.CellFormatting += Grilla_Granja_CellFormatting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 22);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Granja";
            // 
            // BTN_AGREGAR
            // 
            BTN_AGREGAR.Location = new Point(500, 158);
            BTN_AGREGAR.Name = "BTN_AGREGAR";
            BTN_AGREGAR.Size = new Size(75, 23);
            BTN_AGREGAR.TabIndex = 2;
            BTN_AGREGAR.Text = "Agregar";
            BTN_AGREGAR.UseVisualStyleBackColor = true;
            BTN_AGREGAR.Click += BTN_AGREGAR_Click;
            // 
            // TXT_Nombre
            // 
            TXT_Nombre.Location = new Point(491, 73);
            TXT_Nombre.Name = "TXT_Nombre";
            TXT_Nombre.Size = new Size(205, 23);
            TXT_Nombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(702, 81);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // BTN_Eliminar
            // 
            BTN_Eliminar.Location = new Point(630, 158);
            BTN_Eliminar.Name = "BTN_Eliminar";
            BTN_Eliminar.Size = new Size(75, 23);
            BTN_Eliminar.TabIndex = 7;
            BTN_Eliminar.Text = "Eliminar";
            BTN_Eliminar.UseVisualStyleBackColor = true;
            BTN_Eliminar.Click += BTN_Eliminar_Click;
            // 
            // CB_ESPECIE
            // 
            CB_ESPECIE.FormattingEnabled = true;
            CB_ESPECIE.Location = new Point(537, 112);
            CB_ESPECIE.Name = "CB_ESPECIE";
            CB_ESPECIE.Size = new Size(121, 23);
            CB_ESPECIE.TabIndex = 8;
            CB_ESPECIE.Text = "Selecione Especie";
            // 
            // BTN_ALIMENTAR
            // 
            BTN_ALIMENTAR.Location = new Point(565, 192);
            BTN_ALIMENTAR.Name = "BTN_ALIMENTAR";
            BTN_ALIMENTAR.Size = new Size(75, 23);
            BTN_ALIMENTAR.TabIndex = 9;
            BTN_ALIMENTAR.Text = "Alimentar";
            BTN_ALIMENTAR.UseVisualStyleBackColor = true;
            BTN_ALIMENTAR.Click += BTN_ALIMENTAR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 269);
            Controls.Add(BTN_ALIMENTAR);
            Controls.Add(CB_ESPECIE);
            Controls.Add(BTN_Eliminar);
            Controls.Add(label2);
            Controls.Add(TXT_Nombre);
            Controls.Add(BTN_AGREGAR);
            Controls.Add(label1);
            Controls.Add(Grilla_Granja);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla_Granja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Granja;
        private Label label1;
        private Button BTN_AGREGAR;
        private TextBox TXT_Nombre;
        private Label label2;
        private Button BTN_Eliminar;
        private ComboBox CB_ESPECIE;
        private Button BTN_ALIMENTAR;
    }
}
