CREATE DATABASE  IF NOT EXISTS `vehicledatabase` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `vehicledatabase`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: vehicledatabase
-- ------------------------------------------------------
-- Server version	5.7.20-log

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
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicle` (
  `vehicleid` int(11) NOT NULL AUTO_INCREMENT,
  `numberPlate` varchar(20) NOT NULL,
  `currentMileage` decimal(10,2) NOT NULL,
  `rentalCharge` decimal(10,2) NOT NULL,
  `vehicleType` varchar(20) NOT NULL,
  `toilet` bit(1) DEFAULT NULL,
  `numberOfBeds` tinyint(4) DEFAULT NULL,
  `roadType` varchar(50) DEFAULT NULL,
  `under21` bit(1) DEFAULT NULL,
  PRIMARY KEY (`vehicleid`),
  UNIQUE KEY `numberPlate_UNIQUE` (`numberPlate`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES (1,'VG60HLD',11453.22,29.99,'V4WDCar',NULL,NULL,'OFF_ROAD',NULL),(2,'JJ54DER',55101.33,20.45,'V4WDCar',NULL,NULL,'DIRT_ROAD',NULL),(3,'NH60',33121.11,39.45,'V4WDCar',NULL,NULL,'NORMAL_ROAD',NULL),(4,'KL62FFH',68878.56,19.59,'V2WBike',NULL,NULL,NULL,''),(5,'HH60EDF',5003.01,89.99,'Campervan','',4,NULL,NULL),(6,'UU23KIU',2001.23,79.99,'Campervan','\0',2,NULL,NULL);
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-06  9:33:51
