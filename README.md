
# Installer FulBank

Voici un petit guide pour faire fonctionner notre projet. 




## Base de données

**SGBD** : MariaDB 

**version** : 10.5.19-MariaDB

Un dump de la base de données vous a été fourni. 


## Connection db dans l'application

chemin : ...\Fulbank\Model\Repository\ConnexionRepository.cs

La variable "connectionString" sert a rentrer les paramètres d'authentification à la base de données.

exemple : private string connectionString = "server=172.16.119.26; uid=brochard;pwd=admin;database=FulBank";
