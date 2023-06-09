-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 29, 2022 at 08:59 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `conferencedb`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `idattendance` int(11) NOT NULL,
  `participantid` varchar(45) NOT NULL,
  `logdatetime` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `event_id` int(30) DEFAULT NULL,
  `timein` varchar(250) NOT NULL,
  `timeout` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`idattendance`, `participantid`, `logdatetime`, `event_id`, `timein`, `timeout`) VALUES
(1, '14', '2022-03-28 21:16:59', 1, '2022-03-28 21:14:19', '2022-03-28 21:16:59'),
(2, '1', '2022-03-28 21:30:01', 1, '2022-03-28 21:19:58', '2022-03-28 21:30:01'),
(3, '1', '2022-03-28 21:32:54', 1, '2022-03-28 21:32:48', '2022-03-28 21:32:54'),
(4, '1', '2022-03-28 21:33:39', 7, '2022-03-28 21:33:37', '2022-03-28 21:33:39'),
(5, '1', '2022-03-28 21:37:32', 7, '2022-03-28 21:33:40', '2022-03-28 21:37:32');

-- --------------------------------------------------------

--
-- Table structure for table `events`
--

CREATE TABLE `events` (
  `id` int(30) NOT NULL,
  `event_datetime_start` datetime NOT NULL,
  `event_datetime_end` datetime NOT NULL,
  `event` varchar(250) NOT NULL,
  `description` text NOT NULL,
  `venue` text NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT 0 COMMENT '0=Open,1=Done',
  `date_created` datetime NOT NULL DEFAULT current_timestamp(),
  `event_for` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `events`
--

INSERT INTO `events` (`id`, `event_datetime_start`, `event_datetime_end`, `event`, `description`, `venue`, `status`, `date_created`, `event_for`) VALUES
(1, '2000-01-01 00:00:00', '3000-12-31 00:00:00', 'General Attendance', 'This Event Handles The Daily Entry And Exit Of Students To School. Please Do Not Change Any Values.', 'School Compound', 0, '2022-03-25 11:24:42', 'BSIT'),
(2, '2022-03-23 08:00:00', '2022-03-23 08:00:00', 'intrams', 'test', 'school', 1, '2022-03-23 08:00:00', ''),
(3, '2022-03-23 08:00:00', '2022-03-25 16:16:00', 'Dota Tournament', 'test1', 'gym', 1, '2022-03-24 19:12:00', 'BSBA'),
(4, '2022-03-23 08:00:00', '2022-03-23 08:00:00', 'ml tour', 'test2', 'playground', 1, '2022-03-23 08:00:00', ''),
(5, '2022-03-23 08:00:00', '2022-03-23 08:00:00', 'lol', 'test3', 'bar', 1, '2022-03-23 08:00:00', ''),
(6, '2022-03-23 08:00:00', '2022-03-23 08:00:00', 'singing contest', 'test4', 'casino', 1, '2022-03-23 08:00:00', ''),
(7, '2022-03-01 08:00:00', '2022-03-31 05:00:00', '1', '3', '2', 0, '2022-03-23 13:46:06', ''),
(8, '2022-03-22 08:00:00', '2022-03-24 15:44:00', 'test event', '1', '1', 1, '2022-03-24 15:43:00', ''),
(9, '2022-03-23 08:00:00', '2022-03-23 08:00:00', 'eating contest', 'dasdfasd', 'canteen', 1, '2022-03-23 08:00:00', ''),
(10, '2022-03-23 05:00:00', '2022-03-23 22:03:00', '151', '00', '08', 1, '2022-03-24 15:21:00', ''),
(11, '2022-03-24 08:00:00', '2022-03-24 16:21:00', 'Asdf', 'fasdfsdf', 'asdf', 1, '2022-03-24 18:57:00', 'BSIT');

-- --------------------------------------------------------

--
-- Table structure for table `participants`
--

CREATE TABLE `participants` (
  `idparticipant` varchar(45) NOT NULL,
  `lastname` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `course` varchar(250) NOT NULL,
  `contactno` varchar(45) NOT NULL,
  `reg_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `participants`
--

INSERT INTO `participants` (`idparticipant`, `lastname`, `firstname`, `middlename`, `course`, `contactno`, `reg_at`) VALUES
('1', 'marc angelo', 'marc angelo', 'Somido', 'BSBA', '0944-547-8484', '2022-03-22 14:45:30'),
('10', 'Adtasdt', 'sdtasdt', 'Atdsatdsatdsatd', 'BSIT', '0938-442-7462', '2022-03-22 14:43:51'),
('11', 'Aaa', 'Bbbb', 'Ccccc', 'BSIT', '0938-442-7462', '2022-03-22 14:41:37'),
('12', 'Asdfasd', 'fasdfasd', 'Fdsafds', 'BSIT', '0948-499-5007', '2022-03-22 14:42:01'),
('13', 'A', 'A', 'A', 'BSIT', '0947-348-1554', '2022-03-22 14:41:08'),
('14', 'Sarmiento', 'Tat', 'Maln', 'BSIT', '0938-442-7462', '2022-03-23 13:30:17'),
('15', '5', '4', '3', 'BSBA', '1111-111-1111', '2022-03-23 13:40:29'),
('2', 'Sarmiento', 'Maxie', 'Nagutom', 'BSBA', '0938-442-7462', '2022-03-22 14:44:29'),
('3', '3', '4', '5', 'BSBA', '2222-222-2222', '2022-03-23 13:40:00'),
('4', 'test1', 'setse', 'saet', 'BSBA', '1111-111-1111', '2022-03-22 14:45:40'),
('5', 'Sarmiento', 'Lealyn', 'Nagutom', 'BSIT', '0948-499-5007', '2022-03-22 14:44:12'),
('6', 'marc', 'marc', 'marc', 'BSBA', '0948-984-9844', '2022-03-22 14:45:21'),
('7', 'Last Name', 'First Name', 'Middle Name', 'BSBA', '0934-848-6384', '2022-03-22 14:45:10'),
('8', 'sar', 'sar', 'sar', 'BSBA', '0938-442-7462', '2022-03-22 14:44:50'),
('9', 'Mar', 'mar', 'Dsafdsafdsafdsafdsafdsafdsafdsaafsssramd', 'BSIT', '0948-499-5007', '2022-03-22 14:44:01');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `FirstName` varchar(250) NOT NULL,
  `LastName` varchar(250) NOT NULL,
  `UserEmail` varchar(250) NOT NULL,
  `UserName` varchar(250) NOT NULL,
  `UserPassword` varchar(250) NOT NULL,
  `UserType` tinyint(1) NOT NULL DEFAULT 2 COMMENT '1=Admin,2=Registrar	',
  `DateAdded` datetime NOT NULL DEFAULT current_timestamp(),
  `DateUpdated` datetime DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`FirstName`, `LastName`, `UserEmail`, `UserName`, `UserPassword`, `UserType`, `DateAdded`, `DateUpdated`) VALUES
('Marc Angelo', 'Sarmiento', 'cramsarmiento@gmail.com', 'admin', 'bGVhbHlu                                                                                            ', 1, '2022-03-21 14:31:41', '2022-03-22 10:11:41');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`idattendance`);

--
-- Indexes for table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `participants`
--
ALTER TABLE `participants`
  ADD PRIMARY KEY (`idparticipant`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserName`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `events`
--
ALTER TABLE `events`
  MODIFY `id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
