-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: a_cichurski
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.19-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `klienci`
--

DROP TABLE IF EXISTS `klienci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `klienci` (
  `idKlienta` int(11) NOT NULL AUTO_INCREMENT,
  `Imie` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `Nazwisko` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `NumerTelefonu` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`idKlienta`),
  UNIQUE KEY `idKlienta_UNIQUE` (`idKlienta`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klienci`
--

LOCK TABLES `klienci` WRITE;
/*!40000 ALTER TABLE `klienci` DISABLE KEYS */;
INSERT INTO `klienci` VALUES (1,'Adrian','Adamowicz','510542698'),(5,'Krystian','Nowak','98563244'),(7,'Piotr','Janowski','789542698'),(8,'Szymon','Kowalski','639542698'),(12,'Mariusz','Drzewoski','654793211'),(13,'Arkadiusz','Cichurski','533829465'),(14,'Bartek','Bednarczyk','658644589');
/*!40000 ALTER TABLE `klienci` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `naszesamochody`
--

DROP TABLE IF EXISTS `naszesamochody`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `naszesamochody` (
  `idSamochodu` int(11) NOT NULL AUTO_INCREMENT,
  `Marka` varchar(45) DEFAULT NULL,
  `Model` varchar(45) DEFAULT NULL,
  `Kolor` varchar(45) DEFAULT NULL,
  `Rocznik` int(11) DEFAULT NULL,
  `CenaZaGodzine` float DEFAULT NULL,
  `CzyZwrocono` enum('tak','nie') DEFAULT 'tak',
  PRIMARY KEY (`idSamochodu`),
  UNIQUE KEY `idSamochodu_UNIQUE` (`idSamochodu`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `naszesamochody`
--

LOCK TABLES `naszesamochody` WRITE;
/*!40000 ALTER TABLE `naszesamochody` DISABLE KEYS */;
INSERT INTO `naszesamochody` VALUES (3,'Ford','GT','Czerwony',2004,400,'tak'),(5,'Nissan','370z','Czarny',2010,450,'tak'),(7,'Porsche','Carrera GT','Czerwony',2007,750,'tak'),(8,'Porsche','911 GT3 RS','Czerwony',2014,1200,'tak'),(9,'Porsche','918 Spyder','Niebieski',2013,800,'tak'),(12,'Lamborghini','Huracan','Zielony',2013,1300,'tak'),(13,'Ferrari','458','Czerwony',2007,700,'tak'),(23,'Nissan','Skyline R33','Czerwony',1990,800,'tak'),(30,'Nissan','R32','Czerwony',1986,1200,'tak'),(31,'Nissan','Skyline R34','Czarny',2001,750,'tak'),(33,'Ford','Mustang','Czarny',1978,300,'tak'),(34,'Lamborghini','Diablo SV','Zloty',2000,200,'tak'),(35,'Ford','Focus RS','Niebieski',2007,150,'tak'),(36,'Ford','Mustang GT500','Srebrny',2013,400,'tak'),(37,'Ferrari','Enzo','Czerwony',2004,300,'tak'),(38,'Ferrari','F430','Czarny',2002,200,'tak'),(39,'Lamborghini','Gallardo','Bialy',2004,200,'tak');
/*!40000 ALTER TABLE `naszesamochody` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wypozyczenia`
--

DROP TABLE IF EXISTS `wypozyczenia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wypozyczenia` (
  `idWypozyczenia` int(11) NOT NULL AUTO_INCREMENT,
  `idSamochodu` int(11) NOT NULL,
  `idKlienta` int(11) NOT NULL,
  `NaIleGodzin` int(11) DEFAULT NULL,
  PRIMARY KEY (`idWypozyczenia`),
  KEY `idSamochodu_idx` (`idSamochodu`),
  KEY `idKlienta_idx` (`idKlienta`),
  CONSTRAINT `idKlienta` FOREIGN KEY (`idKlienta`) REFERENCES `klienci` (`idKlienta`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `idSamochodu` FOREIGN KEY (`idSamochodu`) REFERENCES `naszesamochody` (`idSamochodu`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wypozyczenia`
--

LOCK TABLES `wypozyczenia` WRITE;
/*!40000 ALTER TABLE `wypozyczenia` DISABLE KEYS */;
/*!40000 ALTER TABLE `wypozyczenia` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-11 21:00:37
