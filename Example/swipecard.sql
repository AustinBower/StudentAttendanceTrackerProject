-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 26, 2016 at 02:03 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: "swipecard"
--

-- --------------------------------------------------------

--
-- Table structure for table "student"
--

CREATE TABLE "student" (
  "StudentID" int NOT NULL,
  "StudentNumber" int NOT NULL,
  "StudentName" char(10) CHARACTER SET utf8 NOT NULL,
  "Attendance" int DEFAULT NULL,
  "Gender" char(10) CHARACTER SET utf8 DEFAULT NULL,
  "Email" char(10) CHARACTER SET utf8 DEFAULT NULL,
  "Phone" char(10) CHARACTER SET utf8 DEFAULT NULL,
  "Address" char(10) CHARACTER SET utf8 DEFAULT NULL,
  "ClassID" char(10) CHARACTER SET utf8 NOT NULL
);

--
-- Dumping data for table "student"
--

SET IDENTITY_INSERT "student" ON ;
INSERT INTO "student" ("StudentID", "StudentNumber", "StudentName", "Attendance", "Gender", "Email", "Phone", "Address", "ClassID") VALUES
(0, 555555555, 'Matt', 0, 'Male', 'rawsonm24', '3049412985', NULL, '');

SET IDENTITY_INSERT "student" OFF;

--
-- Indexes for dumped tables
--

--
-- Indexes for table "student"
--
ALTER TABLE "student"
 ADD PRIMARY KEY ("StudentID");

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
