﻿namespace This_Time_It_Will_Work
{
    partial class EntriesManipulationForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.get_table = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedList_atribytes = new System.Windows.Forms.CheckedListBox();
            this.Optional_table = new System.Windows.Forms.DataGridView();
            this.button_do = new System.Windows.Forms.Button();
            this.textBox_inputKey = new System.Windows.Forms.TextBox();
            this.label_inputKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Optional_table)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(9, 409);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(171, 37);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(575, 272);
            this.button_select.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(171, 26);
            this.button_select.TabIndex = 2;
            this.button_select.Text = "SELECT";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_insert.Location = new System.Drawing.Point(575, 302);
            this.button_insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(171, 26);
            this.button_insert.TabIndex = 3;
            this.button_insert.Text = "INSERT";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(575, 360);
            this.button_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(171, 25);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(575, 331);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(171, 25);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите таблицу";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(8, 8);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(535, 290);
            this.dataGridView.TabIndex = 12;
            // 
            // get_table
            // 
            this.get_table.FormattingEnabled = true;
            this.get_table.Location = new System.Drawing.Point(578, 40);
            this.get_table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.get_table.Name = "get_table";
            this.get_table.Size = new System.Drawing.Size(172, 21);
            this.get_table.TabIndex = 13;
            this.get_table.TextChanged += new System.EventHandler(this.get_table_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выберите атрибуты необходимые атрибуты";
            // 
            // checkedList_atribytes
            // 
            this.checkedList_atribytes.CheckOnClick = true;
            this.checkedList_atribytes.FormattingEnabled = true;
            this.checkedList_atribytes.Location = new System.Drawing.Point(578, 103);
            this.checkedList_atribytes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedList_atribytes.Name = "checkedList_atribytes";
            this.checkedList_atribytes.Size = new System.Drawing.Size(169, 139);
            this.checkedList_atribytes.TabIndex = 16;
            this.checkedList_atribytes.SelectedIndexChanged += new System.EventHandler(this.checkedList_atribytes_SelectedIndexChanged);
            this.checkedList_atribytes.SelectedValueChanged += new System.EventHandler(this.checkedList_atribytes_SelectedValueChanged);
            this.checkedList_atribytes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.checkedList_atribytes_MouseDoubleClick);
            // 
            // Optional_table
            // 
            this.Optional_table.AllowUserToAddRows = false;
            this.Optional_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Optional_table.Location = new System.Drawing.Point(8, 311);
            this.Optional_table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Optional_table.Name = "Optional_table";
            this.Optional_table.RowHeadersWidth = 62;
            this.Optional_table.RowTemplate.Height = 28;
            this.Optional_table.Size = new System.Drawing.Size(535, 88);
            this.Optional_table.TabIndex = 17;
            // 
            // button_do
            // 
            this.button_do.Location = new System.Drawing.Point(491, 311);
            this.button_do.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_do.Name = "button_do";
            this.button_do.Size = new System.Drawing.Size(52, 88);
            this.button_do.TabIndex = 18;
            this.button_do.Text = "Далее";
            this.button_do.UseVisualStyleBackColor = true;
            this.button_do.Click += new System.EventHandler(this.button_do_Click);
            // 
            // textBox_inputKey
            // 
            this.textBox_inputKey.Location = new System.Drawing.Point(17, 324);
            this.textBox_inputKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_inputKey.Name = "textBox_inputKey";
            this.textBox_inputKey.Size = new System.Drawing.Size(173, 20);
            this.textBox_inputKey.TabIndex = 19;
            this.textBox_inputKey.TextChanged += new System.EventHandler(this.textBox_inputKey_TextChanged);
            // 
            // label_inputKey
            // 
            this.label_inputKey.AutoSize = true;
            this.label_inputKey.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_inputKey.Location = new System.Drawing.Point(200, 326);
            this.label_inputKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_inputKey.Name = "label_inputKey";
            this.label_inputKey.Size = new System.Drawing.Size(204, 13);
            this.label_inputKey.TabIndex = 20;
            this.label_inputKey.Text = "Введите значение ключевого атрибута";
            // 
            // EntriesManipulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_inputKey);
            this.Controls.Add(this.textBox_inputKey);
            this.Controls.Add(this.button_do);
            this.Controls.Add(this.Optional_table);
            this.Controls.Add(this.checkedList_atribytes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.get_table);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.buttonBack);
            this.Name = "EntriesManipulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntriesManipulationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntriesManipulationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Optional_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox get_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedList_atribytes;
        private System.Windows.Forms.DataGridView Optional_table;
        private System.Windows.Forms.Button button_do;
        private System.Windows.Forms.TextBox textBox_inputKey;
        private System.Windows.Forms.Label label_inputKey;
    }
}