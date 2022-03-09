using System;
using System.Threading;

namespace Principal{

    class Base{
       
        static void Main(string[] args){

            string[] Pos = new string[] {"0","1","2","3","4","5"};
            int end =0;

            Console.WriteLine($"Jeu De Jarre");
            Console.WriteLine($"Tapez Entré pour commencé\n");
            Console.ReadLine();
            string Choix="";

                while(end == 0){
                    bool part =false;
                    bool bon =false;


                    while(bon != true){
                        Console.WriteLine("A quel Niveau Souhaitez vous jouer ?\n0-Les Règles\n1-Niveau 1\n2-Niveau 2\n3-Niveau 3\n4-Niveau Personalisé\n5-Quitté\n");
                        Console.Write("Vontre choix -> ");
                        Choix = Console.ReadLine();

                        foreach(string j in Pos){
                            bon = j == Choix;
                            if(bon == true)
                                break;
                        }
                    }

                    switch(Choix){
                        
                        case "0":
                            Console.Write($"Les Régles : \nDans le Jeu de Jarre, le but du jeu est de survivre le plus longtemps\nen ouvrant des jarres parmis un nombre de jarre inscrit en donnant sont nombre:\n");
                            Thread.Sleep(1500);
                            Console.Write($"-sois il a un serpent dans la jarre et vous perdez une clé\n-sois vous obtenez une clé\n");
                            Thread.Sleep(1500);
                            Console.WriteLine($"si vous avez plus de clés, vous perdez\nvous gagnez lorseque vous avez 3clé\n");
                            Thread.Sleep(1000);
                            Console.WriteLine($"Niveau 1----\nDans ce Niveau la, il y a 1 serpend pour 5 Jarre, les chance sont donc de 80% (soit 4/5)\n");
                            Thread.Sleep(2500);
                            Console.WriteLine($"Niveau 2----\nDans ce Niveau la, il y a 2 serpend pour 5 Jarre, les chance sont donc de 60% (soit 3/5)\n");
                            Thread.Sleep(2300);
                            Console.WriteLine($" Niveau 3----\nDans ce Niveau la, il y a 4 serpend pour 5 Jarre, les chance sont donc de 20% (soit 1/5)\n");
                            Thread.Sleep(2300);
                            Console.WriteLine($"Mode Personalisé----\nDans ce Mode la, il est possible de séléctioné le nombre de jarre total et le nombre de serpent\ndans les jarres, ainsi que le nombre clé demandé pour gagné\n");
                            Console.Write("Appuyer entré pour revenir au menu");
                            Console.ReadLine();
                            break;
                        
                        case "1":
                            while(part != true){
                                int nombrecle =0;
                                while(nombrecle !=3 && nombrecle != -1){
                                    Dictionary<int,string> LesJaj = new Dictionary<int, string>(){{1,"Gagné"},{2,"Gagné"},{3,"Gagné"},{4,"Gagné"},{5,"Gagné"}};
                                    LesJaj= lonk.Melange(LesJaj,1);
                                    nombrecle=lonk.VerdiqueJarre(LesJaj,nombrecle,3);
                                }
                                Console.WriteLine("Voulez vous rejouez une parti ?");
                                part=lonk.Cout();
                            }
                            break;
                        
                        case "2":
                            while(part != true){
                                    int nombrecle =0;
                                    while(nombrecle !=3 && nombrecle != -1){
                                        Dictionary<int,string> LesJaj = new Dictionary<int, string>(){{1,"Gagné"},{2,"Gagné"},{3,"Gagné"},{4,"Gagné"},{5,"Gagné"}};
                                        LesJaj= lonk.Melange(LesJaj,2);
                                        nombrecle=lonk.VerdiqueJarre(LesJaj,nombrecle,3);
                                    }
                                    Console.WriteLine("Voulez vous rejouez une parti ?");
                                    part=lonk.Cout();
                                }
                                break;
                        
                        case "3":
                            while(part != true){
                                int nombrecle =0;
                                while(nombrecle !=3 && nombrecle != -1){
                                    Dictionary<int,string> LesJaj = new Dictionary<int, string>(){{1,"Gagné"},{2,"Gagné"},{3,"Gagné"},{4,"Gagné"},{5,"Gagné"}};
                                    LesJaj= lonk.Melange(LesJaj,4);
                                    nombrecle=lonk.VerdiqueJarre(LesJaj,nombrecle,3);
                                }
                                Console.WriteLine("Voulez vous rejouez une parti ?");
                                part=lonk.Cout();
                            }
                            break;

                        case "4":
                            while(part != true){
                                int nombrecle =0;
                                Console.Write("Entrez un nombre de Jarre : ");
                                int nbjarre = Int32.Parse(Console.ReadLine());
                                Console.Write("Entrez un nombre de serpend : ");
                                int nbshnak = Int32.Parse(Console.ReadLine());
                                Console.Write("Entrez un nombre de Clés necessaire pour gagner : ");
                                int nbclf = Int32.Parse(Console.ReadLine());

                                while(nombrecle != nbclf && nombrecle !=-1){
                                        Dictionary<int,string> LesJaj = new Dictionary<int, string>();
                                        int i;
                                        for(i=1; i != nbjarre+1; i++){
                                            LesJaj.Add(i,"Gagné");
                                        }
                                        LesJaj= lonk.Melange(LesJaj, nbshnak);
                                        nombrecle=lonk.VerdiqueJarre(LesJaj,nombrecle,nbclf);
                                }
                                Console.WriteLine("Voulez vous rejouez une parti ?");
                                part=lonk.Cout();
                            }
                            break;

                        

                        default:
                            end++;
                            Console.WriteLine($"Programmer par : Kyla Créa \nMerci d'avoir Jouer");
                            break;

                    








                    }
                }  
        } 
    }
}