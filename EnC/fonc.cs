using System;

namespace Principal{
    

    class lonk{
        static public Dictionary<int, string> Melange(Dictionary<int,string>  dickdebase, int Shnake){
            List<int> Tous = new List<int>();
            foreach( KeyValuePair<int, string> i in dickdebase){
                Tous.Add(i.Key);
            }
            while(Shnake != 0){
                var alez = new Random();
                int inde = Tous[alez.Next(Tous.Count)];
                dickdebase[inde]="Perdu";
                Tous.Remove(inde);
                Shnake --;
            }
            return dickdebase;
            }
        
        static public int VerdiqueJarre(Dictionary<int,string> DicoJarre, int cle, int gg){
            List<int> Lesjarre = new List<int>();
            foreach( KeyValuePair<int, string> i in DicoJarre){
                Lesjarre.Add(i.Key);
            }


            int choix = 0;

            while(choix ==0){
                Console.WriteLine();
                Console.WriteLine($"Dans la salle, {Lesjarre.Count()} Jarres se présente devant vous, la quel souhaiter vous ouvrir ?");
                Console.WriteLine($"(pour selectionné une jarre donnez un chiffre de 1 a {Lesjarre.Count()})\n");
                Console.WriteLine($"vous possédez {cle}");

                string laselec=Console.ReadLine();

                choix = Int32.Parse(laselec);

                if(choix >Lesjarre.Count()){
                    choix=0;
                    Console.WriteLine("Aucune Jarre a ce chiffre on dirait ?");
                }

            }

            

            if(DicoJarre[choix] == "Perdu"){
                Console.Write($"\nUn Shhhnake sort très vite de la Jarre et emporte une de vos clés avec lui\n");
                Console.WriteLine($"alors que les Autre jarre se change en poussier, vous vous dirigez vers la porte");
                cle -=1;

                Console.Write("Appuyer sur une touche pour Continuez\n");
                Console.ReadLine();

                if(cle == -1)
                {
                    Console.Write($"En arrivant devant la porte, vous vous rendez compte que vous n'avez plus de clef\nLe donjon se met a tremblez, vous en sortez a tout vitesse\nDefaite !");
                    Console.ReadLine();
                }
            }

            else{
                Console.Write($"\nEn Ouvrant la jarre, vous y découvrez Une Clé, Vous la prenez en souriant\n");
                Console.WriteLine($"alors que les Autre jarre se change en poussier, vous vous dirigez vers la porte");
                cle +=1;

                Console.Write("Appuyer sur une touche pour Continuez\n");
                Console.ReadLine();

                if(cle == gg)
                {
                    Console.Write($"Sur cet porte vous y appercevez 3 verrou, vous y inserrez les 3 clés trouver\nVous y trouvez la salle des trèsors remplit d'or !!\n Victoire !");
                    Console.ReadLine();
                }
            }

            return cle;
        }


        static public bool Cout(){
            Console.Write("(O/N) : ");
            string question=Console.ReadLine();

            while(question.ToUpper() != "O" && question.ToUpper() !="N"){
                Console.WriteLine("Votre Selection n'est pas valide, O = oui, N = non");
                Console.Write("(O/N) : ");
                question=Console.ReadLine();
            }
            if(question.ToUpper() == "O"){
                return false;
            }
            else{
                return true;
            }

            

            
        }
    
    }
        
}