namespace notepad;

public partial class Form1 : Form
{

    FontStyle b12 = FontStyle.Bold;
    FontStyle ita = FontStyle.Italic;
    FontStyle r = FontStyle.Regular;
    bool b13 = false;
    bool b14 = false;
    bool itlc = false;

    public Form1()
    {
        InitializeComponent();
        foreach (var item in FontFamily.Families)
        {
            fontbox.Items.Add(item.Name);
        }
        for (int i = 4; i < 50; i++)
        {
            sizebox.Items.Add(i);
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {



    }



    private void button6_Click(object sender, EventArgs e)
    {
        colorDialog1.ShowDialog();
        richTextBox1.ForeColor = colorDialog1.Color;
    }

    private void bold_Click(object sender, EventArgs e)
    {
        var f = new Font(fontbox.SelectedItem.ToString(), (int)(sizebox.SelectedItem), b12);
        richTextBox1.Font = f;
        b13 = true;
        b14 = false;
        itlc = false;
    }

    private void italic_Click(object sender, EventArgs e)
    {
        var f = new Font(fontbox.SelectedItem.ToString(), (int)(sizebox.SelectedItem), ita);
        richTextBox1.Font = f;
        b13 = false;
        b14 = false;
        itlc = true;
    }

    private void simple_Click(object sender, EventArgs e)
    {
        var f = new Font(fontbox.SelectedItem.ToString(), (int)(sizebox.SelectedItem), r);
        richTextBox1.Font = f;
        b13 = false;
        b14 = true;
        itlc = false;
    }

    private void loadbutton_Click(object sender, EventArgs e)
    {

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string filename = openFileDialog1.FileName;
            loadbox.Text = filename;
            richTextBox1.Text = File.ReadAllText(filename);
        }
    }

    private void savebutton_Click(object sender, EventArgs e)
    {
        string text = richTextBox1.Text;
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {


            if (File.Exists(saveFileDialog1.FileName))
            {
                savebox.Text = saveFileDialog1.FileName;
                File.WriteAllText(saveFileDialog1.FileName, text);
            }
            else
            {
                File.AppendAllText(saveFileDialog1.FileName, text);
            }
        }


    }

    private void sizechanged(object sender, EventArgs e)
    {
        if (b13)
        {
            var f = new Font(fontbox.SelectedItem.ToString(), (int)(sizebox.SelectedItem), b12);
            richTextBox1.Font = f;
        }
        else if (b14)
        {
            var f = new Font(fontbox.SelectedItem.ToString(), (int)(sizebox.SelectedItem), r);
            richTextBox1.Font = f;
        }
        else if (itlc)
        {
            var f = new Font(fontbox.SelectedItem.ToString(), (int)(sizebox.SelectedItem), ita);
            richTextBox1.Font = f;
        }
    }

    private void fontchanged(object sender, EventArgs e)
    {

        if (b13)
        {
            var f = new Font(fontbox.SelectedItem.ToString(), (int)(sizebox.SelectedItem), b12);
            richTextBox1.Font = f;
        }
        else if (b14)
        {
            var f = new Font(fontbox.SelectedItem.ToString(), (int)(sizebox.SelectedItem), r);
            richTextBox1.Font = f;
        }
        else if (itlc)
        {
            var f = new Font(fontbox.SelectedItem.ToString(), (int)(sizebox.SelectedItem), ita);
            richTextBox1.Font = f;
        }
    }

    private void left_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
    }

    private void right_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

    }
}
