using Engine;
using System;
using System.Windows.Forms;

namespace SuperAdventure
{
  public partial class SuperAdventure : Form
  {
    private Player _player;

    public SuperAdventure()
    {
      InitializeComponent();
      _player = new Player();
      _player.CurrentHitPoints = 10;
      _player.MaximumHitPoints = 10;
      _player.Gold = 20;
      _player.ExperiencePoints = 0;
      _player.Level = 1;

      lblHitPoints.Text = _player.CurrentHitPoints.ToString();
      lblGold.Text = _player.Gold.ToString();
      lblExperience.Text = _player.ExperiencePoints.ToString();
      lblLevel.Text = _player.Level.ToString();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void lblHitPoints_Click(object sender, EventArgs e)
    {

    }

    private void SuperAdventure_Load(object sender, EventArgs e)
    {

    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      lblGold.Text = "123";
    }
  }
}
