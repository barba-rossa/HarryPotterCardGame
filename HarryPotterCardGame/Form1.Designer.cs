using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

partial class Form1
{
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label labelHouse;
    private System.Windows.Forms.Label labelAncestry;
    private System.Windows.Forms.Label labelPatronus;
    private System.Windows.Forms.Label labelWand;

    private void InitializeComponent()
    {
        pictureBox1 = new System.Windows.Forms.PictureBox();
        listBox1 = new System.Windows.Forms.ListBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        labelHouse = new System.Windows.Forms.Label();
        labelAncestry = new System.Windows.Forms.Label();
        labelPatronus = new System.Windows.Forms.Label();
        labelWand = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(150, 200);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new System.Drawing.Point(180, 12);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(150, 199);
        listBox1.TabIndex = 1;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(labelHouse);
        groupBox1.Controls.Add(labelAncestry);
        groupBox1.Controls.Add(labelPatronus);
        groupBox1.Controls.Add(labelWand);
        groupBox1.Location = new System.Drawing.Point(12, 230);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(318, 150);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Character Details";
        // 
        // labelHouse
        // 
        labelHouse.Location = new System.Drawing.Point(10, 20);
        labelHouse.Name = "labelHouse";
        labelHouse.Size = new System.Drawing.Size(150, 23);
        labelHouse.TabIndex = 0;
        // 
        // labelAncestry
        // 
        labelAncestry.Location = new System.Drawing.Point(10, 50);
        labelAncestry.Name = "labelAncestry";
        labelAncestry.Size = new System.Drawing.Size(150, 23);
        labelAncestry.TabIndex = 1;
        // 
        // labelPatronus
        // 
        labelPatronus.Location = new System.Drawing.Point(10, 80);
        labelPatronus.Name = "labelPatronus";
        labelPatronus.Size = new System.Drawing.Size(150, 23);
        labelPatronus.TabIndex = 2;
        // 
        // labelWand
        // 
        labelWand.Location = new System.Drawing.Point(10, 110);
        labelWand.Name = "labelWand";
        labelWand.Size = new System.Drawing.Size(150, 23);
        labelWand.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(350, 400);
        Controls.Add(pictureBox1);
        Controls.Add(listBox1);
        Controls.Add(groupBox1);
        Name = "Form1";
        Text = "Harry Potter Characters";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
    }
}
