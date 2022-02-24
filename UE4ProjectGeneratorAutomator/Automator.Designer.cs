namespace UE4ProjectGeneratorAutomator
{
    partial class Automator
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
            this.EditorBinaryPrompt = new System.Windows.Forms.OpenFileDialog();
            this.EditorBinaryText = new System.Windows.Forms.TextBox();
            this.EditorBinaryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ProjectGenText = new System.Windows.Forms.TextBox();
            this.ProjectGenButton = new System.Windows.Forms.Button();
            this.HeaderText = new System.Windows.Forms.TextBox();
            this.HeaderButton = new System.Windows.Forms.Button();
            this.GameProjectText = new System.Windows.Forms.TextBox();
            this.GameProjectButton = new System.Windows.Forms.Button();
            this.GamePluginText = new System.Windows.Forms.TextBox();
            this.GamePluginButton = new System.Windows.Forms.Button();
            this.CreateProject = new System.Windows.Forms.Button();
            this.HeaderPrompt = new System.Windows.Forms.FolderBrowserDialog();
            this.ProjectGenPrompt = new System.Windows.Forms.OpenFileDialog();
            this.GameProjectPrompt = new System.Windows.Forms.OpenFileDialog();
            this.GamePluginsPrompt = new System.Windows.Forms.OpenFileDialog();
            this.OutputPrompt = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorBinaryPrompt
            // 
            this.EditorBinaryPrompt.Filter = "executable files|*.exe";
            // 
            // EditorBinaryText
            // 
            this.EditorBinaryText.AllowDrop = true;
            this.EditorBinaryText.Location = new System.Drawing.Point(3, 3);
            this.EditorBinaryText.Name = "EditorBinaryText";
            this.EditorBinaryText.Size = new System.Drawing.Size(509, 27);
            this.EditorBinaryText.TabIndex = 0;
            this.EditorBinaryText.Text = "C:\\Program Files (x86)\\UE_4.25\\Engine\\Binaries\\Win64\\UE4Editor-Cmd.exe";
            // 
            // EditorBinaryButton
            // 
            this.EditorBinaryButton.Location = new System.Drawing.Point(518, 3);
            this.EditorBinaryButton.Name = "EditorBinaryButton";
            this.EditorBinaryButton.Size = new System.Drawing.Size(27, 27);
            this.EditorBinaryButton.TabIndex = 1;
            this.EditorBinaryButton.Text = "...";
            this.EditorBinaryButton.UseVisualStyleBackColor = true;
            this.EditorBinaryButton.Click += new System.EventHandler(this.UnrealBinaryPrompt_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.EditorBinaryText);
            this.flowLayoutPanel1.Controls.Add(this.EditorBinaryButton);
            this.flowLayoutPanel1.Controls.Add(this.ProjectGenText);
            this.flowLayoutPanel1.Controls.Add(this.ProjectGenButton);
            this.flowLayoutPanel1.Controls.Add(this.HeaderText);
            this.flowLayoutPanel1.Controls.Add(this.HeaderButton);
            this.flowLayoutPanel1.Controls.Add(this.GameProjectText);
            this.flowLayoutPanel1.Controls.Add(this.GameProjectButton);
            this.flowLayoutPanel1.Controls.Add(this.GamePluginText);
            this.flowLayoutPanel1.Controls.Add(this.GamePluginButton);
            this.flowLayoutPanel1.Controls.Add(this.CreateProject);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(557, 353);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ProjectGenText
            // 
            this.ProjectGenText.AllowDrop = true;
            this.ProjectGenText.Location = new System.Drawing.Point(3, 36);
            this.ProjectGenText.Name = "ProjectGenText";
            this.ProjectGenText.Size = new System.Drawing.Size(509, 27);
            this.ProjectGenText.TabIndex = 2;
            this.ProjectGenText.Text = ".\\UE4GameProjectGenerator\\GameProjectGenerator.uproject";
            // 
            // ProjectGenButton
            // 
            this.ProjectGenButton.Location = new System.Drawing.Point(518, 36);
            this.ProjectGenButton.Name = "ProjectGenButton";
            this.ProjectGenButton.Size = new System.Drawing.Size(27, 27);
            this.ProjectGenButton.TabIndex = 3;
            this.ProjectGenButton.Text = "...";
            this.ProjectGenButton.UseVisualStyleBackColor = true;
            this.ProjectGenButton.Click += new System.EventHandler(this.ProjectGenButton_Click);
            // 
            // HeaderText
            // 
            this.HeaderText.AllowDrop = true;
            this.HeaderText.Location = new System.Drawing.Point(3, 69);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(509, 27);
            this.HeaderText.TabIndex = 4;
            this.HeaderText.Text = ".\\UHTHeaderDump";
            // 
            // HeaderButton
            // 
            this.HeaderButton.Location = new System.Drawing.Point(518, 69);
            this.HeaderButton.Name = "HeaderButton";
            this.HeaderButton.Size = new System.Drawing.Size(27, 27);
            this.HeaderButton.TabIndex = 5;
            this.HeaderButton.Text = "...";
            this.HeaderButton.UseVisualStyleBackColor = true;
            this.HeaderButton.Click += new System.EventHandler(this.HeaderButton_Click);
            // 
            // GameProjectText
            // 
            this.GameProjectText.AllowDrop = true;
            this.GameProjectText.Location = new System.Drawing.Point(3, 102);
            this.GameProjectText.Name = "GameProjectText";
            this.GameProjectText.Size = new System.Drawing.Size(509, 27);
            this.GameProjectText.TabIndex = 6;
            this.GameProjectText.Text = ".\\GameName.uproject";
            // 
            // GameProjectButton
            // 
            this.GameProjectButton.Location = new System.Drawing.Point(518, 102);
            this.GameProjectButton.Name = "GameProjectButton";
            this.GameProjectButton.Size = new System.Drawing.Size(27, 27);
            this.GameProjectButton.TabIndex = 7;
            this.GameProjectButton.Text = "...";
            this.GameProjectButton.UseVisualStyleBackColor = true;
            this.GameProjectButton.Click += new System.EventHandler(this.GameProjectButton_Click);
            // 
            // GamePluginText
            // 
            this.GamePluginText.AllowDrop = true;
            this.GamePluginText.Location = new System.Drawing.Point(3, 135);
            this.GamePluginText.Name = "GamePluginText";
            this.GamePluginText.Size = new System.Drawing.Size(509, 27);
            this.GamePluginText.TabIndex = 8;
            this.GamePluginText.Text = ".\\GameName.upluginmanifest";
            // 
            // GamePluginButton
            // 
            this.GamePluginButton.Location = new System.Drawing.Point(518, 135);
            this.GamePluginButton.Name = "GamePluginButton";
            this.GamePluginButton.Size = new System.Drawing.Size(27, 27);
            this.GamePluginButton.TabIndex = 9;
            this.GamePluginButton.Text = "...";
            this.GamePluginButton.UseVisualStyleBackColor = true;
            this.GamePluginButton.Click += new System.EventHandler(this.GamePluginButton_Click);
            // 
            // CreateProject
            // 
            this.CreateProject.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateProject.Location = new System.Drawing.Point(3, 168);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(542, 185);
            this.CreateProject.TabIndex = 10;
            this.CreateProject.Text = "Create Project";
            this.CreateProject.UseVisualStyleBackColor = true;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            // 
            // HeaderPrompt
            // 
            this.HeaderPrompt.Description = "Select the path to the root directory of UHTHeaderDump, generated from your game " +
    "through UE4SS";
            this.HeaderPrompt.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.HeaderPrompt.ShowNewFolderButton = false;
            this.HeaderPrompt.UseDescriptionForTitle = true;
            // 
            // ProjectGenPrompt
            // 
            this.ProjectGenPrompt.Filter = "uproject files|*.uproject";
            // 
            // GameProjectPrompt
            // 
            this.GameProjectPrompt.Filter = "uproject files|*.uproject";
            // 
            // GamePluginsPrompt
            // 
            this.GamePluginsPrompt.DefaultExt = "unreal plugin manifest |*.upluginmanifest";
            // 
            // OutputPrompt
            // 
            this.OutputPrompt.Description = "Select the directory for the generated project to be output";
            this.OutputPrompt.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.OutputPrompt.UseDescriptionForTitle = true;
            // 
            // Automator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 353);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(575, 400);
            this.MinimumSize = new System.Drawing.Size(575, 400);
            this.Name = "Automator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UE4 Project Generator Automator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private OpenFileDialog EditorBinaryPrompt;
        private TextBox EditorBinaryText;
        private Button EditorBinaryButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox ProjectGenText;
        private Button ProjectGenButton;
        private TextBox HeaderText;
        private Button HeaderButton;
        private FolderBrowserDialog HeaderPrompt;
        private OpenFileDialog ProjectGenPrompt;
        private TextBox GameProjectText;
        private Button GameProjectButton;
        private OpenFileDialog GameProjectPrompt;
        private TextBox GamePluginText;
        private Button GamePluginButton;
        private OpenFileDialog GamePluginsPrompt;
        private Button CreateProject;
        private FolderBrowserDialog OutputPrompt;
    }
}