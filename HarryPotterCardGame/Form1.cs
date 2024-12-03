using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        var characters = await DataFetcher.GetCharactersAsync();
        listBox1.DataSource = characters;
        listBox1.DisplayMember = "Name";
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem is HarryPotterCharacter character)
        {
            groupBox1.Text = character.Name;
            pictureBox1.ImageLocation = character.Image;
            labelHouse.Text = $"House: {character.House}";
            labelAncestry.Text = $"Ancestry: {character.Ancestry}";
            labelPatronus.Text = $"Patronus: {character.Patronus}";
            labelWand.Text = $"Wand: {character.Wand.Wood}, {character.Wand.Core}, {character.Wand.Length ?? 0} inches";
        }
    }
}
