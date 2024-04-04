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
            X_Coord_Label_Value = new Label();
            Y_Coord_Label_Value = new Label();
            groupBoxJoystick = new GroupBox();
            labelJoystickY = new Label();
            labelJoystickX = new Label();
            buttonUp = new Button();
            buttonLeft = new Button();
            buttonRight = new Button();
            buttonDown = new Button();
            AcceptXY_Button = new Button();
            labelAxisY = new Label();
            textBox_Y_Coord = new TextBox();
            labelAxisX = new Label();
            textBox_X_Coord = new TextBox();
            labelCoordinates = new Label();
            groupBoxJoystick.SuspendLayout();
            SuspendLayout();
            // 
            // X_Coord_Label_Value
            // 
            X_Coord_Label_Value.AutoSize = true;
            X_Coord_Label_Value.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            X_Coord_Label_Value.Location = new Point(46, 37);
            X_Coord_Label_Value.Margin = new Padding(2, 0, 2, 0);
            X_Coord_Label_Value.Name = "X_Coord_Label_Value";
            X_Coord_Label_Value.Size = new Size(18, 20);
            X_Coord_Label_Value.TabIndex = 4;
            X_Coord_Label_Value.Text = "0";
            // 
            // Y_Coord_Label_Value
            // 
            Y_Coord_Label_Value.AutoSize = true;
            Y_Coord_Label_Value.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Y_Coord_Label_Value.Location = new Point(46, 69);
            Y_Coord_Label_Value.Margin = new Padding(2, 0, 2, 0);
            Y_Coord_Label_Value.Name = "Y_Coord_Label_Value";
            Y_Coord_Label_Value.Size = new Size(18, 20);
            Y_Coord_Label_Value.TabIndex = 5;
            Y_Coord_Label_Value.Text = "0";
            // 
            // groupBoxJoystick
            // 
            groupBoxJoystick.Controls.Add(labelJoystickY);
            groupBoxJoystick.Controls.Add(labelJoystickX);
            groupBoxJoystick.Controls.Add(buttonUp);
            groupBoxJoystick.Controls.Add(Y_Coord_Label_Value);
            groupBoxJoystick.Controls.Add(buttonLeft);
            groupBoxJoystick.Controls.Add(X_Coord_Label_Value);
            groupBoxJoystick.Controls.Add(buttonRight);
            groupBoxJoystick.Controls.Add(buttonDown);
            groupBoxJoystick.Location = new Point(2, 208);
            groupBoxJoystick.Margin = new Padding(2, 3, 2, 3);
            groupBoxJoystick.Name = "groupBoxJoystick";
            groupBoxJoystick.Padding = new Padding(2, 3, 2, 3);
            groupBoxJoystick.Size = new Size(361, 387);
            groupBoxJoystick.TabIndex = 6;
            groupBoxJoystick.TabStop = false;
            groupBoxJoystick.Text = "Joystick";
            // 
            // labelJoystickY
            // 
            labelJoystickY.AutoSize = true;
            labelJoystickY.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelJoystickY.Location = new Point(15, 69);
            labelJoystickY.Margin = new Padding(2, 0, 2, 0);
            labelJoystickY.Name = "labelJoystickY";
            labelJoystickY.Size = new Size(24, 20);
            labelJoystickY.TabIndex = 7;
            labelJoystickY.Text = "Y:";
            // 
            // labelJoystickX
            // 
            labelJoystickX.AutoSize = true;
            labelJoystickX.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelJoystickX.Location = new Point(15, 37);
            labelJoystickX.Margin = new Padding(2, 0, 2, 0);
            labelJoystickX.Name = "labelJoystickX";
            labelJoystickX.Size = new Size(25, 20);
            labelJoystickX.TabIndex = 6;
            labelJoystickX.Text = "X:";
            // 
            // buttonUp
            // 
            buttonUp.BackColor = SystemColors.Control;
            buttonUp.BackgroundImage = (Image)resources.GetObject("buttonUp.BackgroundImage");
            buttonUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUp.FlatStyle = FlatStyle.Flat;
            buttonUp.ForeColor = SystemColors.Control;
            buttonUp.Location = new Point(144, 61);
            buttonUp.Margin = new Padding(0);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(74, 93);
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
            buttonLeft.Location = new Point(70, 157);
            buttonLeft.Margin = new Padding(0);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(74, 93);
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
            buttonRight.Location = new Point(218, 157);
            buttonRight.Margin = new Padding(0);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(74, 93);
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
            buttonDown.Location = new Point(144, 251);
            buttonDown.Margin = new Padding(0);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(74, 93);
            buttonDown.TabIndex = 3;
            buttonDown.UseVisualStyleBackColor = false;
            buttonDown.Click += buttonDown_Click;
            // 
            // AcceptXY_Button
            // 
            AcceptXY_Button.Location = new Point(114, 140);
            AcceptXY_Button.Margin = new Padding(2, 3, 2, 3);
            AcceptXY_Button.Name = "AcceptXY_Button";
            AcceptXY_Button.Size = new Size(111, 49);
            AcceptXY_Button.TabIndex = 24;
            AcceptXY_Button.Text = "Apply";
            AcceptXY_Button.UseVisualStyleBackColor = true;
            AcceptXY_Button.Click += AcceptXY_Button_Click;
            // 
            // labelAxisY
            // 
            labelAxisY.AutoSize = true;
            labelAxisY.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAxisY.Location = new Point(221, 55);
            labelAxisY.Margin = new Padding(2, 0, 2, 0);
            labelAxisY.Name = "labelAxisY";
            labelAxisY.Size = new Size(48, 18);
            labelAxisY.TabIndex = 23;
            labelAxisY.Text = "Axis Y";
            // 
            // textBox_Y_Coord
            // 
            textBox_Y_Coord.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Y_Coord.Location = new Point(223, 83);
            textBox_Y_Coord.Margin = new Padding(2, 3, 2, 3);
            textBox_Y_Coord.Name = "textBox_Y_Coord";
            textBox_Y_Coord.Size = new Size(61, 30);
            textBox_Y_Coord.TabIndex = 22;
            textBox_Y_Coord.Text = "0";
            // 
            // labelAxisX
            // 
            labelAxisX.AutoSize = true;
            labelAxisX.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAxisX.Location = new Point(77, 55);
            labelAxisX.Margin = new Padding(2, 0, 2, 0);
            labelAxisX.Name = "labelAxisX";
            labelAxisX.Size = new Size(49, 18);
            labelAxisX.TabIndex = 21;
            labelAxisX.Text = "Axis X";
            // 
            // textBox_X_Coord
            // 
            textBox_X_Coord.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_X_Coord.Location = new Point(78, 83);
            textBox_X_Coord.Margin = new Padding(2, 3, 2, 3);
            textBox_X_Coord.Name = "textBox_X_Coord";
            textBox_X_Coord.Size = new Size(61, 30);
            textBox_X_Coord.TabIndex = 20;
            textBox_X_Coord.Text = "0";
            // 
            // labelCoordinates
            // 
            labelCoordinates.AutoSize = true;
            labelCoordinates.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoordinates.ForeColor = SystemColors.ControlDarkDark;
            labelCoordinates.Location = new Point(114, 12);
            labelCoordinates.Margin = new Padding(2, 0, 2, 0);
            labelCoordinates.Name = "labelCoordinates";
            labelCoordinates.Size = new Size(93, 18);
            labelCoordinates.TabIndex = 25;
            labelCoordinates.Text = "Coordinates:";
            // 
            // FormAxis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 599);
            Controls.Add(labelCoordinates);
            Controls.Add(AcceptXY_Button);
            Controls.Add(labelAxisY);
            Controls.Add(textBox_Y_Coord);
            Controls.Add(labelAxisX);
            Controls.Add(textBox_X_Coord);
            Controls.Add(groupBoxJoystick);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormAxis";
            Text = "FormAxis";
            groupBoxJoystick.ResumeLayout(false);
            groupBoxJoystick.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Label X_Coord_Label_Value;
        private System.Windows.Forms.Label Y_Coord_Label_Value;
        private System.Windows.Forms.GroupBox groupBoxJoystick;
        private System.Windows.Forms.Button AcceptXY_Button;
        public System.Windows.Forms.Label labelAxisY;
        private System.Windows.Forms.TextBox textBox_Y_Coord;
        public System.Windows.Forms.Label labelAxisX;
        private System.Windows.Forms.TextBox textBox_X_Coord;
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.Label labelJoystickY;
        private System.Windows.Forms.Label labelJoystickX;
    }
}