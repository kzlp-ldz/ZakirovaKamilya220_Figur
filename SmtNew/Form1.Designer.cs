
namespace SmtNew
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_safe = new System.Windows.Forms.Button();
            this.num_width = new System.Windows.Forms.NumericUpDown();
            this.btn_color = new System.Windows.Forms.Button();
            this.lb_choose = new System.Windows.Forms.ListBox();
            this.figureData = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Draw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.figureData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 561);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.Controls.Add(this.btn_load);
            this.pnl_Draw.Controls.Add(this.btn_safe);
            this.pnl_Draw.Controls.Add(this.num_width);
            this.pnl_Draw.Controls.Add(this.btn_color);
            this.pnl_Draw.Controls.Add(this.lb_choose);
            this.pnl_Draw.Controls.Add(this.figureData);
            this.pnl_Draw.Location = new System.Drawing.Point(750, -5);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(363, 568);
            this.pnl_Draw.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(196, 457);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(117, 49);
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_safe
            // 
            this.btn_safe.Location = new System.Drawing.Point(37, 457);
            this.btn_safe.Name = "btn_safe";
            this.btn_safe.Size = new System.Drawing.Size(112, 48);
            this.btn_safe.TabIndex = 4;
            this.btn_safe.Text = "Safe";
            this.btn_safe.UseVisualStyleBackColor = true;
            // 
            // num_width
            // 
            this.num_width.Location = new System.Drawing.Point(8, 397);
            this.num_width.Name = "num_width";
            this.num_width.Size = new System.Drawing.Size(343, 22);
            this.num_width.TabIndex = 3;
            this.num_width.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.Black;
            this.btn_color.Location = new System.Drawing.Point(8, 342);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(343, 23);
            this.btn_color.TabIndex = 2;
            this.btn_color.UseVisualStyleBackColor = false;
            // 
            // lb_choose
            // 
            this.lb_choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_choose.FormattingEnabled = true;
            this.lb_choose.ItemHeight = 22;
            this.lb_choose.Items.AddRange(new object[] {
            "Circle",
            "Line",
            "Treangle",
            "Rectangle"});
            this.lb_choose.Location = new System.Drawing.Point(8, 17);
            this.lb_choose.Name = "lb_choose";
            this.lb_choose.Size = new System.Drawing.Size(343, 92);
            this.lb_choose.TabIndex = 1;
            this.lb_choose.SelectedIndexChanged += new System.EventHandler(this.lb_choose_SelectedIndexChanged);
            // 
            // figureData
            // 
            this.figureData.AllowUserToDeleteRows = false;
            this.figureData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.figureData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.val});
            this.figureData.Location = new System.Drawing.Point(8, 126);
            this.figureData.Name = "figureData";
            this.figureData.ReadOnly = true;
            this.figureData.RowHeadersWidth = 51;
            this.figureData.RowTemplate.Height = 24;
            this.figureData.Size = new System.Drawing.Size(343, 192);
            this.figureData.TabIndex = 0;
            this.figureData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.figureData_CellContentClick);
            // 
            // key
            // 
            this.key.HeaderText = "";
            this.key.MinimumWidth = 6;
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.Width = 125;
            // 
            // val
            // 
            this.val.HeaderText = "";
            this.val.MinimumWidth = 6;
            this.val.Name = "val";
            this.val.ReadOnly = true;
            this.val.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 561);
            this.Controls.Add(this.pnl_Draw);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Draw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.figureData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.DataGridView figureData;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.ListBox lb_choose;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown num_width;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_safe;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn val;
    }
}

