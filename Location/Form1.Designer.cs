namespace Location
{
    partial class Form1
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
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.lbl_move = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(564, 183);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(168, 65);
            this.btn_right.TabIndex = 0;
            this.btn_right.Text = "RIGHT";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(59, 183);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(171, 65);
            this.btn_left.TabIndex = 0;
            this.btn_left.Text = "LEFT";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(328, 21);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(168, 65);
            this.btn_up.TabIndex = 0;
            this.btn_up.Text = "UP";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(328, 354);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(168, 65);
            this.btn_down.TabIndex = 0;
            this.btn_down.Text = "DOWN";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // lbl_move
            // 
            this.lbl_move.AutoSize = true;
            this.lbl_move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_move.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_move.Location = new System.Drawing.Point(350, 188);
            this.lbl_move.Name = "lbl_move";
            this.lbl_move.Size = new System.Drawing.Size(107, 39);
            this.lbl_move.TabIndex = 1;
            this.lbl_move.Text = "move";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 549);
            this.Controls.Add(this.lbl_move);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_right);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Label lbl_move;
    }
}

