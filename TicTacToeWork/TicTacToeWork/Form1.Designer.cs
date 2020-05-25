namespace TicTacToeWork
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
            this.tb_board = new System.Windows.Forms.Label();
            this.tb_selectedNum = new System.Windows.Forms.TextBox();
            this.bt_select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_board
            // 
            this.tb_board.AutoSize = true;
            this.tb_board.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_board.Location = new System.Drawing.Point(93, 45);
            this.tb_board.Name = "tb_board";
            this.tb_board.Size = new System.Drawing.Size(53, 26);
            this.tb_board.TabIndex = 0;
            this.tb_board.Text = " text";
            // 
            // tb_selectedNum
            // 
            this.tb_selectedNum.Location = new System.Drawing.Point(442, 78);
            this.tb_selectedNum.Name = "tb_selectedNum";
            this.tb_selectedNum.Size = new System.Drawing.Size(117, 20);
            this.tb_selectedNum.TabIndex = 1;
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(489, 141);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(70, 32);
            this.bt_select.TabIndex = 2;
            this.bt_select.Text = "button1";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.tb_selectedNum);
            this.Controls.Add(this.tb_board);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tb_board;
        private System.Windows.Forms.TextBox tb_selectedNum;
        private System.Windows.Forms.Button bt_select;
    }
}

