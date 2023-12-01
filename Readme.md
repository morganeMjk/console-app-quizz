# Récupérer le projet

Bienvenue dans le projet de quiz ! Pour récupérer le code source, suivez ces étapes simples :

- Clonez le dépôt Git dans le répertoire de votre choix :

        git clone https://github.com/morganeMjk/console-app-quizz.git

- Accédez au répertoire du projet :

        cd console-app-quizz

# Lancer le projet 

- Build du projet :

        dotnet build

- Exécution du programme :

        dotnet run


# Les étapes de mon jeu de quizz :

- Accueil du joueur
- Présentation des différentes actions prossibles
- Récupération & vérification du choix de l'utilisateur
- S'il choisi de participer à un quiz aléatoire :
    - Récupération de toutes les questions depuis un fichier .csv
    - Début du quiz :
        - Initilisation du score de l'utilisateur
	    - Création d'un cycle de 3 questions choisies aléatoirement parmis la liste de questions
	    - Récupération & Vérification du choix de l'utilisateur
	    - Incrémentation du score en cas de bonne réponse
    - Fin du quiz :
	    - Affichage du score total de l'utilisateur
	    - Présentation des différentes actions possibles
	    - Récupération & Vérification du choix de l'utilisateur (retour au menu principal ou quitter le programme)

- S'il choisi de participer à un quiz par catégorie :
    - Présentation des différentes catégories à l'utilisateur
    - Récupération & Vérification du choix de l'utilisateur pour déterminer la catégorie souhaitée
    - Récupération de toutes les questions de cette catégorie depuis un fichier .csv
    - Début du quiz :
        - Initilisation du score de l'utilisateur
	    - Création d'un cycle de 3 questions choisies aléatoirement parmis la liste de questions de la catégorie souhaitée
	    - Récupération & Vérification du choix de l'utilisateur
	    - Incrémentation du score en cas de bonne réponse
    - Fin du quiz:
	    - Affichage du score total de l'utilisateur
	    - Présentation des différentes actions possibles
	    - Récupération & vérification du choix de l'utilisateur (retour au menu principal ou quitter le programme)

- S'il choisi de quitter :
    - Arrêt du programme
