namespace NewGraverForms_Net
{
    partial class FormAxis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAxis));
            X_Coord_Label = new Label();
            Y_Coord_Label = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            buttonUp = new Button();
            buttonLeft = new Button();
            buttonRight = new Button();
            buttonDown = new Button();
            AcceptXY_Button = new Button();
            label3 = new Label();
            textBox_Y_Coord = new TextBox();
            label4 = new Label();
            textBox_X_Coord = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // X_Coord_Label
            // 
            X_Coord_Label.AutoSize = true;
            X_Coord_Label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            X_Coord_Label.Location = new Point(40, 28);
            X_Coord_Label.Margin = new Padding(2, 0, 2, 0);
            X_Coord_Label.Name = "X_Coord_Label";
            X_Coord_Label.Size = new Size(16, 17);
            X_Coord_Label.TabIndex = 4;
            X_Coord_Label.Text = "0";
            // 
            // Y_Coord_Label
            // 
            Y_Coord_Label.AutoSize = true;
            Y_Coord_Label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Y_Coord_Label.Location = new Point(40, 52);
            Y_Coord_Label.Margin = new Padding(2, 0, 2, 0);
            Y_Coord_Label.Name = "Y_Coord_Label";
            Y_Coord_Label.Size = new Size(16, 17);
            Y_Coord_Label.TabIndex = 5;
            Y_Coord_Label.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonUp);
            groupBox1.Controls.Add(Y_Coord_Label);
            groupBox1.Controls.Add(buttonLeft);
            groupBox1.Controls.Add(X_Coord_Label);
            groupBox1.Controls.Add(buttonRight);
            groupBox1.Controls.Add(buttonDown);
            groupBox1.Location = new Point(2, 156);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(316, 290);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Джойстик";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 17);
            label1.TabIndex = 7;
            label1.Text = "Y:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(13, 28);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 17);
            label2.TabIndex = 6;
            label2.Text = "X:";
            // 
            // buttonUp
            // 
            buttonUp.BackColor = SystemColors.Control;
            buttonUp.BackgroundImage = (Image)resources.GetObject("buttonUp.BackgroundImage");
            buttonUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUp.FlatStyle = FlatStyle.Flat;
            buttonUp.ForeColor = SystemColors.Control;
            buttonUp.Location = new Point(126, 46);
            buttonUp.Margin = new Padding(0);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(65, 70);
            buttonUp.TabIndex = 2;
            buttonUp.UseVisualStyleBackColor = false;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.BackColor = SystemColors.Control;
            buttonLeft.BackgroundImage = (Image)resources.GetObject("buttonLeft.BackgroundImage");
            buttonLeft.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLeft.FlatStyle = FlatStyle.Flat;
            buttonLeft.ForeColor = SystemColors.Control;
            buttonLeft.Location = new Point(61, 118);
            buttonLeft.Margin = new Padding(0);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(65, 70);
            buttonLeft.TabIndex = 0;
            buttonLeft.UseVisualStyleBackColor = false;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.BackColor = SystemColors.Control;
            buttonRight.BackgroundImage = (Image)resources.GetObject("buttonRight.BackgroundImage");
            buttonRight.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.ForeColor = SystemColors.Control;
            buttonRight.Location = new Point(191, 118);
            buttonRight.Margin = new Padding(0);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(65, 70);
            buttonRight.TabIndex = 1;
            buttonRight.UseVisualStyleBackColor = false;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonDown
            // 
            buttonDown.BackColor = SystemColors.Control;
            buttonDown.BackgroundImage = (Image)resources.GetObject("buttonDown.BackgroundImage");
            buttonDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDown.FlatStyle = FlatStyle.Flat;
            buttonDown.ForeColor = SystemColors.Control;
            buttonDown.Location = new Point(126, 188);
            buttonDown.Margin = new Padding(0);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(65, 70);
            buttonDown.TabIndex = 3;
            buttonDown.UseVisualStyleBackColor = false;
            buttonDown.Click += buttonDown_Click;
            // 
            // AcceptXY_Button
            // 
            AcceptXY_Button.Location = new Point(100, 105);
            AcceptXY_Button.Margin = new Padding(2);
            AcceptXY_Button.Name = "AcceptXY_Button";
            AcceptXY_Button.Size = new Size(97, 37);
            AcceptXY_Button.TabIndex = 24;
            AcceptXY_Button.Text = "Применить";
            AcceptXY_Button.UseVisualStyleBackColor = true;
            AcceptXY_Button.Click += AcceptXY_Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(193, 41);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 23;
            label3.Text = "Ось Y";
            // 
            // textBox_Y_Coord
            // 
            textBox_Y_Coord.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Y_Coord.Location = new Point(195, 62);
            textBox_Y_Coord.Margin = new Padding(2);
            textBox_Y_Coord.Name = "textBox_Y_Coord";
            textBox_Y_Coord.Size = new Size(54, 26);
            textBox_Y_Coord.TabIndex = 22;
            textBox_Y_Coord.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(67, 41);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 21;
            label4.Text = "Ось X";
            // 
            // textBox_X_Coord
            // 
            textBox_X_Coord.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_X_Coord.Location = new Point(68, 62);
            textBox_X_Coord.Margin = new Padding(2);
            textBox_X_Coord.Name = "textBox_X_Coord";
            textBox_X_Coord.Size = new Size(54, 26);
            textBox_X_Coord.TabIndex = 20;
            textBox_X_Coord.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(100, 9);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 25;
            label5.Text = "Координаты:";
            // 
            // FormAxis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 449);
            Controls.Add(label5);
            Controls.Add(AcceptXY_Button);
            Controls.Add(label3);
            Controls.Add(textBox_Y_Coord);
            Controls.Add(label4);
            Controls.Add(textBox_X_Coord);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "FormAxis";
            Text = "FormAxis";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Label X_Coord_Label;
        private System.Windows.Forms.Label Y_Coord_Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AcceptXY_Button;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Y_Coord;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_X_Coord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}