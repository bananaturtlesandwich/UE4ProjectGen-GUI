namespace UE4ProjectGeneratorAutomator;

public partial class Automator : Form
{
    public Automator() => InitializeComponent();

    void UnrealBinaryPrompt_Click(object sender, EventArgs e)
    {
        if (EditorBinaryPrompt.ShowDialog() == DialogResult.OK) EditorBinaryText.Text = EditorBinaryPrompt.FileName;
    }

    void HeaderButton_Click(object sender, EventArgs e)
    {
        if (HeaderPrompt.ShowDialog() == DialogResult.OK) HeaderText.Text = HeaderPrompt.SelectedPath;
    }

    void ProjectGenButton_Click(object sender, EventArgs e)
    {
        if (ProjectGenPrompt.ShowDialog() == DialogResult.OK) ProjectGenText.Text = ProjectGenPrompt.FileName;
    }

    void GameProjectButton_Click(object sender, EventArgs e)
    {
        if (GameProjectPrompt.ShowDialog() == DialogResult.OK) GameProjectText.Text = GameProjectPrompt.FileName;
    }

    void GamePluginButton_Click(object sender, EventArgs e)
    {
        if (GamePluginsPrompt.ShowDialog() == DialogResult.OK) GamePluginText.Text = GamePluginsPrompt.FileName;
    }

    void CreateProject_Click(object sender, EventArgs e)
    {
        const char quote = '\"';
        if (OutputPrompt.ShowDialog() == DialogResult.OK)
        {
            string batch = @$".\{OutputPrompt.SelectedPath.Split('\\')[OutputPrompt.SelectedPath.Split('\\').Length - 1]}.bat";
            File.WriteAllText(batch, $"{quote}{EditorBinaryText.Text}{quote} {quote}{ProjectGenText.Text}{quote} -run=ProjectGenerator -HeaderRoot={quote}{HeaderText.Text}{quote} -ProjectFile={quote}{GameProjectText.Text}{quote} -PluginManifest={quote}{GamePluginText.Text}{quote} -OutputDir={quote}{OutputPrompt.SelectedPath}{quote} -stdout -unattended -NoLogTimes");
            System.Diagnostics.Process.Start(batch);
        }
    }
}