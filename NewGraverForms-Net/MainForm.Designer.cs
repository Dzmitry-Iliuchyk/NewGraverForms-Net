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
            buttonApplyMaterial = new Button();
            mainTabControl = new TabControl();
            tabPageConnection = new TabPage();
            tabPageFileChoice = new TabPage();
            tabPageAxesXY = new TabPage();
            tabPageHeight = new TabPage();
            tabPageMaterial = new TabPage();
            tabPageStart = new TabPage();
            buttonNextTab = new Button();
            buttonBackTab = new Button();
            labelIsConnected = new Label();
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
            textBoxConnectionHost.Location = new Point(16, 28);
            textBoxConnectionHost.MaxLength = 15;
            textBoxConnectionHost.Name = "textBoxConnectionHost";
            textBoxConnectionHost.PlaceholderText = "255.255.255.255";
            textBoxConnectionHost.Size = new Size(100, 23);
            textBoxConnectionHost.TabIndex = 15;
            textBoxConnectionHost.KeyPress += textBoxConnectionHost_KeyPress;
            // 
            // textBoxConnectionPort
            // 
            textBoxConnectionPort.Location = new Point(176, 28);
            textBoxConnectionPort.Name = "textBoxConnectionPort";
            textBoxConnectionPort.PlaceholderText = "65535";
            textBoxConnectionPort.Size = new Size(55, 23);
            textBoxConnectionPort.TabIndex = 14;
            textBoxConnectionPort.KeyPress += textBoxConnectionPort_KeyPress;
            // 
            // buttonConnection
            // 
            buttonConnection.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonConnection.Location = new Point(20, 70);
            buttonConnection.Margin = new Padding(4, 3, 4, 3);
            buttonConnection.Name = "buttonConnection";
            buttonConnection.Size = new Size(88, 27);
            buttonConnection.TabIndex = 6;
            buttonConnection.Text = "Connect";
            buttonConnection.UseVisualStyleBackColor = true;
            buttonConnection.Click += buttonConnection_Click;
            // 
            // labelConnectionPort
            // 
            labelConnectionPort.AutoSize = true;
            labelConnectionPort.Location = new Point(176, 10);
            labelConnectionPort.Margin = new Padding(4, 0, 4, 0);
            labelConnectionPort.Name = "labelConnectionPort";
            labelConnectionPort.Size = new Size(29, 15);
            labelConnectionPort.TabIndex = 1;
            labelConnectionPort.Text = "Port";
            // 
            // labelConnectionHost
            // 
            labelConnectionHost.AutoSize = true;
            labelConnectionHost.Location = new Point(16, 10);
            labelConnectionHost.Margin = new Padding(4, 0, 4, 0);
            labelConnectionHost.Name = "labelConnectionHost";
            labelConnectionHost.Size = new Size(32, 15);
            labelConnectionHost.TabIndex = 0;
            labelConnectionHost.Text = "Host";
            // 
            // button_selectFile
            // 
            button_selectFile.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_selectFile.Location = new Point(26, 148);
            button_selectFile.Margin = new Padding(2);
            button_selectFile.Name = "button_selectFile";
            button_selectFile.Size = new Size(119, 32);
            button_selectFile.TabIndex = 5;
            button_selectFile.Text = "Select a file";
            button_selectFile.UseVisualStyleBackColor = true;
            button_selectFile.Click += button_selectFile_Click;
            // 
            // label_selectedFile
            // 
            label_selectedFile.AutoSize = true;
            label_selectedFile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_selectedFile.Location = new Point(4, 38);
            label_selectedFile.Margin = new Padding(2, 0, 2, 0);
            label_selectedFile.Name = "label_selectedFile";
            label_selectedFile.Size = new Size(98, 20);
            label_selectedFile.TabIndex = 4;
            label_selectedFile.Text = "Not selected";
            // 
            // selectedFile
            // 
            selectedFile.AutoSize = true;
            selectedFile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            selectedFile.Location = new Point(4, 9);
            selectedFile.Margin = new Padding(2, 0, 2, 0);
            selectedFile.Name = "selectedFile";
            selectedFile.Size = new Size(160, 20);
            selectedFile.TabIndex = 3;
            selectedFile.Text = "Selected marking file:";
            // 
            // buttonAxisControl
            // 
            buttonAxisControl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAxisControl.Location = new Point(14, 48);
            buttonAxisControl.Margin = new Padding(2);
            buttonAxisControl.Name = "buttonAxisControl";
            buttonAxisControl.Size = new Size(112, 50);
            buttonAxisControl.TabIndex = 7;
            buttonAxisControl.Text = "Axis control";
            buttonAxisControl.UseVisualStyleBackColor = true;
            buttonAxisControl.Click += buttonAxisControl_Click;
            // 
            // labelSetUpSettings
            // 
            labelSetUpSettings.AutoSize = true;
            labelSetUpSettings.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSetUpSettings.Location = new Point(10, 9);
            labelSetUpSettings.Margin = new Padding(2, 0, 2, 0);
            labelSetUpSettings.Name = "labelSetUpSettings";
            labelSetUpSettings.Size = new Size(176, 20);
            labelSetUpSettings.TabIndex = 6;
            labelSetUpSettings.Text = "Adjust XY axes position";
            // 
            // labelSetUp
            // 
            labelSetUp.AutoSize = true;
            labelSetUp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSetUp.Location = new Point(4, 12);
            labelSetUp.Margin = new Padding(2, 0, 2, 0);
            labelSetUp.Name = "labelSetUp";
            labelSetUp.Size = new Size(131, 20);
            labelSetUp.TabIndex = 8;
            labelSetUp.Text = "Set up the height";
            // 
            // button_set_auto_height
            // 
            button_set_auto_height.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_set_auto_height.Location = new Point(29, 58);
            button_set_auto_height.Margin = new Padding(2);
            button_set_auto_height.Name = "button_set_auto_height";
            button_set_auto_height.Size = new Size(80, 44);
            button_set_auto_height.TabIndex = 9;
            button_set_auto_height.Text = "Auto measure";
            button_set_auto_height.UseVisualStyleBackColor = true;
            button_set_auto_height.Click += button_set_auto_height_Click;
            // 
            // labelAutoHeight
            // 
            labelAutoHeight.AutoSize = true;
            labelAutoHeight.Location = new Point(128, 72);
            labelAutoHeight.Name = "labelAutoHeight";
            labelAutoHeight.Size = new Size(0, 15);
            labelAutoHeight.TabIndex = 15;
            // 
            // buttonAcceptHeight
            // 
            buttonAcceptHeight.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAcceptHeight.Location = new Point(303, 69);
            buttonAcceptHeight.Margin = new Padding(2);
            buttonAcceptHeight.Name = "buttonAcceptHeight";
            buttonAcceptHeight.Size = new Size(103, 33);
            buttonAcceptHeight.TabIndex = 14;
            buttonAcceptHeight.Text = "Apply";
            buttonAcceptHeight.UseVisualStyleBackColor = true;
            buttonAcceptHeight.Click += buttonAcceptHeight_Click;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHeight.Location = new Point(303, 35);
            textBoxHeight.MaxLength = 4;
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(104, 29);
            textBoxHeight.TabIndex = 13;
            textBoxHeight.KeyPress += textBoxHeight_KeyPress;
            // 
            // labelZshift
            // 
            labelZshift.AutoSize = true;
            labelZshift.ForeColor = SystemColors.ControlDarkDark;
            labelZshift.Location = new Point(303, 17);
            labelZshift.Name = "labelZshift";
            labelZshift.Size = new Size(93, 15);
            labelZshift.TabIndex = 11;
            labelZshift.Text = "Height to object";
            // 
            // comboBoxMaterial
            // 
            comboBoxMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterial.Location = new Point(136, 18);
            comboBoxMaterial.Name = "comboBoxMaterial";
            comboBoxMaterial.Size = new Size(121, 23);
            comboBoxMaterial.TabIndex = 1;
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMaterial.Location = new Point(13, 15);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(70, 21);
            labelMaterial.TabIndex = 0;
            labelMaterial.Text = "Material:";
            // 
            // buttonManualStart
            // 
            buttonManualStart.BackColor = Color.Green;
            buttonManualStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonManualStart.ForeColor = Color.White;
            buttonManualStart.Location = new Point(25, 68);
            buttonManualStart.Name = "buttonManualStart";
            buttonManualStart.Size = new Size(110, 56);
            buttonManualStart.TabIndex = 4;
            buttonManualStart.Text = "Start";
            buttonManualStart.UseVisualStyleBackColor = false;
            // 
            // labelManualMode
            // 
            labelManualMode.AutoSize = true;
            labelManualMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelManualMode.Location = new Point(25, 35);
            labelManualMode.Name = "labelManualMode";
            labelManualMode.Size = new Size(106, 21);
            labelManualMode.TabIndex = 1;
            labelManualMode.Text = "Manual mode";
            // 
            // buttonAutoStop
            // 
            buttonAutoStop.BackColor = Color.Red;
            buttonAutoStop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAutoStop.ForeColor = Color.White;
            buttonAutoStop.Location = new Point(331, 68);
            buttonAutoStop.Name = "buttonAutoStop";
            buttonAutoStop.Size = new Size(110, 56);
            buttonAutoStop.TabIndex = 4;
            buttonAutoStop.Text = "Stop";
            buttonAutoStop.UseVisualStyleBackColor = false;
            // 
            // buttonAutoStart
            // 
            buttonAutoStart.BackColor = Color.Green;
            buttonAutoStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAutoStart.ForeColor = Color.White;
            buttonAutoStart.Location = new Point(194, 68);
            buttonAutoStart.Name = "buttonAutoStart";
            buttonAutoStart.Size = new Size(110, 56);
            buttonAutoStart.TabIndex = 3;
            buttonAutoStart.Text = "Start";
            buttonAutoStart.UseVisualStyleBackColor = false;
            // 
            // labelAutoMode
            // 
            labelAutoMode.AutoSize = true;
            labelAutoMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAutoMode.Location = new Point(265, 35);
            labelAutoMode.Name = "labelAutoMode";
            labelAutoMode.Size = new Size(87, 21);
            labelAutoMode.TabIndex = 0;
            labelAutoMode.Text = "Auto mode";
            // 
            // buttonApplyMaterial
            // 
            buttonApplyMaterial.Location = new Point(18, 51);
            buttonApplyMaterial.Margin = new Padding(3, 2, 3, 2);
            buttonApplyMaterial.Name = "buttonApplyMaterial";
            buttonApplyMaterial.Size = new Size(86, 24);
            buttonApplyMaterial.TabIndex = 2;
            buttonApplyMaterial.Text = "Apply";
            buttonApplyMaterial.UseVisualStyleBackColor = true;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPageConnection);
            mainTabControl.Controls.Add(tabPageFileChoice);
            mainTabControl.Controls.Add(tabPageAxesXY);
            mainTabControl.Controls.Add(tabPageHeight);
            mainTabControl.Controls.Add(tabPageMaterial);
            mainTabControl.Controls.Add(tabPageStart);
            mainTabControl.Location = new Point(1, 2);
            mainTabControl.Margin = new Padding(3, 2, 3, 2);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(470, 235);
            mainTabControl.TabIndex = 14;
            // 
            // tabPageConnection
            // 
            tabPageConnection.Controls.Add(labelIsConnected);
            tabPageConnection.Controls.Add(textBoxConnectionHost);
            tabPageConnection.Controls.Add(labelConnectionHost);
            tabPageConnection.Controls.Add(textBoxConnectionPort);
            tabPageConnection.Controls.Add(labelConnectionPort);
            tabPageConnection.Controls.Add(buttonConnection);
            tabPageConnection.Location = new Point(4, 24);
            tabPageConnection.Margin = new Padding(3, 2, 3, 2);
            tabPageConnection.Name = "tabPageConnection";
            tabPageConnection.Padding = new Padding(3, 2, 3, 2);
            tabPageConnection.Size = new Size(462, 207);
            tabPageConnection.TabIndex = 0;
            tabPageConnection.Text = "Connection";
            tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // tabPageFileChoice
            // 
            tabPageFileChoice.Controls.Add(label_selectedFile);
            tabPageFileChoice.Controls.Add(button_selectFile);
            tabPageFileChoice.Controls.Add(selectedFile);
            tabPageFileChoice.Location = new Point(4, 24);
            tabPageFileChoice.Margin = new Padding(3, 2, 3, 2);
            tabPageFileChoice.Name = "tabPageFileChoice";
            tabPageFileChoice.Padding = new Padding(3, 2, 3, 2);
            tabPageFileChoice.Size = new Size(462, 207);
            tabPageFileChoice.TabIndex = 1;
            tabPageFileChoice.Text = "ChoiceFile";
            tabPageFileChoice.UseVisualStyleBackColor = true;
            // 
            // tabPageAxesXY
            // 
            tabPageAxesXY.Controls.Add(labelSetUpSettings);
            tabPageAxesXY.Controls.Add(buttonAxisControl);
            tabPageAxesXY.Location = new Point(4, 24);
            tabPageAxesXY.Margin = new Padding(3, 2, 3, 2);
            tabPageAxesXY.Name = "tabPageAxesXY";
            tabPageAxesXY.Padding = new Padding(3, 2, 3, 2);
            tabPageAxesXY.Size = new Size(462, 207);
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
            tabPageHeight.Location = new Point(4, 24);
            tabPageHeight.Margin = new Padding(3, 2, 3, 2);
            tabPageHeight.Name = "tabPageHeight";
            tabPageHeight.Padding = new Padding(3, 2, 3, 2);
            tabPageHeight.Size = new Size(462, 207);
            tabPageHeight.TabIndex = 3;
            tabPageHeight.Text = "Height";
            tabPageHeight.UseVisualStyleBackColor = true;
            // 
            // tabPageMaterial
            // 
            tabPageMaterial.Controls.Add(buttonApplyMaterial);
            tabPageMaterial.Controls.Add(labelMaterial);
            tabPageMaterial.Controls.Add(comboBoxMaterial);
            tabPageMaterial.Location = new Point(4, 24);
            tabPageMaterial.Margin = new Padding(3, 2, 3, 2);
            tabPageMaterial.Name = "tabPageMaterial";
            tabPageMaterial.Padding = new Padding(3, 2, 3, 2);
            tabPageMaterial.Size = new Size(462, 207);
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
            tabPageStart.Location = new Point(4, 24);
            tabPageStart.Margin = new Padding(3, 2, 3, 2);
            tabPageStart.Name = "tabPageStart";
            tabPageStart.Padding = new Padding(3, 2, 3, 2);
            tabPageStart.Size = new Size(462, 207);
            tabPageStart.TabIndex = 5;
            tabPageStart.Text = "Start";
            tabPageStart.UseVisualStyleBackColor = true;
            // 
            // buttonNextTab
            // 
            buttonNextTab.Location = new Point(347, 254);
            buttonNextTab.Margin = new Padding(3, 2, 3, 2);
            buttonNextTab.Name = "buttonNextTab";
            buttonNextTab.Size = new Size(82, 22);
            buttonNextTab.TabIndex = 15;
            buttonNextTab.Text = "Next";
            buttonNextTab.UseVisualStyleBackColor = true;
            buttonNextTab.Click += buttonNextTab_Click;
            // 
            // buttonBackTab
            // 
            buttonBackTab.Location = new Point(31, 254);
            buttonBackTab.Margin = new Padding(3, 2, 3, 2);
            buttonBackTab.Name = "buttonBackTab";
            buttonBackTab.Size = new Size(82, 22);
            buttonBackTab.TabIndex = 16;
            buttonBackTab.Text = "Back";
            buttonBackTab.UseVisualStyleBackColor = true;
            buttonBackTab.Click += buttonBackTab_Click;
            // 
            // labelIsConnected
            // 
            labelIsConnected.AutoSize = true;
            labelIsConnected.Location = new Point(123, 76);
            labelIsConnected.Name = "labelIsConnected";
            labelIsConnected.Size = new Size(0, 15);
            labelIsConnected.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 284);
            Controls.Add(buttonBackTab);
            Controls.Add(buttonNextTab);
            Controls.Add(mainTabControl);
            Margin = new Padding(4, 3, 4, 3);
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
        private Button buttonApplyMaterial;
        private TabControl mainTabControl;
        private TabPage tabPageConnection;
        private TabPage tabPageFileChoice;
        private TabPage tabPageAxesXY;
        private TabPage tabPageHeight;
        private TabPage tabPageMaterial;
        private TabPage tabPageStart;
        private Button buttonNextTab;
        private Button buttonBackTab;
        private Label labelIsConnected;
    }
}

