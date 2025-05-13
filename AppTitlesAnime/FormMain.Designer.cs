namespace AppTitlesAnime
{
    partial class FormMain
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
            btnShowTypes = new Button();
            btnShowGenres = new Button();
            btnShowStatuses = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            btnShowTitles = new Button();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.ForeColor = SystemColors.ControlText;
            btnShowTypes.Location = new Point(13, 13);
            btnShowTypes.Name = "btnShowTypes";
            btnShowTypes.Size = new Size(313, 35);
            btnShowTypes.TabIndex = 0;
            btnShowTypes.Text = "Отобразить список \"Типы аниме\"";
            btnShowTypes.UseVisualStyleBackColor = true;
            btnShowTypes.Click += BtnShowTypes_Click;
            // 
            // btnShowGenres
            // 
            btnShowGenres.AutoSize = true;
            btnShowGenres.Location = new Point(13, 54);
            btnShowGenres.Name = "btnShowGenres";
            btnShowGenres.Size = new Size(329, 35);
            btnShowGenres.TabIndex = 0;
            btnShowGenres.Text = "Отобразить список \"Жанры аниме\"";
            btnShowGenres.UseVisualStyleBackColor = true;
            btnShowGenres.Click += BtnShowGenres_Click;
            // 
            // btnShowStatuses
            // 
            btnShowStatuses.AutoSize = true;
            btnShowStatuses.Location = new Point(13, 95);
            btnShowStatuses.Name = "btnShowStatuses";
            btnShowStatuses.Size = new Size(337, 35);
            btnShowStatuses.TabIndex = 1;
            btnShowStatuses.Text = "Отобразить список \"Статусы аниме\"";
            btnShowStatuses.UseVisualStyleBackColor = true;
            btnShowStatuses.Click += BtnShowStatuses_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(btnShowTypes);
            flowLayoutPanel.Controls.Add(btnShowGenres);
            flowLayoutPanel.Controls.Add(btnShowStatuses);
            flowLayoutPanel.Controls.Add(btnShowTitles);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(10);
            flowLayoutPanel.Size = new Size(559, 357);
            flowLayoutPanel.TabIndex = 2;
            // 
            // btnShowTitles
            // 
            btnShowTitles.AutoSize = true;
            btnShowTitles.ForeColor = SystemColors.ControlText;
            btnShowTitles.Location = new Point(13, 136);
            btnShowTitles.Name = "btnShowTitles";
            btnShowTitles.Size = new Size(313, 35);
            btnShowTitles.TabIndex = 2;
            btnShowTitles.Text = "Отобразить список \"Аниме\"";
            btnShowTitles.UseVisualStyleBackColor = true;
            btnShowTitles.Click += BtnShowTitles_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(559, 357);
            Controls.Add(flowLayoutPanel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowTypes;
        private Button btnShowGenres;
        private Button btnShowStatuses;
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnShowTitles;
    }
}
