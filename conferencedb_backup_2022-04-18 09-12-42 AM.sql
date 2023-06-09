-- MySqlBackup.NET 2.3.6
-- Dump Time: 2022-04-18 09:12:42
-- --------------------------------------
-- Server version 10.4.22-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of attendance
-- 

DROP TABLE IF EXISTS `attendance`;
CREATE TABLE IF NOT EXISTS `attendance` (
  `idattendance` int(11) NOT NULL,
  `participantid` varchar(45) NOT NULL,
  `logdatetime` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `event_id` int(30) DEFAULT NULL,
  `timein` varchar(250) NOT NULL,
  `timeout` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`idattendance`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table attendance
-- 

/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance`(`idattendance`,`participantid`,`logdatetime`,`event_id`,`timein`,`timeout`) VALUES(1,'14','2022-03-28 21:16:59',1,'2022-03-28 21:14:19','2022-03-28 21:16:59'),(2,'1','2022-03-28 21:30:01',1,'2022-03-28 21:19:58','2022-03-28 21:30:01'),(3,'11','2022-04-12 19:52:15',1,'2022-04-12 19:52:15',''),(4,'15','2022-04-02 22:59:48',3,'2022-04-02 22:51:06','2022-04-02 22:59:48'),(5,'15','2022-04-02 23:01:51',3,'2022-04-02 23:00:27','2022-04-02 23:01:51'),(6,'15','2022-04-02 12:25:15',1,'2022-04-02 12:24:54','2022-04-02 12:25:15'),(7,'15','2022-04-02 12:25:29',1,'2022-04-02 12:25:25','2022-04-02 12:25:29'),(8,'15','2022-04-02 12:25:32',1,'2022-04-02 12:25:31','2022-04-02 12:25:32'),(9,'15','2022-04-02 12:28:08',1,'2022-04-02 12:27:59','2022-04-02 12:28:08'),(10,'15','2022-04-02 13:02:50',1,'2022-04-02 13:02:28','2022-04-02 13:02:50'),(11,'15','2022-04-02 18:45:25',1,'2022-04-02 13:02:58','2022-04-02 18:45:25'),(12,'15','2022-04-02 19:04:08',1,'2022-04-02 19:01:40','2022-04-02 19:04:08'),(13,'15','2022-04-02 19:08:24',1,'2022-04-02 19:04:56','2022-04-02 19:08:24'),(14,'15','2022-04-02 19:09:45',1,'2022-04-02 19:08:50','2022-04-02 19:09:45'),(15,'15','2022-04-02 19:12:22',1,'2022-04-02 19:10:01','2022-04-02 19:12:22'),(16,'15','2022-04-02 19:14:34',1,'2022-04-02 19:12:33','2022-04-02 19:14:34'),(17,'15','2022-04-02 19:24:30',1,'2022-04-02 19:14:41','2022-04-02 19:24:30'),(18,'15','2022-04-02 21:36:27',1,'2022-04-02 19:26:55','2022-04-02 21:36:27'),(19,'15','2022-04-02 21:42:03',1,'2022-04-02 21:40:48','2022-04-02 21:42:03'),(20,'15','2022-04-02 21:46:52',1,'2022-04-02 21:44:35','2022-04-02 21:46:52'),(21,'15','2022-04-02 21:52:25',1,'2022-04-02 21:49:41','2022-04-02 21:52:25'),(22,'15','2022-04-02 21:55:11',1,'2022-04-02 21:53:54','2022-04-02 21:55:11'),(23,'15','2022-04-02 22:04:02',1,'2022-04-02 21:56:55','2022-04-02 22:04:02'),(24,'15','2022-04-02 22:06:29',1,'2022-04-02 22:04:56','2022-04-02 22:06:29'),(25,'15','2022-04-02 22:13:38',1,'2022-04-02 22:11:18','2022-04-02 22:13:38'),(26,'15','2022-04-02 22:26:16',1,'2022-04-02 22:26:02','2022-04-02 22:26:16'),(27,'15','2022-04-02 22:32:09',1,'2022-04-02 22:26:25','2022-04-02 22:32:09'),(28,'15','2022-04-02 22:37:49',1,'2022-04-02 22:32:19','2022-04-02 22:37:49'),(29,'15','2022-04-02 23:09:08',3,'2022-04-02 23:08:40','2022-04-02 23:09:08'),(30,'15','2022-04-02 23:11:16',3,'2022-04-02 23:11:16',''),(31,'7','2022-04-02 23:16:56',3,'2022-04-02 23:14:22','2022-04-02 23:16:56'),(32,'7','2022-04-03 00:27:05',3,'2022-04-03 00:27:05',''),(33,'14','2022-04-03 00:37:30',3,'2022-04-03 00:28:54','2022-04-03 00:37:30'),(34,'14','2022-04-03 01:18:03',1,'2022-04-03 01:17:50','2022-04-03 01:18:03'),(35,'13','2022-04-09 17:44:42',1,'2022-04-09 17:44:33','2022-04-09 17:44:42'),(36,'13','2022-04-09 17:59:40',1,'2022-04-09 17:59:32','2022-04-09 17:59:40'),(37,'1','2022-04-09 18:46:12',1,'2022-04-09 18:46:05','2022-04-09 18:46:12'),(38,'1','2022-04-09 19:12:36',6,'2022-04-09 19:12:28','2022-04-09 19:12:36'),(39,'1','2022-04-09 19:18:07',6,'2022-04-09 19:17:58','2022-04-09 19:18:07'),(40,'1','2022-04-09 19:18:24',6,'2022-04-09 19:18:15','2022-04-09 19:18:24'),(41,'1','2022-04-09 19:19:09',1,'2022-04-09 19:19:01','2022-04-09 19:19:09'),(42,'11','2022-04-09 19:54:54',1,'2022-04-09 19:54:46','2022-04-09 19:54:54'),(43,'1','2022-04-12 20:45:10',1,'2022-04-12 19:54:41','2022-04-12 20:45:10'),(44,'4','2022-04-12 20:03:06',1,'2022-04-12 20:03:06',''),(45,'12','2022-04-12 20:14:38',1,'2022-04-12 20:12:15','2022-04-12 20:14:38'),(46,'12','2022-04-12 20:19:21',1,'2022-04-12 20:14:56','2022-04-12 20:19:21'),(47,'12','2022-04-12 20:25:02',1,'2022-04-12 20:19:25','2022-04-12 20:25:02'),(48,'12','2022-04-12 20:38:56',1,'2022-04-12 20:25:06','2022-04-12 20:38:56'),(49,'13','2022-04-12 20:32:17',1,'2022-04-12 20:29:53','2022-04-12 20:32:17'),(50,'13','2022-04-12 20:32:24',1,'2022-04-12 20:32:24',''),(51,'2','2022-04-12 20:43:40',1,'2022-04-12 20:35:53','2022-04-12 20:43:40'),(52,'12','2022-04-12 20:42:41',1,'2022-04-12 20:39:03','2022-04-12 20:42:41'),(53,'12','2022-04-12 20:43:15',1,'2022-04-12 20:43:04','2022-04-12 20:43:15'),(54,'12','2022-04-12 20:43:24',1,'2022-04-12 20:43:24',''),(55,'2','2022-04-12 21:04:16',1,'2022-04-12 20:49:42','2022-04-12 21:04:16'),(56,'2','2022-04-12 21:07:55',1,'2022-04-12 21:04:29','2022-04-12 21:07:55'),(57,'2','2022-04-12 21:12:34',1,'2022-04-12 21:11:14','2022-04-12 21:12:34'),(58,'2','2022-04-12 21:14:21',1,'2022-04-12 21:13:37','2022-04-12 21:14:21'),(59,'2','2022-04-12 21:15:31',1,'2022-04-12 21:14:26','2022-04-12 21:15:31'),(60,'2','2022-04-12 21:18:02',1,'2022-04-12 21:15:34','2022-04-12 21:18:02'),(61,'2','2022-04-12 21:19:29',1,'2022-04-12 21:18:22','2022-04-12 21:19:29'),(62,'2','2022-04-12 21:20:21',1,'2022-04-12 21:19:34','2022-04-12 21:20:21'),(63,'2','2022-04-12 21:30:23',1,'2022-04-12 21:20:26','2022-04-12 21:30:23'),(64,'2','2022-04-12 21:37:57',1,'2022-04-12 21:37:14','2022-04-12 21:37:57'),(65,'2','2022-04-12 21:40:40',1,'2022-04-12 21:39:25','2022-04-12 21:40:40'),(66,'2','2022-04-12 21:46:23',1,'2022-04-12 21:41:13','2022-04-12 21:46:23'),(67,'2','2022-04-12 21:50:33',1,'2022-04-12 21:47:52','2022-04-12 21:50:33'),(68,'2','2022-04-12 22:03:20',1,'2022-04-12 22:02:06','2022-04-12 22:03:20'),(69,'2','2022-04-12 22:18:05',1,'2022-04-12 22:05:29','2022-04-12 22:18:05');
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;

-- 
-- Definition of events
-- 

DROP TABLE IF EXISTS `events`;
CREATE TABLE IF NOT EXISTS `events` (
  `id` int(30) NOT NULL AUTO_INCREMENT,
  `event_datetime_start` datetime NOT NULL,
  `event_datetime_end` datetime NOT NULL,
  `event` varchar(250) NOT NULL,
  `description` text NOT NULL,
  `venue` text NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT 0 COMMENT '0=Open,1=Done',
  `date_created` datetime NOT NULL DEFAULT current_timestamp(),
  `event_for` varchar(250) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table events
-- 

/*!40000 ALTER TABLE `events` DISABLE KEYS */;
INSERT INTO `events`(`id`,`event_datetime_start`,`event_datetime_end`,`event`,`description`,`venue`,`status`,`date_created`,`event_for`) VALUES(1,'2000-01-01 00:00:00','3000-12-31 00:00:00','General Attendance','This Event Handles The Daily Entry And Exit Of Students To School.','School Compound',0,'2022-04-02 10:33:31','ALL'),(2,'2022-03-23 08:00:00','2022-03-23 08:00:00','intrams','test','school',1,'2022-03-23 08:00:00','ALL'),(3,'2022-03-23 08:00:00','2022-04-14 18:43:00','Dota Tournament','test1','gym',1,'2022-04-14 18:42:00','BSBA'),(4,'2022-03-23 08:00:00','2022-03-23 08:00:00','ml tour','test2','playground',1,'2022-03-23 08:00:00','ALL'),(5,'2022-03-23 08:00:00','2022-03-23 08:00:00','lol','test3','bar',1,'2022-03-23 08:00:00','ALL'),(6,'2022-03-23 08:00:00','2022-04-09 23:00:00','Singing Contest','test4','casino',1,'2022-04-09 20:02:00','BSBA'),(7,'2022-03-01 08:00:00','2022-03-31 05:00:00','1','3','2',1,'2022-03-23 13:46:00','ALL'),(8,'2022-03-22 08:00:00','2022-03-24 15:44:00','test event','1','1',1,'2022-03-24 15:43:00','ALL'),(9,'2022-03-23 08:00:00','2022-03-23 08:00:00','eating contest','dasdfasd','canteen',1,'2022-03-23 08:00:00','ALL'),(10,'2022-03-23 05:00:00','2022-03-23 22:03:00','151','00','08',1,'2022-03-24 15:21:00','ALL'),(11,'2022-03-24 08:00:00','2022-03-24 16:21:00','Asdf','fasdfsdf','asdf',1,'2022-03-24 18:57:00','BSIT'),(12,'2022-04-11 08:00:00','2022-04-15 19:00:00','Intramurals','Celebrates The 20Th School Intrams','Punzalan Gym',1,'2022-04-14 19:49:00','BSIT');
/*!40000 ALTER TABLE `events` ENABLE KEYS */;

-- 
-- Definition of participants
-- 

DROP TABLE IF EXISTS `participants`;
CREATE TABLE IF NOT EXISTS `participants` (
  `idparticipant` varchar(45) NOT NULL,
  `lastname` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `course` varchar(250) NOT NULL,
  `contactno` varchar(45) NOT NULL,
  `reg_at` datetime NOT NULL,
  PRIMARY KEY (`idparticipant`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table participants
-- 

/*!40000 ALTER TABLE `participants` DISABLE KEYS */;
INSERT INTO `participants`(`idparticipant`,`lastname`,`firstname`,`middlename`,`course`,`contactno`,`reg_at`) VALUES('1','marc angelo','marc angelo','Somido','BSBA','0944-547-8484','2022-03-22 14:45:30'),('10','Adtasdt','sdtasdt','Atdsatdsatdsatd','BSIT','0938-442-7462','2022-03-22 14:43:51'),('11','Aaa','Bbbb','Ccccc','BSIT','0938-442-7462','2022-03-22 14:41:37'),('12','Asdfasd','fasdfasd','Fdsafds','BSIT','0948-499-5007','2022-03-22 14:42:01'),('13','A','A','A','BSIT','0947-348-1554','2022-03-22 14:41:08'),('15','5','4','3','BSBA','0912-166-4719','2022-04-02 21:36:02'),('2','Sarmiento','Maxie','Nagutom','BSBA','222','2022-03-22 14:44:29'),('4','test1','setse','saet','BSBA','1111-111-1111','2022-03-22 14:45:40'),('5','Sarmiento','Lealyn','Nagutom','BSIT','0948-499-5007','2022-03-22 14:44:12'),('6','marc','marc','marc','BSBA','0948-984-9844','2022-03-22 14:45:21'),('7','Last Name','First Name','Middle Name','BSBA','0977-612-4006','2022-04-12 18:45:44'),('8','sar','sar','sar','BSBA','0938-442-7462','2022-03-22 14:44:50'),('9','Mar','mar','Dsafdsafdsafdsafdsafdsafdsafdsaafsssramd','BSIT','0948-499-5007','2022-03-22 14:44:01');
/*!40000 ALTER TABLE `participants` ENABLE KEYS */;

-- 
-- Definition of smslog
-- 

DROP TABLE IF EXISTS `smslog`;
CREATE TABLE IF NOT EXISTS `smslog` (
  `smsID` int(11) NOT NULL AUTO_INCREMENT,
  `sender` varchar(250) NOT NULL,
  `receiver` varchar(250) NOT NULL,
  `message` varchar(250) NOT NULL,
  `status` varchar(50) NOT NULL,
  `datesent` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`smsID`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table smslog
-- 

/*!40000 ALTER TABLE `smslog` DISABLE KEYS */;
INSERT INTO `smslog`(`smsID`,`sender`,`receiver`,`message`,`status`,`datesent`) VALUES(1,'Attendance Management System','222','Sarmiento, Maxie Nagutom  entered the campus On 4/12/2022 9:41:13 PM','Sent','2022-04-12 21:41:18'),(2,'Attendance Management System','222','Sarmiento, Maxie Nagutom  Exit the campus On 4/12/2022 9:46:23 PM','Sent','2022-04-12 21:46:26'),(3,'Attendance Management System','222','Sarmiento, Maxie Nagutom  entered the campus On 4/12/2022 9:47:52 PM','Sent','2022-04-12 21:47:52'),(4,'Attendance Management System','222','Sarmiento, Maxie Nagutom  Exit the campus On 4/12/2022 10:03:20 PM','Sent','2022-04-12 22:03:26'),(5,'Attendance Management System','222','Sarmiento, Maxie Nagutom  entered the campus On 4/12/2022 10:05:29 PM','Sent','2022-04-12 22:05:37'),(6,'Attendance Management System','222','Sarmiento, Maxie Nagutom  Exit the campus On 4/12/2022 10:18:05 PM','Sent','2022-04-12 22:18:10'),(22,'Attendance Management System','09776124006','Last Name, First Name Middle Name  entered the campus On 4/14/2022 8:08:32 PM','Sent','2022-04-14 20:08:35');
/*!40000 ALTER TABLE `smslog` ENABLE KEYS */;

-- 
-- Definition of users
-- 

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `FirstName` varchar(250) NOT NULL,
  `LastName` varchar(250) NOT NULL,
  `UserEmail` varchar(250) NOT NULL,
  `UserName` varchar(250) NOT NULL,
  `UserPassword` varchar(250) NOT NULL,
  `UserType` tinyint(1) NOT NULL DEFAULT 2 COMMENT '1=Admin,2=Registrar	',
  `DateAdded` datetime NOT NULL DEFAULT current_timestamp(),
  `DateUpdated` datetime DEFAULT NULL ON UPDATE current_timestamp(),
  PRIMARY KEY (`UserName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table users
-- 

/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users`(`FirstName`,`LastName`,`UserEmail`,`UserName`,`UserPassword`,`UserType`,`DateAdded`,`DateUpdated`) VALUES('Marc Angelo','Sarmiento','cramsarmiento@gmail.com','admin','YWRtaW4=',1,'2022-03-21 14:31:41','2022-04-14 20:24:55');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2022-04-18 09:12:42
-- Total time: 0:0:0:0:181 (d:h:m:s:ms)
