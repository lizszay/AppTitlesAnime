﻿namespace AppTitlesAnime
{
    partial class FormAddGenre
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
            components = new System.ComponentModel.Container();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelFill = new Panel();
            textBoxGenreName = new TextBox();
            lableGenreName = new Label();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 85);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottom.Size = new Size(434, 61);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(134, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxGenreName);
            panelFill.Controls.Add(lableGenreName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(434, 85);
            panelFill.TabIndex = 0;
            // 
            // textBoxGenreName
            // 
            textBoxGenreName.Dock = DockStyle.Top;
            textBoxGenreName.Location = new Point(10, 35);
            textBoxGenreName.Name = "textBoxGenreName";
            textBoxGenreName.Size = new Size(404, 33);
            textBoxGenreName.TabIndex = 1;
            textBoxGenreName.TextChanged += TextBoxGenreName_TextChanged;
            textBoxGenreName.Validating += TextBoxGenreName_Validating;
            // 
            // lableGenreName
            // 
            lableGenreName.AutoSize = true;
            lableGenreName.Dock = DockStyle.Top;
            lableGenreName.Location = new Point(10, 10);
            lableGenreName.Name = "lableGenreName";
            lableGenreName.Size = new Size(120, 25);
            lableGenreName.TabIndex = 0;
            lableGenreName.Text = "Жанр аниме";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddGenre
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 146);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddGenre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о жанре аниме";
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Panel panelFill;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label lableGenreName;
        protected internal TextBox textBoxGenreName;
        private ErrorProvider errorProvider;
    }
}