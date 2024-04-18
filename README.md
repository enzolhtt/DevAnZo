## Documentation sur l'installation de la FulBank

# 1) Les prérequis

- Un SGBD : MariaDB ( version 10.5.19 )
- Il vous faudra créer une base de données nommée FulBank.
- Un dump de la base de données est fourni dans le git du projet.

# 2) Modification du code

- Il faudra modifier certaines lignes dans le code pour que la connexion à votre base de données puisse fonctionner.
- Voici les chemins où il y a du code à modifier :
    - ...\Fulbank\Model\Repository\ConnexionRepository.cs
    - ...\Fulbank\Model\Repository\ClientRepository.cs
    - ...\Fulbank\Model\Repository\BeneficiaireRepository.cs
    - ...\Fulbank\Model\Repository\CompteRepository.cs
    - ...\Fulbank\Model\Repository\TransactionRepository.cs

    Et ensuite modifier la chaine de caractère qui s'appelle connectionString qui permet de rentrer les paramètres d'authentification à votre base de données.
    Donc il faut modifier l'adresse IP du server (en mettant l'adresse de la machine où se trouve la BDD), uid qui correspond au nom d'utilisateur de l'utilisateur mariaDB et pwd qui est le mot de passe de l'utilisateur uid.
