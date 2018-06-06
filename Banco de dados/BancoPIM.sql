CREATE DATABASE  IF NOT EXISTS `pim1` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `pim1`;
-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: pim1
-- ------------------------------------------------------
-- Server version	8.0.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ge_categoria`
--

DROP TABLE IF EXISTS `ge_categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ge_categoria` (
  `SEQ` int(8) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SEQ`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ge_categoria`
--

LOCK TABLES `ge_categoria` WRITE;
/*!40000 ALTER TABLE `ge_categoria` DISABLE KEYS */;
INSERT INTO `ge_categoria` VALUES (15,'CALCADOS'),(16,'ARTIGOS ESPORTIVOS'),(17,'ROUPAS'),(19,'UNIFORMES ESPORTIVOS'),(20,'ROUPAS N');
/*!40000 ALTER TABLE `ge_categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ge_cliente`
--

DROP TABLE IF EXISTS `ge_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ge_cliente` (
  `seq` int(11) NOT NULL AUTO_INCREMENT,
  `nomerazao` varchar(250) DEFAULT NULL,
  `cpf` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `tipopessoa` varchar(50) DEFAULT NULL,
  `id` varchar(45) DEFAULT NULL,
  `senha` varchar(45) DEFAULT NULL,
  `rg` varchar(20) DEFAULT NULL,
  `telCelular` varchar(45) DEFAULT NULL,
  `telFixo` varchar(45) DEFAULT NULL,
  `telRecado` varchar(45) DEFAULT NULL,
  `dtaNasc` varchar(45) DEFAULT NULL,
  `sexo` varchar(45) DEFAULT NULL,
  `estadoCivil` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `cep` varchar(45) DEFAULT NULL,
  `logradouro` varchar(45) DEFAULT NULL,
  `nro` int(11) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `complemento` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `uf` varchar(45) DEFAULT NULL,
  `pais` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`seq`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ge_cliente`
--

LOCK TABLES `ge_cliente` WRITE;
/*!40000 ALTER TABLE `ge_cliente` DISABLE KEYS */;
INSERT INTO `ge_cliente` VALUES (1,'VINICIUS RIBEIRO','39441540889','Funcionário','admin','admin','547895146SP','16  99309847','16  39653017','        ','31/08/1995','Masculino','Solteiro','alvisvini@gmail.com','14094-014','Rua Rodolfo César Padilha Leite',81,'Conjunto Habitacional Jardim das Palmeiras','','Ribeirão Preto','SP',''),(22,'DIEGO SCIOTTI','35373009806','Cliente','diego','123','','16 993244642','        ','        ','  /  /','Masculino','Solteiro','','14020-300','Rua Cavalheiro Torquato Rizzi',1189,'Jardim São Luiz','Apto 23','Ribeirão Preto','SP','Brasil');
/*!40000 ALTER TABLE `ge_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ge_produto`
--

DROP TABLE IF EXISTS `ge_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ge_produto` (
  `seq` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `marca` varchar(250) DEFAULT NULL,
  `obs` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `seqcategoria` int(8) DEFAULT NULL,
  `preco` decimal(16,0) DEFAULT '0',
  `imagem` varchar(1000) DEFAULT NULL,
  `tamanho` int(9) DEFAULT NULL,
  `quantidade` int(11) DEFAULT '0',
  `cod` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`seq`),
  KEY `fk_PROD_ATEG` (`seqcategoria`),
  CONSTRAINT `fk_PROD_ATEG` FOREIGN KEY (`seqcategoria`) REFERENCES `ge_categoria` (`seq`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ge_produto`
--

LOCK TABLES `ge_produto` WRITE;
/*!40000 ALTER TABLE `ge_produto` DISABLE KEYS */;
INSERT INTO `ge_produto` VALUES (39,'TENIS RUNNING','NIKE','SHOCKS',15,399,'C:\\Users\\Vinicius\\Desktop\\PIM12018\\teste\\bin\\Debug\\unavailable.png',40,10,'123'),(40,'OCULOS DE NATCAO','CHILLI BEANS','',16,150,'C:\\Users\\Vinicius\\Desktop\\PIM12018\\teste\\bin\\Debug\\unavailable.png',17,1,'321'),(41,'SUPLEMENTO BCAA 20MG','NTEGRAL MEDICA','',16,70,'C:\\Users\\Vinicius\\Desktop\\th124CFVMH.jpg',0,10,'7630039685393'),(42,'TENIS ADIDAS','ADIDAS','PROMO',15,120,'C:\\Users\\Vinicius\\Desktop\\PIM12018\\teste\\bin\\Debug\\unavailable.png',40,3,'23453672778877');
/*!40000 ALTER TABLE `ge_produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venda`
--

DROP TABLE IF EXISTS `venda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `venda` (
  `seqvenda` int(11) NOT NULL AUTO_INCREMENT,
  `seqcliente` int(11) DEFAULT NULL,
  `dtavenda` datetime DEFAULT NULL,
  `qtdeitens` decimal(18,2) DEFAULT '0.00',
  `vlrtotal` decimal(18,2) DEFAULT '0.00',
  PRIMARY KEY (`seqvenda`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venda`
--

LOCK TABLES `venda` WRITE;
/*!40000 ALTER TABLE `venda` DISABLE KEYS */;
INSERT INTO `venda` VALUES (10,1,'2018-05-21 16:37:54',2.00,798.00),(11,22,'2018-05-21 17:06:31',4.00,1596.00),(12,1,'2018-05-21 19:50:09',3.00,479.00),(13,1,'2018-05-21 19:56:41',2.00,160.00),(14,1,'2018-05-21 20:12:33',1.00,70.00),(15,1,'2018-05-21 20:11:05',2.00,142.00),(16,1,'2018-05-21 20:19:26',3.00,213.00),(17,1,'2018-05-21 20:33:53',5.00,292.00),(18,1,'2018-05-21 20:40:02',5.00,541.00),(19,1,'2018-05-21 20:45:07',9.00,434.00),(20,1,'2018-05-21 20:50:41',9.00,683.00),(21,1,'2018-05-21 21:01:07',5.00,290.00),(22,1,'2018-05-21 21:11:23',7.00,609.00),(23,1,'2018-05-21 21:16:47',2.00,140.00),(24,1,'2018-05-21 21:36:01',1.00,70.00),(25,1,'2018-05-29 21:18:56',1.00,399.00);
/*!40000 ALTER TABLE `venda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendaitem`
--

DROP TABLE IF EXISTS `vendaitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `vendaitem` (
  `seqvendaitem` int(11) NOT NULL AUTO_INCREMENT,
  `seqproduto` int(11) DEFAULT NULL,
  `qtde` decimal(18,2) DEFAULT '0.00',
  `vlrproduto` decimal(18,2) DEFAULT '0.00',
  `vlrsubtotal` decimal(18,2) DEFAULT '0.00',
  `seqvenda` int(11) DEFAULT NULL,
  PRIMARY KEY (`seqvendaitem`),
  KEY `fk_seqvenda_idx` (`seqvenda`),
  CONSTRAINT `fk_seqvenda` FOREIGN KEY (`seqvenda`) REFERENCES `venda` (`seqvenda`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendaitem`
--

LOCK TABLES `vendaitem` WRITE;
/*!40000 ALTER TABLE `vendaitem` DISABLE KEYS */;
INSERT INTO `vendaitem` VALUES (24,39,2.00,399.00,798.00,10),(25,39,4.00,399.00,1596.00,11),(26,41,1.00,80.00,80.00,12),(27,39,1.00,399.00,399.00,12),(28,41,2.00,80.00,160.00,13),(29,41,1.00,70.00,70.00,14),(30,41,2.00,71.00,142.00,15),(31,41,3.00,71.00,213.00,16),(32,41,2.00,71.00,142.00,17),(33,40,1.00,150.00,150.00,17),(34,41,2.00,71.00,142.00,18),(35,39,1.00,399.00,399.00,18),(36,41,4.00,71.00,284.00,19),(37,40,1.00,150.00,150.00,19),(38,41,4.00,71.00,284.00,20),(39,39,1.00,399.00,399.00,20),(40,41,2.00,70.00,140.00,21),(41,40,1.00,150.00,150.00,21),(42,41,3.00,70.00,210.00,22),(43,39,1.00,399.00,399.00,22),(44,41,2.00,70.00,140.00,23),(45,41,1.00,70.00,70.00,24),(46,39,1.00,399.00,399.00,25);
/*!40000 ALTER TABLE `vendaitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'pim1'
--

--
-- Dumping routines for database 'pim1'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-06 10:50:43
