/**
 * Ce fichier contient la classe Timer qui vérifie l'inactivité de l'utilisateur.
 * Si l'utilisateur est inactif pendant une durée spécifiée, il est redirigé vers la page de connexion.
 */

using System;
using System.Timers;
using System.Windows.Forms;

namespace CartesAcces2024
{
    /// <summary>
    /// Classe pour gérer le temps d'inactivité de l'utilisateur.
    /// </summary>
    public class Timer
    {
        private DateTime start;

        /// <summary>
        /// Constructeur de la classe.
        /// Il faut initialiser la classe avec l'objet de la fenêtre à surveiller.
        /// </summary>
        /// <param name="form">La fenêtre à surveiller.</param>
        public Timer(Form form)
        {
            Form1 = form;
            start = DateTime.Now;
            Timer1 = new System.Timers.Timer();
            Timer1.Interval = FrequenceDesVerifEnMinute * 60000; // Fréquence de vérification
            Timer1.Elapsed += OnTimeEvent;
            Timer1.AutoReset = true;
            Timer1.Start();
            Form1.MouseMove += Form_MouseMove;
            Globale.Accueil.MouseMove += Form_MouseMove;
        }

        /// <summary>
        /// Durée d'inactivité avant déconnexion (en minutes).
        /// </summary>
        public static int DureeMinute { get; set; } = 15;

        /// <summary>
        /// L'objet de la fenêtre à surveiller.
        /// </summary>
        public Form Form1 { get; set; }

        /// <summary>
        /// Fréquence de vérification (en minutes).
        /// </summary>
        public int FrequenceDesVerifEnMinute { get; set; } = 1;

        /// <summary>
        /// L'objet de la classe System.Timers.Timer.
        /// </summary>
        public System.Timers.Timer Timer1 { get; set; }

        /// <summary>
        /// Ajoute un événement à la fenêtre à surveiller.
        /// </summary>
        public void ajoutEvenement()
        {
            Form1.MouseMove += Form_MouseMove;
            Globale.Accueil.MouseMove += Form_MouseMove;
            Globale.Actuelle.MouseMove += Form_MouseMove;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            start = DateTime.Now; // Réinitialise le temps d'inactivité
        }

        private void OnTimeEvent(object source, ElapsedEventArgs e)
        {
            if (start.Add(TimeSpan.FromMinutes(DureeMinute)) <= DateTime.Now)
                if (Globale.EstConnecte)
                {
                    Globale.EstConnecte = false;
                    Globale.Actuelle = new frmConnection();
                    Globale.Accueil.Invoke(
                        new MethodInvoker(delegate { frmAccueil.OpenChildForm(Globale.Actuelle); }));
                }
        }
    }
}

/**
 * MIT License
 * 
 * Copyright (c) 2023, 2024 Collège Caroline Aigle
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */