namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        Console.WriteLine("Bonjour,je m'apelle Matteo j'ai 18 ans et mon jeu préféré est Sea of Thieves");
        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Quel est ton nom ?");
        Console.ReadLine();
        Console.WriteLine("Quel est ton âge ? ");
        int age = Convert.ToInt32(Console.ReadLine());
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        if (age >= 18) 
        {
            Console.WriteLine("Tu es majeur");
        } else
        {
            Console.WriteLine("Tu es mineur");
        }
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        Console.WriteLine("Combien d'euro as-tu?");
        int euro = Convert.ToInt32(Console.ReadLine());
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Choisis entre ces quatres armes ");
        int arme1 = 1;
        Console.WriteLine("1 Épée - 25 euros");
        int arme2 = 2;
        Console.WriteLine("2 Lance - 35 euros");
        int arme3 = 3;
        Console.WriteLine("3 Hallebarde - 45 euros");
        int arme4 = 4;
        Console.WriteLine("4 Rapière - 30 euros");
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        int answer = (Convert.ToInt32(Console.ReadLine()));
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        if(euro <= 25)
        {
            Console.WriteLine("Tu n'as pas assez d'argent");
        }
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}