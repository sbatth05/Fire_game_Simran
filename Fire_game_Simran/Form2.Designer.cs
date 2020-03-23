namespace Fire_game_Simran
{
    partial class Form2
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
            this.Sload_btn = new System.Windows.Forms.Button();
            this.Spin_btn = new System.Windows.Forms.Button();
            this.shoot_btn = new System.Windows.Forms.Button();
            this.shootaway_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.pbPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Sload_btn
            // 
            this.Sload_btn.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sload_btn.Location = new System.Drawing.Point(1, 12);
            this.Sload_btn.Name = "Sload_btn";
            this.Sload_btn.Size = new System.Drawing.Size(210, 44);
            this.Sload_btn.TabIndex = 0;
            this.Sload_btn.Text = "Load Once";
            this.Sload_btn.UseVisualStyleBackColor = true;
            this.Sload_btn.Click += new System.EventHandler(this.Sload_btn_Click);
            // 
            // Spin_btn
            // 
            this.Spin_btn.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin_btn.Location = new System.Drawing.Point(1, 74);
            this.Spin_btn.Name = "Spin_btn";
            this.Spin_btn.Size = new System.Drawing.Size(210, 44);
            this.Spin_btn.TabIndex = 1;
            this.Spin_btn.Text = "Spin";
            this.Spin_btn.UseVisualStyleBackColor = true;
            this.Spin_btn.Click += new System.EventHandler(this.Spin_btn_Click);
            // 
            // shoot_btn
            // 
            this.shoot_btn.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_btn.Location = new System.Drawing.Point(1, 124);
            this.shoot_btn.Name = "shoot_btn";
            this.shoot_btn.Size = new System.Drawing.Size(210, 44);
            this.shoot_btn.TabIndex = 2;
            this.shoot_btn.Text = "Shoot ";
            this.shoot_btn.UseVisualStyleBackColor = true;
            this.shoot_btn.Click += new System.EventHandler(this.shoot_btn_Click);
            // 
            // shootaway_btn
            // 
            this.shootaway_btn.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootaway_btn.Location = new System.Drawing.Point(1, 174);
            this.shootaway_btn.Name = "shootaway_btn";
            this.shootaway_btn.Size = new System.Drawing.Size(210, 44);
            this.shootaway_btn.TabIndex = 3;
            this.shootaway_btn.Text = "Shoot Away";
            this.shootaway_btn.UseVisualStyleBackColor = true;
            this.shootaway_btn.Click += new System.EventHandler(this.shootaway_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(1, 224);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(210, 44);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pbPictureBox
            // 
            this.pbPictureBox.Location = new System.Drawing.Point(285, 12);
            this.pbPictureBox.Name = "pbPictureBox";
            this.pbPictureBox.Size = new System.Drawing.Size(488, 347);
            this.pbPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictureBox.TabIndex = 5;
            this.pbPictureBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(856, 453);
            this.Controls.Add(this.pbPictureBox);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.shootaway_btn);
            this.Controls.Add(this.shoot_btn);
            this.Controls.Add(this.Spin_btn);
            this.Controls.Add(this.Sload_btn);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sload_btn;
        private System.Windows.Forms.Button Spin_btn;
        private System.Windows.Forms.Button shoot_btn;
        private System.Windows.Forms.Button shootaway_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox pbPictureBox;
    }
}