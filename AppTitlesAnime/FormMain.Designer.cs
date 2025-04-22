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
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.ForeColor = SystemColors.ControlText;
            btnShowTypes.Location = new Point(12, 12);
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
            btnShowGenres.Location = new Point(12, 53);
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
            btnShowStatuses.Location = new Point(12, 94);
            btnShowStatuses.Name = "btnShowStatuses";
            btnShowStatuses.Size = new Size(337, 35);
            btnShowStatuses.TabIndex = 1;
            btnShowStatuses.Text = "Отобразить список \"Статусы аниме\"";
            btnShowStatuses.UseVisualStyleBackColor = true;
            btnShowStatuses.Click += BtnShowStatuses_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(559, 357);
            Controls.Add(btnShowStatuses);
            Controls.Add(btnShowGenres);
            Controls.Add(btnShowTypes);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowTypes;
        private Button btnShowGenres;
        private Button btnShowStatuses;
    }
}
