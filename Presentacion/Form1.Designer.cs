namespace Presentacion
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
            dgvRegions = new DataGridView();
            txt_nombreRegion = new TextBox();
            groupBox1 = new GroupBox();
            btn_registarRegion = new Button();
            groupBox2 = new GroupBox();
            btn_eliminarRegion = new Button();
            txt_id = new TextBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtRegionModificado = new TextBox();
            button1 = new Button();
            txtIdEditar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegions).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRegions
            // 
            dgvRegions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegions.Location = new Point(31, 125);
            dgvRegions.Name = "dgvRegions";
            dgvRegions.Size = new Size(428, 188);
            dgvRegions.TabIndex = 0;
            // 
            // txt_nombreRegion
            // 
            txt_nombreRegion.Location = new Point(6, 37);
            txt_nombreRegion.Name = "txt_nombreRegion";
            txt_nombreRegion.Size = new Size(188, 23);
            txt_nombreRegion.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_registarRegion);
            groupBox1.Controls.Add(txt_nombreRegion);
            groupBox1.Location = new Point(31, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 80);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Region";
            // 
            // btn_registarRegion
            // 
            btn_registarRegion.Location = new Point(200, 36);
            btn_registarRegion.Name = "btn_registarRegion";
            btn_registarRegion.Size = new Size(75, 23);
            btn_registarRegion.TabIndex = 2;
            btn_registarRegion.Text = "Registrar";
            btn_registarRegion.UseVisualStyleBackColor = true;
            btn_registarRegion.Click += btn_registarRegion_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_eliminarRegion);
            groupBox2.Controls.Add(txt_id);
            groupBox2.Location = new Point(366, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 80);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Id";
            // 
            // btn_eliminarRegion
            // 
            btn_eliminarRegion.Location = new Point(116, 37);
            btn_eliminarRegion.Name = "btn_eliminarRegion";
            btn_eliminarRegion.Size = new Size(113, 23);
            btn_eliminarRegion.TabIndex = 2;
            btn_eliminarRegion.Text = "Eliminar Region";
            btn_eliminarRegion.UseVisualStyleBackColor = true;
            btn_eliminarRegion.Click += btn_eliminarRegion_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(6, 37);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(104, 23);
            txt_id.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtRegionModificado);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(txtIdEditar);
            groupBox3.Location = new Point(482, 125);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(213, 175);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Editar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 5;
            label2.Text = "id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Modificado";
            // 
            // txtRegionModificado
            // 
            txtRegionModificado.Location = new Point(6, 104);
            txtRegionModificado.Name = "txtRegionModificado";
            txtRegionModificado.Size = new Size(188, 23);
            txtRegionModificado.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(6, 146);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIdEditar
            // 
            txtIdEditar.Location = new Point(6, 51);
            txtIdEditar.Name = "txtIdEditar";
            txtIdEditar.Size = new Size(188, 23);
            txtIdEditar.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 342);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvRegions);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegions).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRegions;
        private TextBox txt_nombreRegion;
        private GroupBox groupBox1;
        private Button btn_registarRegion;
        private GroupBox groupBox2;
        private Button btn_eliminarRegion;
        private TextBox txt_id;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private TextBox txtRegionModificado;
        private Button button1;
        private TextBox txtIdEditar;
    }
}
