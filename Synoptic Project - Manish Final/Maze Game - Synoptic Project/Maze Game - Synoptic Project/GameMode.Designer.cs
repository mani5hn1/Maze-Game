namespace Maze_Game
{
    partial class GameMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RandomRoomButton = new System.Windows.Forms.Button();
            this.LoadingConfigFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to the Maze Game";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(291, 342);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(123, 52);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose your mode";
            // 
            // RandomRoomButton
            // 
            this.RandomRoomButton.Location = new System.Drawing.Point(376, 234);
            this.RandomRoomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RandomRoomButton.Name = "RandomRoomButton";
            this.RandomRoomButton.Size = new System.Drawing.Size(123, 52);
            this.RandomRoomButton.TabIndex = 10;
            this.RandomRoomButton.Text = "Random Room";
            this.RandomRoomButton.UseVisualStyleBackColor = true;
            this.RandomRoomButton.Click += new System.EventHandler(this.RandomRoomButton_Click);
            // 
            // LoadingConfigFile
            // 
            this.LoadingConfigFile.Location = new System.Drawing.Point(207, 234);
            this.LoadingConfigFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadingConfigFile.Name = "LoadingConfigFile";
            this.LoadingConfigFile.Size = new System.Drawing.Size(123, 52);
            this.LoadingConfigFile.TabIndex = 11;
            this.LoadingConfigFile.Text = "Load Config File";
            this.LoadingConfigFile.UseVisualStyleBackColor = true;
            this.LoadingConfigFile.Click += new System.EventHandler(this.LoadingConfigFile_Click);
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 468);
            this.Controls.Add(this.LoadingConfigFile);
            this.Controls.Add(this.RandomRoomButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Name = "GameMode";
            this.Text = "Game Mode Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RandomRoomButton;
        private System.Windows.Forms.Button LoadingConfigFile;
    }
}