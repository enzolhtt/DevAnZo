-- MariaDB dump 10.19  Distrib 10.5.23-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: FulBank
-- ------------------------------------------------------
-- Server version	10.5.23-MariaDB-0+deb11u1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Client`
--

DROP TABLE IF EXISTS `Client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Client` (
  `IdClient` int(11) NOT NULL,
  `tel` varchar(50) DEFAULT NULL,
  `Nom` varchar(50) DEFAULT NULL,
  `Prenom` varchar(50) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `rue` varchar(50) DEFAULT NULL,
  `cp` varchar(50) DEFAULT NULL,
  `mail` varchar(50) DEFAULT NULL,
  `mdp` varchar(255) NOT NULL,
  PRIMARY KEY (`IdClient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Client`
--

LOCK TABLES `Client` WRITE;
/*!40000 ALTER TABLE `Client` DISABLE KEYS */;
INSERT INTO `Client` VALUES (1,'0609985462','Laheurte','Enzo','Prunay-le-Gillon','rue du gault','28360','laheurteenzo4@gmail.com','605306b83fe54de0ab9373e98b9fd30d0a44da6e57487f19621d9275cff74b2f'),(2,'0783924870','Brochard','Antonin','Marville-Moutiers-Brûle','21 rue de la Mairie','28500','antonin.brochard@gmail.com','0348beb745f863940c77cc68dc7b724fd5998186f5c2ad4e72febbb6c0be0578'),(3,'0660708090','Mathieu','Marais','Dreux','la-bas','28100','mathieu.marais@gmail.com',''),(4,'0690807060','Ly','Luxtaing','Chartres','jsp','28000','luxtaing.ly@gmail.com','');
/*!40000 ALTER TABLE `Client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Compte`
--

DROP TABLE IF EXISTS `Compte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Compte` (
  `NumeroCompte` int(11) NOT NULL,
  `Solde` double DEFAULT NULL,
  `DateOuverture` date DEFAULT NULL,
  `taux` double DEFAULT NULL,
  `RIB` varchar(50) DEFAULT NULL,
  `IBAN` varchar(50) DEFAULT NULL,
  `Externe` int(11) DEFAULT NULL,
  `idDevise` int(11) NOT NULL,
  `IdType` int(11) NOT NULL,
  `IdClient` int(11) DEFAULT NULL,
  `mdp` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`NumeroCompte`),
  KEY `idDevise` (`idDevise`),
  KEY `IdType` (`IdType`),
  KEY `IdClient` (`IdClient`),
  CONSTRAINT `Compte_ibfk_1` FOREIGN KEY (`idDevise`) REFERENCES `devise` (`idDevise`),
  CONSTRAINT `Compte_ibfk_2` FOREIGN KEY (`IdType`) REFERENCES `Type` (`IdType`),
  CONSTRAINT `Compte_ibfk_3` FOREIGN KEY (`IdClient`) REFERENCES `Client` (`IdClient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Compte`
--

LOCK TABLES `Compte` WRITE;
/*!40000 ALTER TABLE `Compte` DISABLE KEYS */;
INSERT INTO `Compte` VALUES (10,2650,'2023-09-04',0,'11111111111111111111111111111111111','FR22222222222222222222222222',0,1,1,1,'1'),(11,19385,'2023-10-02',0,'22222222222222222222222222222222222','FR11111111111111111111111111',0,1,1,2,'0348beb745f863940c77cc68dc7b724fd5998186f5c2ad4e72febbb6c0be0578'),(12,100,'2023-12-18',0,'77777777777777777777777777777777777','FR55555555555555555555555555',0,1,1,3,'2'),(13,22076,'2023-12-18',0,'33333333333333333333333333333333333','FR33333333333333333333333333',0,1,1,4,'3'),(14,0.05,'2023-03-19',0,'\"\"','\"\"',0,2,3,2,'4');
/*!40000 ALTER TABLE `Compte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Connexion`
--

DROP TABLE IF EXISTS `Connexion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Connexion` (
  `IdClient` int(11) NOT NULL,
  `idDAB` int(11) NOT NULL,
  `DateConnexion` datetime DEFAULT NULL,
  PRIMARY KEY (`IdClient`,`idDAB`),
  KEY `idDAB` (`idDAB`),
  CONSTRAINT `Connexion_ibfk_1` FOREIGN KEY (`IdClient`) REFERENCES `Client` (`IdClient`),
  CONSTRAINT `Connexion_ibfk_2` FOREIGN KEY (`idDAB`) REFERENCES `DAB` (`idDAB`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Connexion`
--

LOCK TABLES `Connexion` WRITE;
/*!40000 ALTER TABLE `Connexion` DISABLE KEYS */;
/*!40000 ALTER TABLE `Connexion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `DAB`
--

DROP TABLE IF EXISTS `DAB`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `DAB` (
  `idDAB` int(11) NOT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `rue` varchar(50) DEFAULT NULL,
  `cp` int(11) DEFAULT NULL,
  PRIMARY KEY (`idDAB`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `DAB`
--

LOCK TABLES `DAB` WRITE;
/*!40000 ALTER TABLE `DAB` DISABLE KEYS */;
INSERT INTO `DAB` VALUES (1,'Dreux','une rue',28100),(2,'Chartres','une rue',28000);
/*!40000 ALTER TABLE `DAB` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Transaction`
--

DROP TABLE IF EXISTS `Transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Transaction` (
  `idTransac` int(11) NOT NULL AUTO_INCREMENT,
  `DateTransaction` datetime DEFAULT NULL,
  `montantEmeteur` double DEFAULT NULL,
  `taux` varchar(50) DEFAULT NULL,
  `numCompteDeb` int(11) NOT NULL,
  `numCompteCre` int(11) NOT NULL,
  `idDAB` int(11) NOT NULL,
  PRIMARY KEY (`idTransac`),
  KEY `NumeroCompte` (`numCompteDeb`),
  KEY `NumeroCompte_1` (`numCompteCre`),
  KEY `idDAB` (`idDAB`),
  CONSTRAINT `Transaction_ibfk_1` FOREIGN KEY (`numCompteDeb`) REFERENCES `Compte` (`NumeroCompte`),
  CONSTRAINT `Transaction_ibfk_2` FOREIGN KEY (`numCompteCre`) REFERENCES `Compte` (`NumeroCompte`),
  CONSTRAINT `Transaction_ibfk_3` FOREIGN KEY (`idDAB`) REFERENCES `DAB` (`idDAB`)
) ENGINE=InnoDB AUTO_INCREMENT=71 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Transaction`
--

LOCK TABLES `Transaction` WRITE;
/*!40000 ALTER TABLE `Transaction` DISABLE KEYS */;
INSERT INTO `Transaction` VALUES (2,'2023-12-19 10:27:47',1000,'0',11,10,2),(3,'2023-12-19 10:28:30',1000,'0',11,10,2),(4,'2023-12-19 10:36:58',50,'0',11,10,2),(33,'2023-12-19 14:05:47',500,'0',11,10,2),(34,'2023-12-19 14:06:08',10,'0',11,10,2),(35,'2023-12-20 13:27:15',25,'0',11,10,2),(36,'2023-12-20 13:27:30',25,'0',11,10,2),(37,'2023-12-20 14:48:50',500,'0',11,10,2),(39,'2023-12-20 15:11:57',10,'0',11,10,2),(40,'2023-12-20 15:12:50',10,'0',11,13,2),(41,'2023-12-20 15:13:02',1,'0',11,13,2),(42,'2024-03-11 09:29:51',60,'0',10,11,2),(43,'2024-03-11 09:30:27',60,'0',10,11,2),(44,'2024-03-11 09:31:37',100,'0',10,11,2),(45,'2024-03-11 12:28:10',100,'0',11,10,2),(46,'2024-03-11 12:28:17',100,'0',11,10,2),(49,'2024-03-12 08:25:36',10,'0',11,10,2),(50,'2024-03-12 08:27:45',10,'0',11,10,2),(51,'2024-03-12 08:29:49',10,'0',11,10,2),(52,'2024-03-12 08:32:49',1000,'0',11,13,2),(53,'2024-03-12 08:33:16',358,'0',11,10,2),(54,'2024-03-12 08:47:28',50,'0',11,13,2),(55,'2024-03-12 08:47:29',50,'0',11,13,2),(56,'2024-03-12 08:47:30',50,'0',11,13,2),(57,'2024-03-12 08:47:30',50,'0',11,13,2),(58,'2024-03-12 08:47:30',50,'0',11,13,2),(59,'2024-03-12 08:47:31',50,'0',11,13,2),(60,'2024-03-12 08:53:04',500,'0',11,13,2),(61,'2024-03-12 08:56:26',15,'0',11,13,2),(63,'2024-03-12 13:14:21',50,'0',10,11,2),(65,'2024-03-13 13:41:33',100,'0',10,11,2),(67,'2024-03-13 13:44:27',15,'0',11,11,2),(69,'2024-04-08 15:58:50',50,'0',11,10,2),(70,'2024-04-08 16:06:11',100,'0',10,11,2);
/*!40000 ALTER TABLE `Transaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Type`
--

DROP TABLE IF EXISTS `Type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Type` (
  `IdType` int(11) NOT NULL,
  `TypeDeCompte` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Type`
--

LOCK TABLES `Type` WRITE;
/*!40000 ALTER TABLE `Type` DISABLE KEYS */;
INSERT INTO `Type` VALUES (1,'courant'),(2,'epargne'),(3,'crypto'),(4,'livret');
/*!40000 ALTER TABLE `Type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bénéficiaire`
--

DROP TABLE IF EXISTS `bénéficiaire`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bénéficiaire` (
  `idBeneficiaire` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `RIB` varchar(50) DEFAULT NULL,
  `IBAN` varchar(50) DEFAULT NULL,
  `IdClient` int(11) NOT NULL,
  `prenom` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idBeneficiaire`),
  KEY `IdClient` (`IdClient`),
  CONSTRAINT `bénéficiaire_ibfk_1` FOREIGN KEY (`IdClient`) REFERENCES `Client` (`IdClient`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bénéficiaire`
--

LOCK TABLES `bénéficiaire` WRITE;
/*!40000 ALTER TABLE `bénéficiaire` DISABLE KEYS */;
INSERT INTO `bénéficiaire` VALUES (9,'Brochard','22222222222222222222222222222222222','FR1111111111111111111111111',1,'Antonin'),(27,'Laheurte','11111111111111111111111111111111111','FR2222222222222222222222222',2,'Enzo'),(59,'Ettabi','77777777777777777777777777777777777','FR5555555555555555555555555',2,'Younes'),(60,'Ly','33333333333333333333333333333333333','FR3333333333333333333333333',2,'Luxtaing');
/*!40000 ALTER TABLE `bénéficiaire` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devise`
--

DROP TABLE IF EXISTS `devise`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devise` (
  `idDevise` int(11) NOT NULL,
  `TypeDeDevise` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idDevise`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devise`
--

LOCK TABLES `devise` WRITE;
/*!40000 ALTER TABLE `devise` DISABLE KEYS */;
INSERT INTO `devise` VALUES (1,'Euro'),(2,'bitcoin'),(3,'ethereum'),(4,'dogecoin'),(5,'cardano');
/*!40000 ALTER TABLE `devise` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-08 18:11:08
