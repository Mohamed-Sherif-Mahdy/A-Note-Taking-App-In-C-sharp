using System.Data;

namespace Notes
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    DataTable notes = new DataTable();


    private void Form1_Load(object sender, EventArgs e)
    {
      notes.Columns.Add("Title");
      notes.Columns.Add("Note");
      dataGridView1.DataSource = notes;
      
    }

    private void Loadbtn_Click(object sender, EventArgs e)
    {
      titlebox.Text = notes.Rows[dataGridView1.CurrentCell.RowIndex][0].ToString();
      Notebox.Text = notes.Rows[dataGridView1.CurrentCell.RowIndex][1].ToString();
    }
    
    private void Deletebtn_Click(object sender, EventArgs e)
    {
      notes.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
    }
    private void NewNotebtn_Click(object sender, EventArgs e)
    {
     Notebox.Clear();
     titlebox.Clear();
    }

    private void Savebtn_Click(object sender, EventArgs e)
    {
      notes.Rows.Add(titlebox.Text, Notebox.Text);
      
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    
    }
  }
}
