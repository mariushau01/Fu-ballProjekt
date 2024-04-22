using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FußballProjekt.Lib
{
    public class Game
    {
        private List<Team> teams;

        private Team aktuellesTeam;

        private int torTeam1 = 0;
        private int torTeam2 = 0;

        public Game(List<Team> teams)
        {
            this.teams = teams;
            this.aktuellesTeam = teams[0]; // Erstes Team startet
        }

        public void StarteSpiel()
        {
            // 5 Schüsse pro Team
            for (int i = 0; i < 10; i++)
            {
                // Aktuelles Team ermitteln
                aktuellesTeam = i % 2 == 0 ? teams[0] : teams[1]; // wenn i gerade = aktuellesTeam auf teams[0] gesetzt
                                                                  // wenn i ungerade = aktuellesTeam auf teams[1] gesetzt
                                                                  // Bedingung ? Ausdruck1 : Ausdruck2
                                                                  // Wenn die Bedingung wahr ist, wird Ausdruck1 ausgeführt.
                                                                  // Wenn die Bedingung falsch ist, wird Ausdruck2 ausgeführt.
                
                bool tor = SimuliereBenutzereingabe();

                Console.WriteLine($"Spielername für den Schuss:");

                string spielerName = Console.ReadLine();


                // Ergebnis aktualisieren
                if (tor)
                    {
                        if (aktuellesTeam == teams[0])
                        {
                            torTeam1++;
                        }
                        else
                        {
                            torTeam2++;
                        }
                    }

                    // Nächstes Team
                    aktuellesTeam = aktuellesTeam == teams[0] ? teams[1] : teams[0];
                }

                // Spielende und Ergebnis ausgeben
                ZeigeErgebnis();
            }


            private bool SimuliereBenutzereingabe()
            {
                Console.WriteLine($"{aktuellesTeam.Teamname} ist am Ball. Trifft der Spieler? (Ja/Nein)");

            
                string benutzerEingabe = Console.ReadLine().ToLower();

            
                if (benutzerEingabe == "ja")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        // Methode zum Anzeigen des Spielstandes und Ergebnisses
        private void ZeigeErgebnis()
        {
            Console.WriteLine("Spiel beendet!");
            Console.WriteLine($"{teams[0].Teamname}: {torTeam1} Tore");
            Console.WriteLine($"{teams[1].Teamname}: {torTeam2} Tore");

            if (torTeam1 > torTeam2)
            {
                Console.WriteLine($"{teams[0].Teamname} gewinnt!");
            }
            else if (torTeam1 < torTeam2)
            {
                Console.WriteLine($"{teams[1].Teamname} gewinnt!");
            }
            else
            {
                Console.WriteLine("Unentschieden!");
            }
        }
    }
}
