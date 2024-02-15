namespace Notes
{
  partial class Form1
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
      Notebox = new TextBox();
      Note = new Label();
      titlebox = new TextBox();
      label1 = new Label();
      Loadbtn = new Button();
      NewNotebtn = new Button();
      Deletebtn = new Button();
      Savebtn = new Button();
      dataGridView1 = new DataGridView();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      SuspendLayout();
      // 
      // Notebox
      // 
      Notebox.Location = new Point(462, 134);
      Notebox.Multiline = true;
      Notebox.Name = "Notebox";
      Notebox.Size = new Size(394, 517);
      Notebox.TabIndex = 0;
      // 
      // Note
      // 
      Note.AutoSize = true;
      Note.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
      Note.Location = new Point(620, 100);
      Note.Name = "Note";
      Note.Size = new Size(67, 31);
      Note.TabIndex = 1;
      Note.Text = "Note";
      // 
      // titlebox
      // 
      titlebox.Location = new Point(462, 55);
      titlebox.Name = "titlebox";
      titlebox.Size = new Size(394, 27);
      titlebox.TabIndex = 2;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label1.Location = new Point(595, 9);
      label1.Name = "label1";
      label1.Size = new Size(121, 31);
      label1.TabIndex = 3;
      label1.Text = "Note Title";
      // 
      // Loadbtn
      // 
      Loadbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
      Loadbtn.Location = new Point(22, 509);
      Loadbtn.Name = "Loadbtn";
      Loadbtn.Size = new Size(192, 48);
      Loadbtn.TabIndex = 4;
      Loadbtn.Text = "Load";
      Loadbtn.UseVisualStyleBackColor = true;
      Loadbtn.Click += Loadbtn_Click;
      // 
      // NewNotebtn
      // 
      NewNotebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
      NewNotebtn.Location = new Point(22, 575);
      NewNotebtn.Name = "NewNotebtn";
      NewNotebtn.Size = new Size(192, 44);
      NewNotebtn.TabIndex = 6;
      NewNotebtn.Text = "New Note";
      NewNotebtn.UseVisualStyleBackColor = true;
      NewNotebtn.Click += NewNotebtn_Click;
      // 
      // Deletebtn
      // 
      Deletebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
      Deletebtn.Location = new Point(231, 509);
      Deletebtn.Name = "Deletebtn";
      Deletebtn.Size = new Size(184, 48);
      Deletebtn.TabIndex = 8;
      Deletebtn.Text = "Delete";
      Deletebtn.UseVisualStyleBackColor = true;
      Deletebtn.Click += Deletebtn_Click;
      // 
      // Savebtn
      // 
      Savebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
      Savebtn.Location = new Point(231, 575);
      Savebtn.Name = "Savebtn";
      Savebtn.Size = new Size(184, 44);
      Savebtn.TabIndex = 9;
      Savebtn.Text = "Save";
      Savebtn.UseVisualStyleBackColor = true;
      Savebtn.Click += Savebtn_Click;
      // 
      // dataGridView1
      // 
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Location = new Point(12, 55);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.RowHeadersWidth = 51;
      dataGridView1.Size = new Size(403, 435);
      dataGridView1.TabIndex = 10;
      dataGridView1.CellContentClick += dataGridView1_CellContentClick;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(887, 682);
      Controls.Add(dataGridView1);
      Controls.Add(Savebtn);
      Controls.Add(Deletebtn);
      Controls.Add(NewNotebtn);
      Controls.Add(Loadbtn);
      Controls.Add(label1);
      Controls.Add(titlebox);
      Controls.Add(Note);
      Controls.Add(Notebox);
      Name = "Form1";
      Text = "Note Taker";
      Load += Form1_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox Notebox;
    private Label Note;
    private TextBox titlebox;
    private Label label1;
    private Button Loadbtn;
    private Button NewNotebtn;
    private Button Deletebtn;
    private Button Savebtn;
    private DataGridView dataGridView1;
  }
}
