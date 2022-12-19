namespace MyWork
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
            this.autoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.idTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb4 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.autoPage = new System.Windows.Forms.TabPage();
            this.markPage = new System.Windows.Forms.TabPage();
            this.markDataGridView = new System.Windows.Forms.DataGridView();
            this.enginePage = new System.Windows.Forms.TabPage();
            this.engineDataGridView = new System.Windows.Forms.DataGridView();
            this.wheelPage = new System.Windows.Forms.TabPage();
            this.wheelDataGridView = new System.Windows.Forms.DataGridView();
            this.carnumPage = new System.Windows.Forms.TabPage();
            this.carnumDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.autoPage.SuspendLayout();
            this.markPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markDataGridView)).BeginInit();
            this.enginePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engineDataGridView)).BeginInit();
            this.wheelPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wheelDataGridView)).BeginInit();
            this.carnumPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carnumDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // autoDataGridView
            // 
            this.autoDataGridView.AllowUserToAddRows = false;
            this.autoDataGridView.AllowUserToDeleteRows = false;
            this.autoDataGridView.AllowUserToOrderColumns = true;
            this.autoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.autoDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.autoDataGridView.MultiSelect = false;
            this.autoDataGridView.Name = "autoDataGridView";
            this.autoDataGridView.ReadOnly = true;
            this.autoDataGridView.RowHeadersWidth = 51;
            this.autoDataGridView.RowTemplate.Height = 24;
            this.autoDataGridView.Size = new System.Drawing.Size(567, 472);
            this.autoDataGridView.TabIndex = 0;
            this.autoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.autoDataGridView_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(590, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // idTb
            // 
            this.idTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTb.Location = new System.Drawing.Point(590, 62);
            this.idTb.Margin = new System.Windows.Forms.Padding(2);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(317, 32);
            this.idTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(590, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(590, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Модель:";
            // 
            // Tb1
            // 
            this.Tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb1.Location = new System.Drawing.Point(590, 124);
            this.Tb1.Margin = new System.Windows.Forms.Padding(2);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(317, 32);
            this.Tb1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(590, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Марка:";
            // 
            // Tb2
            // 
            this.Tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb2.Location = new System.Drawing.Point(590, 186);
            this.Tb2.Margin = new System.Windows.Forms.Padding(2);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(317, 32);
            this.Tb2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(590, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(590, 416);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "Обновить запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(590, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Цена:";
            // 
            // Tb3
            // 
            this.Tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb3.Location = new System.Drawing.Point(590, 248);
            this.Tb3.Margin = new System.Windows.Forms.Padding(2);
            this.Tb3.Name = "Tb3";
            this.Tb3.Size = new System.Drawing.Size(317, 32);
            this.Tb3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(590, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Колличество:";
            // 
            // Tb4
            // 
            this.Tb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb4.Location = new System.Drawing.Point(590, 310);
            this.Tb4.Margin = new System.Windows.Forms.Padding(2);
            this.Tb4.Name = "Tb4";
            this.Tb4.Size = new System.Drawing.Size(317, 32);
            this.Tb4.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.autoPage);
            this.tabControl1.Controls.Add(this.markPage);
            this.tabControl1.Controls.Add(this.enginePage);
            this.tabControl1.Controls.Add(this.wheelPage);
            this.tabControl1.Controls.Add(this.carnumPage);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(10, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 500);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // autoPage
            // 
            this.autoPage.Controls.Add(this.autoDataGridView);
            this.autoPage.Location = new System.Drawing.Point(4, 24);
            this.autoPage.Name = "autoPage";
            this.autoPage.Size = new System.Drawing.Size(567, 472);
            this.autoPage.TabIndex = 0;
            this.autoPage.Text = "Autos";
            this.autoPage.UseVisualStyleBackColor = true;
            // 
            // markPage
            // 
            this.markPage.Controls.Add(this.markDataGridView);
            this.markPage.Location = new System.Drawing.Point(4, 24);
            this.markPage.Name = "markPage";
            this.markPage.Size = new System.Drawing.Size(567, 472);
            this.markPage.TabIndex = 1;
            this.markPage.Text = "Marks";
            this.markPage.UseVisualStyleBackColor = true;
            // 
            // markDataGridView
            // 
            this.markDataGridView.AllowUserToAddRows = false;
            this.markDataGridView.AllowUserToDeleteRows = false;
            this.markDataGridView.AllowUserToOrderColumns = true;
            this.markDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markDataGridView.Location = new System.Drawing.Point(0, 0);
            this.markDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.markDataGridView.MultiSelect = false;
            this.markDataGridView.Name = "markDataGridView";
            this.markDataGridView.ReadOnly = true;
            this.markDataGridView.RowHeadersWidth = 51;
            this.markDataGridView.RowTemplate.Height = 24;
            this.markDataGridView.Size = new System.Drawing.Size(567, 472);
            this.markDataGridView.TabIndex = 1;
            this.markDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.markDataGridView_CellDoubleClick);
            // 
            // enginePage
            // 
            this.enginePage.Controls.Add(this.engineDataGridView);
            this.enginePage.Location = new System.Drawing.Point(4, 24);
            this.enginePage.Name = "enginePage";
            this.enginePage.Size = new System.Drawing.Size(567, 472);
            this.enginePage.TabIndex = 2;
            this.enginePage.Text = "Engines";
            this.enginePage.UseVisualStyleBackColor = true;
            // 
            // engineDataGridView
            // 
            this.engineDataGridView.AllowUserToAddRows = false;
            this.engineDataGridView.AllowUserToDeleteRows = false;
            this.engineDataGridView.AllowUserToOrderColumns = true;
            this.engineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.engineDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.engineDataGridView.Location = new System.Drawing.Point(0, 0);
            this.engineDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.engineDataGridView.MultiSelect = false;
            this.engineDataGridView.Name = "engineDataGridView";
            this.engineDataGridView.ReadOnly = true;
            this.engineDataGridView.RowHeadersWidth = 51;
            this.engineDataGridView.RowTemplate.Height = 24;
            this.engineDataGridView.Size = new System.Drawing.Size(567, 472);
            this.engineDataGridView.TabIndex = 1;
            this.engineDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.engineDataGridView_CellDoubleClick);
            // 
            // wheelPage
            // 
            this.wheelPage.Controls.Add(this.wheelDataGridView);
            this.wheelPage.Location = new System.Drawing.Point(4, 24);
            this.wheelPage.Name = "wheelPage";
            this.wheelPage.Size = new System.Drawing.Size(567, 472);
            this.wheelPage.TabIndex = 3;
            this.wheelPage.Text = "Wheels";
            this.wheelPage.UseVisualStyleBackColor = true;
            // 
            // wheelDataGridView
            // 
            this.wheelDataGridView.AllowUserToAddRows = false;
            this.wheelDataGridView.AllowUserToDeleteRows = false;
            this.wheelDataGridView.AllowUserToOrderColumns = true;
            this.wheelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wheelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wheelDataGridView.Location = new System.Drawing.Point(0, 0);
            this.wheelDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.wheelDataGridView.MultiSelect = false;
            this.wheelDataGridView.Name = "wheelDataGridView";
            this.wheelDataGridView.ReadOnly = true;
            this.wheelDataGridView.RowHeadersWidth = 51;
            this.wheelDataGridView.RowTemplate.Height = 24;
            this.wheelDataGridView.Size = new System.Drawing.Size(567, 472);
            this.wheelDataGridView.TabIndex = 1;
            this.wheelDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wheelDataGridView_CellDoubleClick);
            // 
            // carnumPage
            // 
            this.carnumPage.Controls.Add(this.carnumDataGridView);
            this.carnumPage.Location = new System.Drawing.Point(4, 24);
            this.carnumPage.Name = "carnumPage";
            this.carnumPage.Size = new System.Drawing.Size(567, 472);
            this.carnumPage.TabIndex = 4;
            this.carnumPage.Text = "Car Numbers";
            this.carnumPage.UseVisualStyleBackColor = true;
            // 
            // carnumDataGridView
            // 
            this.carnumDataGridView.AllowUserToAddRows = false;
            this.carnumDataGridView.AllowUserToDeleteRows = false;
            this.carnumDataGridView.AllowUserToOrderColumns = true;
            this.carnumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carnumDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carnumDataGridView.Location = new System.Drawing.Point(0, 0);
            this.carnumDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.carnumDataGridView.MultiSelect = false;
            this.carnumDataGridView.Name = "carnumDataGridView";
            this.carnumDataGridView.ReadOnly = true;
            this.carnumDataGridView.RowHeadersWidth = 51;
            this.carnumDataGridView.RowTemplate.Height = 24;
            this.carnumDataGridView.Size = new System.Drawing.Size(567, 472);
            this.carnumDataGridView.TabIndex = 1;
            this.carnumDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carnumDataGridView_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tb4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(934, 559);
            this.MinimumSize = new System.Drawing.Size(934, 559);
            this.Name = "Form1";
            this.Text = "Nyo-ho";
            ((System.ComponentModel.ISupportInitialize)(this.autoDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.autoPage.ResumeLayout(false);
            this.markPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.markDataGridView)).EndInit();
            this.enginePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.engineDataGridView)).EndInit();
            this.wheelPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wheelDataGridView)).EndInit();
            this.carnumPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carnumDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView autoDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Label label4;
        private TextBox Tb3;
        private Label label5;
        private TextBox Tb4;
        private TabControl tabControl1;
        private TabPage autoPage;
        private TabPage markPage;
        private TabPage enginePage;
        private TabPage wheelPage;
        private TabPage carnumPage;
        private DataGridView markDataGridView;
        private DataGridView engineDataGridView;
        private DataGridView wheelDataGridView;
        private DataGridView carnumDataGridView;
    }
}

