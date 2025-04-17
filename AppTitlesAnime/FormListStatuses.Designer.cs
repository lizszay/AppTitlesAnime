namespace AppTitlesAnime
{
    partial class FormListStatuses
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
            Top = new FlowLayoutPanel();
            btnAddStatus = new Button();
            btnUpdateStatus = new Button();
            btnDeleteStatus = new Button();
            dataGridViewStatuses = new DataGridView();
            panelFill = new Panel();
            Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // Top
            // 
            Top.AutoSize = true;
            Top.Controls.Add(btnAddStatus);
            Top.Controls.Add(btnUpdateStatus);
            Top.Controls.Add(btnDeleteStatus);
            Top.Dock = DockStyle.Top;
            Top.Location = new Point(0, 0);
            Top.Name = "Top";
            Top.Padding = new Padding(10);
            Top.Size = new Size(562, 61);
            Top.TabIndex = 0;
            // 
            // btnAddStatus
            // 
            btnAddStatus.AutoSize = true;
            btnAddStatus.Location = new Point(13, 13);
            btnAddStatus.Name = "btnAddStatus";
            btnAddStatus.Size = new Size(106, 35);
            btnAddStatus.TabIndex = 0;
            btnAddStatus.Text = "Добавить";
            btnAddStatus.UseVisualStyleBackColor = true;
            btnAddStatus.Click += BtnAddStatus_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.AutoSize = true;
            btnUpdateStatus.Location = new Point(125, 13);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(107, 35);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Изменить";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStatus
            // 
            btnDeleteStatus.AutoSize = true;
            btnDeleteStatus.Location = new Point(238, 13);
            btnDeleteStatus.Name = "btnDeleteStatus";
            btnDeleteStatus.Size = new Size(92, 35);
            btnDeleteStatus.TabIndex = 2;
            btnDeleteStatus.Text = "Удалить";
            btnDeleteStatus.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStatuses
            // 
            dataGridViewStatuses.BackgroundColor = Color.White;
            dataGridViewStatuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatuses.Dock = DockStyle.Fill;
            dataGridViewStatuses.Location = new Point(10, 10);
            dataGridViewStatuses.Name = "dataGridViewStatuses";
            dataGridViewStatuses.Size = new Size(542, 266);
            dataGridViewStatuses.TabIndex = 1;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewStatuses);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(562, 286);
            panelFill.TabIndex = 2;
            // 
            // FormListStatuses
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(562, 347);
            Controls.Add(panelFill);
            Controls.Add(Top);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListStatuses";
            Text = "Список статусов аниме";
            Top.ResumeLayout(false);
            Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel Top;
        private Button btnAddStatus;
        private Button btnUpdateStatus;
        private Button btnDeleteStatus;
        private DataGridView dataGridViewStatuses;
        private Panel panelFill;
    }
}