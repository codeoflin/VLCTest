using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VLCTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			VlcPlayer.VlcPlayerBase VlcPlayerBase = new VlcPlayer.VlcPlayerBase(Environment.CurrentDirectory + "\\vlc\\plugins\\");
			VlcPlayerBase.SetRenderWindow(pictureBox1.Handle.ToInt32());
			VlcPlayerBase.LoadFile("银河与极光.mp4");
			VlcPlayerBase.Play();
		}
	}
}
