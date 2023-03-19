
namespace WindowsFormsApp1
{
    partial class ГлавноеМеню
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_tip = new System.Windows.Forms.TextBox();
            this.textBox_kol = new System.Windows.Forms.TextBox();
            this.textBox_post = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.new_zapis_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.izmenit_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox_update = new System.Windows.Forms.PictureBox();
            this.pictureBox_delete = new System.Windows.Forms.PictureBox();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(166, 476);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(240, 22);
            this.textBox_ID.TabIndex = 3;
            // 
            // textBox_tip
            // 
            this.textBox_tip.Location = new System.Drawing.Point(166, 504);
            this.textBox_tip.Name = "textBox_tip";
            this.textBox_tip.Size = new System.Drawing.Size(240, 22);
            this.textBox_tip.TabIndex = 4;
            // 
            // textBox_kol
            // 
            this.textBox_kol.Location = new System.Drawing.Point(166, 532);
            this.textBox_kol.Name = "textBox_kol";
            this.textBox_kol.Size = new System.Drawing.Size(240, 22);
            this.textBox_kol.TabIndex = 5;
            // 
            // textBox_post
            // 
            this.textBox_post.Location = new System.Drawing.Point(166, 560);
            this.textBox_post.Name = "textBox_post";
            this.textBox_post.Size = new System.Drawing.Size(240, 22);
            this.textBox_post.TabIndex = 6;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(166, 588);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(240, 22);
            this.textBox_price.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип товара:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Поставщик:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 593);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Цена:";
            // 
            // new_zapis_button
            // 
            this.new_zapis_button.Location = new System.Drawing.Point(806, 492);
            this.new_zapis_button.Name = "new_zapis_button";
            this.new_zapis_button.Size = new System.Drawing.Size(108, 50);
            this.new_zapis_button.TabIndex = 13;
            this.new_zapis_button.Text = "Новая запись";
            this.new_zapis_button.UseVisualStyleBackColor = true;
            this.new_zapis_button.Click += new System.EventHandler(this.new_zapis_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(806, 549);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(108, 50);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // izmenit_button
            // 
            this.izmenit_button.Location = new System.Drawing.Point(944, 491);
            this.izmenit_button.Name = "izmenit_button";
            this.izmenit_button.Size = new System.Drawing.Size(89, 50);
            this.izmenit_button.TabIndex = 15;
            this.izmenit_button.Text = "Изменить";
            this.izmenit_button.UseVisualStyleBackColor = true;
            this.izmenit_button.Click += new System.EventHandler(this.izmenit_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(944, 549);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(89, 50);
            this.save_button.TabIndex = 16;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Запись:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(806, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Управление записями:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1491, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1259, 250);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.pictureBox_update);
            this.tabPage1.Controls.Add(this.pictureBox_delete);
            this.tabPage1.Controls.Add(this.pictureBox_search);
            this.tabPage1.Controls.Add(this.textBox_search);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1259, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отдел №1";
            // 
            // pictureBox_update
            // 
            this.pictureBox_update.Image = global::WindowsFormsApp1.Properties.Resources.Без_названия;
            this.pictureBox_update.Location = new System.Drawing.Point(827, 17);
            this.pictureBox_update.Name = "pictureBox_update";
            this.pictureBox_update.Size = new System.Drawing.Size(57, 57);
            this.pictureBox_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_update.TabIndex = 3;
            this.pictureBox_update.TabStop = false;
            this.pictureBox_update.Click += new System.EventHandler(this.pictureBox_update_Click);
            // 
            // pictureBox_delete
            // 
            this.pictureBox_delete.Image = global::WindowsFormsApp1.Properties.Resources._77705;
            this.pictureBox_delete.Location = new System.Drawing.Point(746, 17);
            this.pictureBox_delete.Name = "pictureBox_delete";
            this.pictureBox_delete.Size = new System.Drawing.Size(65, 57);
            this.pictureBox_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_delete.TabIndex = 2;
            this.pictureBox_delete.TabStop = false;
            this.pictureBox_delete.Click += new System.EventHandler(this.pictureBox_delete_Click);
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Image = global::WindowsFormsApp1.Properties.Resources._3917754;
            this.pictureBox_search.Location = new System.Drawing.Point(903, 17);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(56, 57);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_search.TabIndex = 1;
            this.pictureBox_search.TabStop = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(998, 31);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(155, 22);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1267, 123);
            this.tabControl1.TabIndex = 21;
            this.tabControl1.Tag = "Отдел №1";
            // 
            // ГлавноеМеню
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 631);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.izmenit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.new_zapis_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_post);
            this.Controls.Add(this.textBox_kol);
            this.Controls.Add(this.textBox_tip);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ГлавноеМеню";
            this.Text = "Главное меню приложения";
            this.Load += new System.EventHandler(this.ГлавноеМеню_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_tip;
        private System.Windows.Forms.TextBox textBox_kol;
        private System.Windows.Forms.TextBox textBox_post;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button new_zapis_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button izmenit_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox_delete;
        private System.Windows.Forms.PictureBox pictureBox_update;
    }
}