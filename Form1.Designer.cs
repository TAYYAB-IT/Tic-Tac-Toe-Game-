namespace Tic_Tac_Toe_Game
{
    partial class Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tic_Tac_Toe));
            this.game_lable = new System.Windows.Forms.Label();
            this.player_1_label = new System.Windows.Forms.Label();
            this.player_2_label = new System.Windows.Forms.Label();
            this.player_1_name = new System.Windows.Forms.TextBox();
            this.player_2_name = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player_turn = new System.Windows.Forms.Label();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.result_box = new System.Windows.Forms.Label();
            this.restart_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // game_lable
            // 
            this.game_lable.BackColor = System.Drawing.Color.SlateGray;
            this.game_lable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.game_lable.Font = new System.Drawing.Font("Microsoft PhagsPa", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_lable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.game_lable.Location = new System.Drawing.Point(296, 21);
            this.game_lable.Name = "game_lable";
            this.game_lable.Size = new System.Drawing.Size(320, 76);
            this.game_lable.TabIndex = 0;
            this.game_lable.Text = "Tic Tac Toe";
            this.game_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_1_label
            // 
            this.player_1_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.player_1_label.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_1_label.Location = new System.Drawing.Point(292, 109);
            this.player_1_label.Name = "player_1_label";
            this.player_1_label.Size = new System.Drawing.Size(130, 31);
            this.player_1_label.TabIndex = 1;
            this.player_1_label.Text = "PLAYER #01";
            this.player_1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_2_label
            // 
            this.player_2_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.player_2_label.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_2_label.Location = new System.Drawing.Point(486, 109);
            this.player_2_label.Name = "player_2_label";
            this.player_2_label.Size = new System.Drawing.Size(130, 31);
            this.player_2_label.TabIndex = 2;
            this.player_2_label.Text = "PLAYER #02";
            this.player_2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_1_name
            // 
            this.player_1_name.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.player_1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_1_name.ForeColor = System.Drawing.SystemColors.Info;
            this.player_1_name.Location = new System.Drawing.Point(296, 143);
            this.player_1_name.Name = "player_1_name";
            this.player_1_name.Size = new System.Drawing.Size(117, 21);
            this.player_1_name.TabIndex = 3;
            this.player_1_name.TabStop = false;
            this.player_1_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_2_name
            // 
            this.player_2_name.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.player_2_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_2_name.ForeColor = System.Drawing.SystemColors.Info;
            this.player_2_name.Location = new System.Drawing.Point(490, 143);
            this.player_2_name.Name = "player_2_name";
            this.player_2_name.Size = new System.Drawing.Size(117, 21);
            this.player_2_name.TabIndex = 4;
            this.player_2_name.TabStop = false;
            this.player_2_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.SlateGray;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(412, 204);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(78, 29);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "O";
            // 
            // player_turn
            // 
            this.player_turn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.player_turn.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_turn.Location = new System.Drawing.Point(385, 184);
            this.player_turn.Name = "player_turn";
            this.player_turn.Size = new System.Drawing.Size(130, 31);
            this.player_turn.TabIndex = 8;
            this.player_turn.Text = "PLAYER #01";
            this.player_turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player_turn.Visible = false;
            // 
            // button_0
            // 
            this.button_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_0.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.ForeColor = System.Drawing.Color.White;
            this.button_0.Location = new System.Drawing.Point(338, 243);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(75, 35);
            this.button_0.TabIndex = 9;
            this.button_0.TabStop = false;
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Visible = false;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_2
            // 
            this.button_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.ForeColor = System.Drawing.Color.White;
            this.button_2.Location = new System.Drawing.Point(490, 243);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(75, 35);
            this.button_2.TabIndex = 10;
            this.button_2.TabStop = false;
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Visible = false;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.ForeColor = System.Drawing.Color.White;
            this.button_1.Location = new System.Drawing.Point(415, 243);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(75, 35);
            this.button_1.TabIndex = 11;
            this.button_1.TabStop = false;
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Visible = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_3
            // 
            this.button_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_3.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.ForeColor = System.Drawing.Color.White;
            this.button_3.Location = new System.Drawing.Point(339, 284);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(75, 35);
            this.button_3.TabIndex = 12;
            this.button_3.TabStop = false;
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Visible = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_4
            // 
            this.button_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_4.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.ForeColor = System.Drawing.Color.White;
            this.button_4.Location = new System.Drawing.Point(415, 284);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(75, 35);
            this.button_4.TabIndex = 13;
            this.button_4.TabStop = false;
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Visible = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_5.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.ForeColor = System.Drawing.Color.White;
            this.button_5.Location = new System.Drawing.Point(490, 284);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(75, 35);
            this.button_5.TabIndex = 14;
            this.button_5.TabStop = false;
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Visible = false;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_6.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.ForeColor = System.Drawing.Color.White;
            this.button_6.Location = new System.Drawing.Point(339, 325);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(75, 35);
            this.button_6.TabIndex = 15;
            this.button_6.TabStop = false;
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Visible = false;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_7
            // 
            this.button_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_7.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.ForeColor = System.Drawing.Color.White;
            this.button_7.Location = new System.Drawing.Point(415, 325);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(75, 35);
            this.button_7.TabIndex = 16;
            this.button_7.TabStop = false;
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Visible = false;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_8.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.ForeColor = System.Drawing.Color.White;
            this.button_8.Location = new System.Drawing.Point(490, 325);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(75, 35);
            this.button_8.TabIndex = 17;
            this.button_8.TabStop = false;
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Visible = false;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // result_box
            // 
            this.result_box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.result_box.Font = new System.Drawing.Font("Myanmar Text", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_box.Location = new System.Drawing.Point(296, 108);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(320, 132);
            this.result_box.TabIndex = 18;
            this.result_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result_box.Visible = false;
            // 
            // restart_button
            // 
            this.restart_button.BackColor = System.Drawing.Color.SlateGray;
            this.restart_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_button.Location = new System.Drawing.Point(300, 208);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(90, 29);
            this.restart_button.TabIndex = 19;
            this.restart_button.Text = "RESTART";
            this.restart_button.UseVisualStyleBackColor = false;
            this.restart_button.Visible = false;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.SlateGray;
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(517, 208);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(90, 29);
            this.reset_button.TabIndex = 20;
            this.reset_button.Text = "RESET";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Visible = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SlateGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(434, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Credit To: TAYYAB AMAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tic_Tac_Toe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.restart_button);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.player_turn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.player_2_name);
            this.Controls.Add(this.player_1_name);
            this.Controls.Add(this.player_2_label);
            this.Controls.Add(this.player_1_label);
            this.Controls.Add(this.game_lable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tic_Tac_Toe";
            this.Text = "Tic Tac Toe: Rajusko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game_lable;
        private System.Windows.Forms.Label player_1_label;
        private System.Windows.Forms.Label player_2_label;
        private System.Windows.Forms.TextBox player_1_name;
        private System.Windows.Forms.TextBox player_2_name;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player_turn;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Label result_box;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label label3;
    }
}

