namespace NewGraverForms_Net
{
    partial class MainForm
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
            textBoxConnectionHost = new TextBox();
            textBoxConnectionPort = new TextBox();
            buttonConnection = new Button();
            labelConnectionPort = new Label();
            labelConnectionHost = new Label();
            button_selectFile = new Button();
            label_selectedFile = new Label();
            selectedFile = new Label();
            buttonAxisControl = new Button();
            labelSetUpSettings = new Label();
            labelSetUp = new Label();
            button_set_auto_height = new Button();
            labelAutoHeight = new Label();
            buttonAcceptHeight = new Button();
            textBoxHeight = new TextBox();
            labelZshift = new Label();
            comboBoxMaterial = new ComboBox();
            labelMaterial = new Label();
            buttonManualStart = new Button();
            labelManualMode = new Label();
            buttonAutoStop = new Button();
            buttonAutoStart = new Button();
            labelAutoMode = new Label();
            buttonAcceptMaterial = new Button();
            mainTabControl = new TabControl();
            tabPageConnection = new TabPage();
            tabPageFileChoice = new TabPage();
            tabPageAxesXY = new TabPage();
            tabPageHeight = new TabPage();
            tabPageMaterial = new TabPage();
            tabPageStart = new TabPage();
            buttonNextTab = new Button();
            buttonBackTab = new Button();
            mainTabControl.SuspendLayout();
            tabPageConnection.SuspendLayout();
            tabPageFileChoice.SuspendLayout();
            tabPageAxesXY.SuspendLayout();
            tabPageHeight.SuspendLayout();
            tabPageMaterial.SuspendLayout();
            tabPageStart.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxConnectionHost
            // 
            textBoxConnectionHost.Location = new Point(18, 37);
            textBoxConnectionHost.Margin = new Padding(3, 4, 3, 4);
            textBoxConnectionHost.MaxLength = 15;
            textBoxConnectionHost.Name = "textBoxConnectionHost";
            textBoxConnectionHost.PlaceholderText = "255.255.255.255";
            textBoxConnectionHost.Size = new Size(114, 27);
            textBoxConnectionHost.TabIndex = 15;
            textBoxConnectionHost.KeyPress += textBoxConnectionHost_KeyPress;
            // 
            // textBoxConnectionPort
            // 
            textBoxConnectionPort.Location = new Point(201, 37);
            textBoxConnectionPort.Margin = new Padding(3, 4, 3, 4);
            textBoxConnectionPort.Name = "textBoxConnectionPort";
            textBoxConnectionPort.PlaceholderText = "65535";
            textBoxConnectionPort.Size = new Size(62, 27);
            textBoxConnectionPort.TabIndex = 14;
            textBoxConnectionPort.KeyPress += textBoxConnectionPort_KeyPress;
            // 
            // buttonConnection
            // 
            buttonConnection.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonConnection.Location = new Point(23, 94);
            buttonConnection.Margin = new Padding(5, 4, 5, 4);
            buttonConnection.Name = "buttonConnection";
            buttonConnection.Size = new Size(101, 36);
            buttonConnection.TabIndex = 6;
            buttonConnection.Text = "Connect";
            buttonConnection.UseVisualStyleBackColor = true;
            buttonConnection.Click += buttonConnection_Click;
            // 
            // labelConnectionPort
            // 
            labelConnectionPort.AutoSize = true;
            labelConnectionPort.Location = new Point(201, 13);
            labelConnectionPort.Margin = new Padding(5, 0, 5, 0);
            labelConnectionPort.Name = "labelConnectionPort";
            labelConnectionPort.Size = new Size(35, 20);
            labelConnectionPort.TabIndex = 1;
            labelConnectionPort.Text = "Port";
            // 
            // labelConnectionHost
            // 
            labelConnectionHost.AutoSize = true;
            labelConnectionHost.Location = new Point(18, 13);
            labelConnectionHost.Margin = new Padding(5, 0, 5, 0);
            labelConnectionHost.Name = "labelConnectionHost";
            labelConnectionHost.Size = new Size(40, 20);
            labelConnectionHost.TabIndex = 0;
            labelConnectionHost.Text = "Host";
            // 
            // button_selectFile
            // 
            button_selectFile.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_selectFile.Location = new Point(5, 197);
            button_selectFile.Margin = new Padding(2, 3, 2, 3);
            button_selectFile.Name = "button_selectFile";
            button_selectFile.Size = new Size(161, 43);
            button_selectFile.TabIndex = 5;
            button_selectFile.Text = "Выбрать файл";
            button_selectFile.UseVisualStyleBackColor = true;
            button_selectFile.Click += button_selectFile_Click;
            // 
            // label_selectedFile
            // 
            label_selectedFile.AutoSize = true;
            label_selectedFile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_selectedFile.Location = new Point(5, 51);
            label_selectedFile.Margin = new Padding(2, 0, 2, 0);
            label_selectedFile.Name = "label_selectedFile";
            label_selectedFile.Size = new Size(113, 25);
            label_selectedFile.TabIndex = 4;
            label_selectedFile.Text = " Не выбран";
            // 
            // selectedFile
            // 
            selectedFile.AutoSize = true;
            selectedFile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            selectedFile.Location = new Point(5, 12);
            selectedFile.Margin = new Padding(2, 0, 2, 0);
            selectedFile.Name = "selectedFile";
            selectedFile.Size = new Size(297, 25);
            selectedFile.TabIndex = 3;
            selectedFile.Text = "Выбранный файл маркировки:";
            // 
            // buttonAxisControl
            // 
            buttonAxisControl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAxisControl.Location = new Point(16, 64);
            buttonAxisControl.Margin = new Padding(2, 3, 2, 3);
            buttonAxisControl.Name = "buttonAxisControl";
            buttonAxisControl.Size = new Size(128, 67);
            buttonAxisControl.TabIndex = 7;
            buttonAxisControl.Text = "Управление осями";
            buttonAxisControl.UseVisualStyleBackColor = true;
            buttonAxisControl.Click += buttonAxisControl_Click;
            // 
            // labelSetUpSettings
            // 
            labelSetUpSettings.AutoSize = true;
            labelSetUpSettings.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSetUpSettings.Location = new Point(11, 12);
            labelSetUpSettings.Margin = new Padding(2, 0, 2, 0);
            labelSetUpSettings.Name = "labelSetUpSettings";
            labelSetUpSettings.Size = new Size(304, 25);
            labelSetUpSettings.TabIndex = 6;
            labelSetUpSettings.Text = "Настройте положение осей XY";
            // 
            // labelSetUp
            // 
            labelSetUp.AutoSize = true;
            labelSetUp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSetUp.Location = new Point(5, 16);
            labelSetUp.Margin = new Padding(2, 0, 2, 0);
            labelSetUp.Name = "labelSetUp";
            labelSetUp.Size = new Size(190, 25);
            labelSetUp.TabIndex = 8;
            labelSetUp.Text = "Настройте высоту:";
            // 
            // button_set_auto_height
            // 
            button_set_auto_height.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_set_auto_height.Location = new Point(11, 91);
            button_set_auto_height.Margin = new Padding(2, 3, 2, 3);
            button_set_auto_height.Name = "button_set_auto_height";
            button_set_auto_height.Size = new Size(78, 44);
            button_set_auto_height.TabIndex = 9;
            button_set_auto_height.Text = "Авто";
            button_set_auto_height.UseVisualStyleBackColor = true;
            button_set_auto_height.Click += button_set_auto_height_Click;
            // 
            // labelAutoHeight
            // 
            labelAutoHeight.AutoSize = true;
            labelAutoHeight.Location = new Point(102, 105);
            labelAutoHeight.Name = "labelAutoHeight";
            labelAutoHeight.Size = new Size(119, 20);
            labelAutoHeight.TabIndex = 15;
            labelAutoHeight.Text = "labelAutoHeight";
            // 
            // buttonAcceptHeight
            // 
            buttonAcceptHeight.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAcceptHeight.Location = new Point(274, 90);
            buttonAcceptHeight.Margin = new Padding(2, 3, 2, 3);
            buttonAcceptHeight.Name = "buttonAcceptHeight";
            buttonAcceptHeight.Size = new Size(118, 44);
            buttonAcceptHeight.TabIndex = 14;
            buttonAcceptHeight.Text = "Применить";
            buttonAcceptHeight.UseVisualStyleBackColor = true;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHeight.Location = new Point(274, 45);
            textBoxHeight.Margin = new Padding(3, 4, 3, 4);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(118, 34);
            textBoxHeight.TabIndex = 13;
            textBoxHeight.KeyPress += textBoxHeight_KeyPress;
            // 
            // labelZshift
            // 
            labelZshift.AutoSize = true;
            labelZshift.ForeColor = SystemColors.ControlDarkDark;
            labelZshift.Location = new Point(274, 21);
            labelZshift.Name = "labelZshift";
            labelZshift.Size = new Size(118, 20);
            labelZshift.TabIndex = 11;
            labelZshift.Text = "Высота обьекта";
            // 
            // comboBoxMaterial
            // 
            comboBoxMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterial.Location = new Point(124, 24);
            comboBoxMaterial.Margin = new Padding(3, 4, 3, 4);
            comboBoxMaterial.Name = "comboBoxMaterial";
            comboBoxMaterial.Size = new Size(138, 28);
            comboBoxMaterial.TabIndex = 1;
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMaterial.Location = new Point(15, 20);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(103, 28);
            labelMaterial.TabIndex = 0;
            labelMaterial.Text = "Материал";
            // 
            // buttonManualStart
            // 
            buttonManualStart.BackColor = Color.Green;
            buttonManualStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonManualStart.ForeColor = Color.White;
            buttonManualStart.Location = new Point(6, 91);
            buttonManualStart.Margin = new Padding(3, 4, 3, 4);
            buttonManualStart.Name = "buttonManualStart";
            buttonManualStart.Size = new Size(126, 75);
            buttonManualStart.TabIndex = 4;
            buttonManualStart.Text = "Старт";
            buttonManualStart.UseVisualStyleBackColor = false;
            // 
            // labelManualMode
            // 
            labelManualMode.AutoSize = true;
            labelManualMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelManualMode.Location = new Point(6, 47);
            labelManualMode.Name = "labelManualMode";
            labelManualMode.Size = new Size(148, 28);
            labelManualMode.TabIndex = 1;
            labelManualMode.Text = "Ручной режим";
            // 
            // buttonAutoStop
            // 
            buttonAutoStop.BackColor = Color.Red;
            buttonAutoStop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAutoStop.ForeColor = Color.White;
            buttonAutoStop.Location = new Point(291, 91);
            buttonAutoStop.Margin = new Padding(3, 4, 3, 4);
            buttonAutoStop.Name = "buttonAutoStop";
            buttonAutoStop.Size = new Size(126, 75);
            buttonAutoStop.TabIndex = 4;
            buttonAutoStop.Text = "Стоп";
            buttonAutoStop.UseVisualStyleBackColor = false;
            // 
            // buttonAutoStart
            // 
            buttonAutoStart.BackColor = Color.Green;
            buttonAutoStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAutoStart.ForeColor = Color.White;
            buttonAutoStart.Location = new Point(135, 91);
            buttonAutoStart.Margin = new Padding(3, 4, 3, 4);
            buttonAutoStart.Name = "buttonAutoStart";
            buttonAutoStart.Size = new Size(126, 75);
            buttonAutoStart.TabIndex = 3;
            buttonAutoStart.Text = "Старт";
            buttonAutoStart.UseVisualStyleBackColor = false;
            // 
            // labelAutoMode
            // 
            labelAutoMode.AutoSize = true;
            labelAutoMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAutoMode.Location = new Point(160, 47);
            labelAutoMode.Name = "labelAutoMode";
            labelAutoMode.Size = new Size(232, 28);
            labelAutoMode.TabIndex = 0;
            labelAutoMode.Text = "Автоматический режим";
            // 
            // buttonAcceptMaterial
            // 
            buttonAcceptMaterial.Location = new Point(20, 68);
            buttonAcceptMaterial.Name = "buttonAcceptMaterial";
            buttonAcceptMaterial.Size = new Size(98, 32);
            buttonAcceptMaterial.TabIndex = 2;
            buttonAcceptMaterial.Text = "Применить";
            buttonAcceptMaterial.UseVisualStyleBackColor = true;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPageConnection);
            mainTabControl.Controls.Add(tabPageFileChoice);
            mainTabControl.Controls.Add(tabPageAxesXY);
            mainTabControl.Controls.Add(tabPageHeight);
            mainTabControl.Controls.Add(tabPageMaterial);
            mainTabControl.Controls.Add(tabPageStart);
            mainTabControl.Location = new Point(1, 3);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(537, 313);
            mainTabControl.TabIndex = 14;
            // 
            // tabPageConnection
            // 
            tabPageConnection.Controls.Add(textBoxConnectionHost);
            tabPageConnection.Controls.Add(labelConnectionHost);
            tabPageConnection.Controls.Add(textBoxConnectionPort);
            tabPageConnection.Controls.Add(labelConnectionPort);
            tabPageConnection.Controls.Add(buttonConnection);
            tabPageConnection.Location = new Point(4, 29);
            tabPageConnection.Name = "tabPageConnection";
            tabPageConnection.Padding = new Padding(3);
            tabPageConnection.Size = new Size(529, 280);
            tabPageConnection.TabIndex = 0;
            tabPageConnection.Text = "Connection";
            tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // tabPageFileChoice
            // 
            tabPageFileChoice.Controls.Add(label_selectedFile);
            tabPageFileChoice.Controls.Add(button_selectFile);
            tabPageFileChoice.Controls.Add(selectedFile);
            tabPageFileChoice.Location = new Point(4, 29);
            tabPageFileChoice.Name = "tabPageFileChoice";
            tabPageFileChoice.Padding = new Padding(3);
            tabPageFileChoice.Size = new Size(529, 280);
            tabPageFileChoice.TabIndex = 1;
            tabPageFileChoice.Text = "ChoiceFile";
            tabPageFileChoice.UseVisualStyleBackColor = true;
            // 
            // tabPageAxesXY
            // 
            tabPageAxesXY.Controls.Add(labelSetUpSettings);
            tabPageAxesXY.Controls.Add(buttonAxisControl);
            tabPageAxesXY.Location = new Point(4, 29);
            tabPageAxesXY.Name = "tabPageAxesXY";
            tabPageAxesXY.Padding = new Padding(3);
            tabPageAxesXY.Size = new Size(529, 280);
            tabPageAxesXY.TabIndex = 2;
            tabPageAxesXY.Text = "Axes XY";
            tabPageAxesXY.UseVisualStyleBackColor = true;
            // 
            // tabPageHeight
            // 
            tabPageHeight.Controls.Add(labelAutoHeight);
            tabPageHeight.Controls.Add(labelSetUp);
            tabPageHeight.Controls.Add(buttonAcceptHeight);
            tabPageHeight.Controls.Add(button_set_auto_height);
            tabPageHeight.Controls.Add(textBoxHeight);
            tabPageHeight.Controls.Add(labelZshift);
            tabPageHeight.Location = new Point(4, 29);
            tabPageHeight.Name = "tabPageHeight";
            tabPageHeight.Padding = new Padding(3);
            tabPageHeight.Size = new Size(529, 280);
            tabPageHeight.TabIndex = 3;
            tabPageHeight.Text = "Height";
            tabPageHeight.UseVisualStyleBackColor = true;
            // 
            // tabPageMaterial
            // 
            tabPageMaterial.Controls.Add(buttonAcceptMaterial);
            tabPageMaterial.Controls.Add(labelMaterial);
            tabPageMaterial.Controls.Add(comboBoxMaterial);
            tabPageMaterial.Location = new Point(4, 29);
            tabPageMaterial.Name = "tabPageMaterial";
            tabPageMaterial.Padding = new Padding(3);
            tabPageMaterial.Size = new Size(529, 280);
            tabPageMaterial.TabIndex = 4;
            tabPageMaterial.Text = "Material";
            tabPageMaterial.UseVisualStyleBackColor = true;
            // 
            // tabPageStart
            // 
            tabPageStart.BorderStyle = BorderStyle.FixedSingle;
            tabPageStart.Controls.Add(buttonAutoStop);
            tabPageStart.Controls.Add(buttonManualStart);
            tabPageStart.Controls.Add(buttonAutoStart);
            tabPageStart.Controls.Add(labelManualMode);
            tabPageStart.Controls.Add(labelAutoMode);
            tabPageStart.Location = new Point(4, 29);
            tabPageStart.Name = "tabPageStart";
            tabPageStart.Padding = new Padding(3);
            tabPageStart.Size = new Size(529, 280);
            tabPageStart.TabIndex = 5;
            tabPageStart.Text = "Start";
            tabPageStart.UseVisualStyleBackColor = true;
            // 
            // buttonNextTab
            // 
            buttonNextTab.Location = new Point(418, 338);
            buttonNextTab.Name = "buttonNextTab";
            buttonNextTab.Size = new Size(94, 29);
            buttonNextTab.TabIndex = 15;
            buttonNextTab.Text = "Next";
            buttonNextTab.UseVisualStyleBackColor = true;
            buttonNextTab.Click += buttonNextTab_Click;
            // 
            // buttonBackTab
            // 
            buttonBackTab.Location = new Point(35, 338);
            buttonBackTab.Name = "buttonBackTab";
            buttonBackTab.Size = new Size(94, 29);
            buttonBackTab.TabIndex = 16;
            buttonBackTab.Text = "Back";
            buttonBackTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 379);
            Controls.Add(buttonBackTab);
            Controls.Add(buttonNextTab);
            Controls.Add(mainTabControl);
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            Text = "Form1";
            mainTabControl.ResumeLayout(false);
            tabPageConnection.ResumeLayout(false);
            tabPageConnection.PerformLayout();
            tabPageFileChoice.ResumeLayout(false);
            tabPageFileChoice.PerformLayout();
            tabPageAxesXY.ResumeLayout(false);
            tabPageAxesXY.PerformLayout();
            tabPageHeight.ResumeLayout(false);
            tabPageHeight.PerformLayout();
            tabPageMaterial.ResumeLayout(false);
            tabPageMaterial.PerformLayout();
            tabPageStart.ResumeLayout(false);
            tabPageStart.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label labelConnectionPort;
        private System.Windows.Forms.Label labelConnectionHost;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.GroupBox ConfigurationBox;
        private System.Windows.Forms.Button button_selectFile;
        public System.Windows.Forms.Label label_selectedFile;
        private System.Windows.Forms.Label selectedFile;
        private System.Windows.Forms.Button buttonAxisControl;
        private System.Windows.Forms.Label labelSetUpSettings;
        private Button button_set_auto_height;
        private Label labelSetUp;
        private SplitContainer splitContainer1;
        private Label labelZshift;
        private TextBox textBoxHeight;
        private Button buttonAcceptHeight;
        private GroupBox groupBoxPower;
        private ComboBox comboBoxMaterial;
        private Label labelMaterial;
        private Label labelAutoHeight;
        private SplitContainer splitContainerStartMarking;
        private Label labelManualMode;
        private Label labelAutoMode;
        private Button buttonManualStart;
        private Button buttonAutoStop;
        private Button buttonAutoStart;
        private TextBox textBoxConnectionPort;
        private TextBox textBoxConnectionHost;
        private Button buttonAcceptMaterial;
        private TabControl mainTabControl;
        private TabPage tabPageConnection;
        private TabPage tabPageFileChoice;
        private TabPage tabPageAxesXY;
        private TabPage tabPageHeight;
        private TabPage tabPageMaterial;
        private TabPage tabPageStart;
        private Button buttonNextTab;
        private Button buttonBackTab;
    }
}

