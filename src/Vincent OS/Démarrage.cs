﻿using System;

namespace Vincent_OS
{
    public partial class Démarrage
    {
        public Démarrage()
        {
            InitializeComponent();
        }
        private void Démarrage_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(2);
            if (ProgressBar1.Value == 100)
            {
                Timer1.Stop();
                My.MyProject.Forms.Login.Show();
                Close();
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.startingSound);
                backmusic.Play();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}