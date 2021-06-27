CREATE DATABASE  IF NOT EXISTS `ieduca` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ieduca`;
-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ieduca
-- ------------------------------------------------------
-- Server version	8.0.24

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20210626151532_01-Init-Database','5.0.7');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `albumes`
--

LOCK TABLES `albumes` WRITE;
/*!40000 ALTER TABLE `albumes` DISABLE KEYS */;
INSERT INTO `albumes` VALUES (1,'Allies','Keith Wallen','https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c1a27422634231.56315e8f425e2.jpg'),(2,'This World or the next','Keith Wallen','https://keithwallen.com/wp-content/uploads/pp/images/1553293839-IMG_0358%28pp_w1600_h1600%29.JPG'),(3,'Dark Before Dawn','Breaking Benjamin','https://images-na.ssl-images-amazon.com/images/I/A1ZQ4%2Bo1gBL._SL1500_.jpg'),(4,'Aurora','Breaking Benjamin','https://images-na.ssl-images-amazon.com/images/I/713NA-adsHL._SL1200_.jpg');
/*!40000 ALTER TABLE `albumes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `canciones`
--

LOCK TABLES `canciones` WRITE;
/*!40000 ALTER TABLE `canciones` DISABLE KEYS */;
INSERT INTO `canciones` VALUES (1,'Hey Baby','00:03:23.000000','https://www.youtube.com/watch?v=XDbq4rj7TjI&list=OLAK5uy_nBLH62igOk3SqnDV4ZgwjY6rAqzAsAT_c',1),(2,'Face in the light','00:03:23.000000','https://www.youtube.com/watch?v=xGwgtnHzqQA&list=OLAK5uy_nBLH62igOk3SqnDV4ZgwjY6rAqzAsAT_c',1),(3,'Hello houston','00:03:23.000000','https://www.youtube.com/watch?v=Bmi51mJyEn4&list=OLAK5uy_nBLH62igOk3SqnDV4ZgwjY6rAqzAsAT_c',1),(4,'Wicked game','00:04:23.000000','https://www.youtube.com/watch?v=WvFMx6JxDEU&list=OLAK5uy_nBLH62igOk3SqnDV4ZgwjY6rAqzAsAT_c',1),(5,'California Road','00:02:22.000000','https://www.youtube.com/watch?v=61n6t7YxCRE&list=OLAK5uy_nBLH62igOk3SqnDV4ZgwjY6rAqzAsAT_c',1),(6,'Failure','00:03:46.000000','https://www.youtube.com/watch?v=61n6t7YxCRE&list=OLAK5uy_nBLH62igOk3SqnDV4ZgwjY6rAqzAsAT_c',3),(7,'Dance with the devil','00:04:25.000000','https://www.youtube.com/watch?v=61n6t7YxCRE&list=OLAK5uy_nBLH62igOk3SqnDV4ZgwjY6rAqzAsAT_c',4),(8,'Dream Away','00:03:14.000000','https://www.youtube.com/watch?v=ffgATC3-lU8',2),(9,'It´s find us all','00:04:15.000000','https://www.youtube.com/watch?v=ffgATC3-lU8',2),(10,'Warfare','00:02:50.000000','https://www.youtube.com/watch?v=ffgATC3-lU8',2);
/*!40000 ALTER TABLE `canciones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-26 23:49:14
