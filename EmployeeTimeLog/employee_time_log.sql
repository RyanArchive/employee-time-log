-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 22, 2022 at 12:07 PM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `employee_time_log`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `emp_id` varchar(8) NOT NULL,
  `first_name` varchar(30) NOT NULL,
  `middle_name` varchar(30) NOT NULL,
  `last_name` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `type` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `emp_id`, `first_name`, `middle_name`, `last_name`, `password`, `type`) VALUES
(1, 'ADM10001', 'Ryan', 'Balinuyos', 'Aristosa', 'Habac3rXgR', 'Manager'),
(2, 'EMP20001', 'James', '', 'Chua', 't65oFasbi9', 'Employee'),
(3, 'EMP20002', 'Dusting', 'Mala', 'Capulong', 'rAtcNa263N', 'Employee'),
(4, 'EMP20003', 'Romano Sammy', 'Leng', 'Cabrales', 'H6Tw0K3sWL', 'Employee'),
(5, 'EMP20004', 'Johan', 'Yambao', 'Micolob', 'RCCWpaPT36', 'Employee'),
(6, 'EMP20005', 'Enrique Ramil', '', 'Dimalanta', 'pdTLb0U26K', 'Employee'),
(7, 'EMP20006', 'Neal Jaoquin', 'Quinco', 'Evangelista', 'RVn4E5rM6n', 'Employee'),
(8, 'EMP20007', 'Darrel', 'Gabuyo', 'Bautista', 'efg7ctPaYQ', 'Employee'),
(9, 'EMP20008', 'Fernando', '', 'Magno', 't6WywM8eLC', 'Employee'),
(10, 'EMP20009', 'Dwayne Joshua', '', 'Mamaril', 'V2hhphhiVn', 'Employee'),
(11, 'EMP20010', 'Antony', 'Magday', 'Dayag', 'qhF2bzjL1d', 'Employee'),
(12, 'EMP20011', 'Cesar Dale', 'Cayco', 'Villamar', 'oN9bHLF6fL', 'Employee');

-- --------------------------------------------------------

--
-- Table structure for table `time_log`
--

CREATE TABLE `time_log` (
  `id` int(11) NOT NULL,
  `emp_id` varchar(8) NOT NULL,
  `date` varchar(30) NOT NULL,
  `in_out` varchar(30) NOT NULL,
  `time` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `time_log`
--

INSERT INTO `time_log` (`id`, `emp_id`, `date`, `in_out`, `time`) VALUES
(1, 'ADM10001', '08/21/2022', 'Time In', '08:44:46 am'),
(2, 'EMP20001', '08/21/2022', 'Time In', '08:51:25 am'),
(3, 'EMP20004', '08/21/2022', 'Time In', '08:53:27 am'),
(4, 'EMP20002', '08/21/2022', 'Time In', '08:54:01 am'),
(5, 'EMP20005', '08/21/2022', 'Time In', '08:58:41 am'),
(6, 'EMP20003', '08/21/2022', 'Time In', '09:12:12 am'),
(7, 'EMP20002', '08/21/2022', 'Time Out', '06:03:45 pm'),
(8, 'EMP20001', '08/21/2022', 'Time Out', '06:13:21 pm'),
(9, 'EMP20005', '08/21/2022', 'Time Out', '06:45:11 pm'),
(10, 'EMP20004', '08/21/2022', 'Time Out', '06:46:15 pm'),
(11, 'EMP20003', '08/21/2022', 'Time Out', '06:51:16 pm'),
(12, 'ADM10001', '08/21/2022', 'Time Out', '06:55:03 pm'),
(13, 'EMP20002', '08/22/2022', 'Time In', '08:34:21 am'),
(14, 'EMP20010', '08/22/2022', 'Time In', '08:42:22 am'),
(15, 'EMP20011', '08/22/2022', 'Time In', '08:44:09 am'),
(16, 'EMP20006', '08/22/2022', 'Time In', '08:45:19 am'),
(17, 'EMP20007', '08/22/2022', 'Time In', '08:48:49 am'),
(18, 'ADM10001', '08/22/2022', 'Time In', '08:49:51 am'),
(19, 'EMP20003', '08/22/2022', 'Time In', '08:51:31 am'),
(20, 'EMP20009', '08/22/2022', 'Time In', '08:56:12 am'),
(21, 'EMP20008', '08/22/2022', 'Time In', '09:01:07 am'),
(22, 'EMP20007', '08/22/2022', 'Time Out', '06:05:57 pm'),
(23, 'EMP20008', '08/22/2022', 'Time Out', '06:06:14 pm'),
(24, 'EMP20006', '08/22/2022', 'Time Out', '06:07:03 pm'),
(25, 'EMP20002', '08/22/2022', 'Time Out', '06:07:48 pm'),
(26, 'EMP20010', '08/22/2022', 'Time Out', '06:08:50 pm'),
(27, 'EMP20003', '08/22/2022', 'Time Out', '06:21:18 pm'),
(28, 'EMP20011', '08/22/2022', 'Time Out', '06:26:58 pm'),
(29, 'ADM10001', '08/22/2022', 'Time Out', '06:46:58 pm'),
(30, 'EMP20009', '08/22/2022', 'Time Out', '06:47:23 pm');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `emp_id` (`emp_id`);

--
-- Indexes for table `time_log`
--
ALTER TABLE `time_log`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `time_log`
--
ALTER TABLE `time_log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
