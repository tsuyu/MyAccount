-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost:3306
-- Generation Time: Jan 08, 2017 at 01:13 AM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `accountingdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `account_ledger`
--

CREATE TABLE IF NOT EXISTS `account_ledger` (
  `al_seq_no` int(11) NOT NULL AUTO_INCREMENT,
  `al_date` date NOT NULL,
  `al_note` varchar(255) DEFAULT NULL,
  `al_trans_type` varchar(255) NOT NULL,
  `al_amount` double(20,2) NOT NULL DEFAULT '0.00',
  `al_remain` double(20,2) NOT NULL DEFAULT '0.00',
  `al_type` varchar(50) NOT NULL,
  `al_account_type` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`al_seq_no`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=58 ;

-- --------------------------------------------------------

--
-- Table structure for table `account_owner_detail`
--

CREATE TABLE IF NOT EXISTS `account_owner_detail` (
  `aod_seq` int(11) NOT NULL AUTO_INCREMENT,
  `aod_username` varchar(250) DEFAULT NULL,
  `aod_password` varchar(250) DEFAULT NULL,
  `aod_name` varchar(250) NOT NULL,
  `aod_address1` varchar(250) NOT NULL,
  `aod_address2` varchar(250) NOT NULL,
  `aod_postcode` varchar(10) NOT NULL,
  `aod_city` varchar(250) NOT NULL,
  `aod_state` varchar(250) NOT NULL,
  `aod_phone` varchar(20) NOT NULL,
  `aod_fax` varchar(20) NOT NULL,
  `aod_staff_name1` varchar(250) NOT NULL,
  `aod_staff_name2` varchar(250) NOT NULL,
  `aod_staff_name3` varchar(250) NOT NULL,
  `aod_staff_name4` varchar(250) DEFAULT NULL,
  `aod_staff_name5` varchar(250) DEFAULT NULL,
  `aod_staff_designation1` varchar(250) NOT NULL,
  `aod_staff_designation2` varchar(250) NOT NULL,
  `aod_staff_designation3` varchar(250) NOT NULL,
  `aod_staff_designation4` varchar(250) DEFAULT NULL,
  `aod_staff_designation5` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`aod_seq`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `account_owner_detail`
--

INSERT INTO `account_owner_detail` (`aod_seq`, `aod_username`, `aod_password`, `aod_name`, `aod_address1`, `aod_address2`, `aod_postcode`, `aod_city`, `aod_state`, `aod_phone`, `aod_fax`, `aod_staff_name1`, `aod_staff_name2`, `aod_staff_name3`, `aod_staff_name4`, `aod_staff_name5`, `aod_staff_designation1`, `aod_staff_designation2`, `aod_staff_designation3`, `aod_staff_designation4`, `aod_staff_designation5`) VALUES
(1, '1', '1', 'Surau Taman Koperasi Cuepacs', 'Taman Koperasi Cuepacs', '', '43200 ', 'Cheras', 'W.P Kuala Lumpur', '0399999999', '0388888888', 'user1', 'user2', 'user3', NULL, NULL, 'pos1', 'pos2', 'pos3', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `asset_main`
--

CREATE TABLE IF NOT EXISTS `asset_main` (
  `am_seq_no` int(11) NOT NULL AUTO_INCREMENT,
  `am_al_seq_no` int(11) DEFAULT NULL,
  `am_name` varchar(50) DEFAULT NULL,
  `am_note` varchar(50) DEFAULT NULL,
  `am_quantity` int(11) NOT NULL DEFAULT '0',
  `am_status` varchar(50) DEFAULT NULL,
  `am_date_purchase` date NOT NULL,
  PRIMARY KEY (`am_seq_no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `asset_main`
--


-- --------------------------------------------------------

--
-- Table structure for table `transaction_type`
--

CREATE TABLE IF NOT EXISTS `transaction_type` (
  `tt_seq_no` int(11) NOT NULL AUTO_INCREMENT,
  `tt_name` varchar(50) DEFAULT NULL,
  `tt_type` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`tt_seq_no`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=28 ;

--
-- Dumping data for table `transaction_type`
--

INSERT INTO `transaction_type` (`tt_seq_no`, `tt_name`, `tt_type`) VALUES
(1, 'Sewaan', 'IN'),
(2, 'Sumbangan Majlis Agama', 'IN'),
(3, 'Kutipan Jumaat (Minggu Pertama)', 'IN'),
(4, 'Kutipan Jumaat (Minggu Kedua)', 'IN'),
(5, 'Kutipan Jumaat (Minggu Ketiga)', 'IN'),
(6, 'Kutipan Jumaat (minggu Keempat)', 'IN'),
(7, 'Sumbangan Individu', 'IN'),
(8, 'Tabung Derma', 'IN'),
(9, 'Tabung Kebajikan', 'IN'),
(10, 'Jualan', 'IN'),
(11, 'Zakat', 'IN'),
(12, 'Baki Permulaan', 'IN'),
(13, 'Bil Elektrik', 'OUT'),
(14, 'Bil Air', 'OUT'),
(15, 'Bil Telefon', 'OUT'),
(16, 'Bil Internet', 'OUT'),
(17, 'Saguhati Penceramah', 'OUT'),
(18, 'Elaun', 'OUT'),
(19, 'Penyelenggaraan', 'OUT'),
(20, 'Cetakan', 'OUT'),
(21, 'Alat Tulis', 'OUT'),
(22, 'Sewa', 'OUT'),
(23, 'Cas Bank', 'OUT'),
(24, 'Jamuan', 'OUT'),
(25, 'Lain-Lain', 'OUT'),
(26, 'Aset', 'IN'),
(27, 'Aset', 'OUT');
