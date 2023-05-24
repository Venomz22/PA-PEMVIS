-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2023 at 05:23 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pa_pemvis`
--

-- --------------------------------------------------------

--
-- Table structure for table `nota`
--

CREATE TABLE `nota` (
  `id` int(11) NOT NULL,
  `judul` text NOT NULL,
  `jumlah` int(10) NOT NULL,
  `harga` int(10) NOT NULL,
  `iduser` text NOT NULL,
  `payment` text NOT NULL,
  `kode` text NOT NULL,
  `tgl` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nota`
--

INSERT INTO `nota` (`id`, `judul`, `jumlah`, `harga`, `iduser`, `payment`, `kode`, `tgl`) VALUES
(78, 'naruto, conan', 2, 50000, '9', 'COD', '9N- FWR', '2023-05-23'),
(79, 'conan', 1, 25000, '9', 'E-Wallet', '9N- PS9', '2023-05-23'),
(80, 'jujutsu no kaisen, naruto', 5, 140000, '9', 'COD', '9N- Q5R', '2023-05-23'),
(81, 'angkasa', 2, 40000, '9', 'COD', '9N- DLF', '2023-05-23'),
(82, 'jujutsu no kaisen, shigatsu', 5, 150000, '9', 'E-Wallet', '9N- FFI', '2023-05-23'),
(83, 'conan, Shigatsu, kimi no nawa', 8, 215000, '9', 'COD', '9N- 855', '2023-05-23'),
(84, 'naruto', 3, 75000, '9', 'E-Wallet', '9N- 631', '2023-05-23'),
(85, 'Conan, naruto', 7, 175000, '13', 'E-Wallet', '13N- FM6', '2023-05-23');

-- --------------------------------------------------------

--
-- Table structure for table `tbbuku`
--

CREATE TABLE `tbbuku` (
  `idbuku` int(11) NOT NULL,
  `judul_buku` text NOT NULL,
  `tahun_terbit` int(11) NOT NULL,
  `pengarang` text NOT NULL,
  `penerbit` text NOT NULL,
  `jenis_buku` text NOT NULL,
  `jumlah` int(11) NOT NULL,
  `harga_buku` int(11) NOT NULL,
  `jumlah_terjual` int(11) NOT NULL,
  `gambar` text NOT NULL,
  `kode` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbbuku`
--

INSERT INTO `tbbuku` (`idbuku`, `judul_buku`, `tahun_terbit`, `pengarang`, `penerbit`, `jenis_buku`, `jumlah`, `harga_buku`, `jumlah_terjual`, `gambar`, `kode`) VALUES
(8, 'naruto', 1996, 'masashi', 'shonen', 'Petualangan', 16, 25000, 10, 'naruto.jpg', 'BK- X06'),
(9, 'Conan', 1980, 'sikama', 'shonen', 'Misteri', 41, 25000, 9, 'conan.jpg', 'BK- E6F'),
(10, 'Shigatsu', 2015, 'abdul', 'noviarji', 'Musik', 20, 30000, 5, 'shigatsu.jpg', 'BK- GJT'),
(11, 'si kancil', 2012, 'obama noivarji', 'tukul production', 'Fiksi', 20, 29000, 0, 'sikancil.jpg', 'BK- QH8'),
(12, 'kimi no nawa', 2019, 'dimas arya sulaiman', 'subur production', 'Drama', 11, 25000, 1, 'kiminonawa.jpg', 'BK- C78'),
(13, 'dr stone', 2015, 'honda suzuki', 'ui production', 'Fiksi Ilmiah', 30, 15000, 0, 'drstone.jpg', 'BK- 7RB'),
(14, 'jujutsu no kaisen', 2012, 'gege akutami', 'shonen', 'Horor', 19, 30000, 6, 'jujutsu.jpg', 'BK- DRH'),
(15, 'g30s PKI', 2015, 'didi', 'kompas production', 'Sejarah', 20, 24000, 0, 'g30spki.jpg', 'BK- 6WC'),
(16, 'my pankreas', 2012, 'oda tatsumaki', 'shonen', 'Romansa', 25, 25000, 0, 'mypankreas.jpg', 'BK- 2CE'),
(17, 'Angkasa', 2020, 'Memet suhardi', 'Kompas production', 'Ensiklopedia', 21, 20000, 2, 'angkasa.jpg', 'BK- MQK');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(255) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `nohp` varchar(255) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `kelamin` varchar(255) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `role` varchar(255) NOT NULL,
  `id` int(11) NOT NULL,
  `kode` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `nama`, `nohp`, `alamat`, `password`, `kelamin`, `tanggal_lahir`, `role`, `id`, `kode`) VALUES
('admin', 'rahman', '082346818942', 'suwandi', '123', 'laki laki', '2003-05-02', 'Admin', 6, 'rhmn'),
('user', 'herni', '082255044825', 'asmaba', '123', 'perempuan', '2023-05-10', 'Admin', 7, 'admin'),
('dimas', 'dimas arya', '08223183949', 'loa kulu ', '123', 'Laki-laki', '2002-06-17', 'User', 9, 'U- XOD'),
('herni', 'herni', '09329', 'asmaba', '123', 'Perempuan', '2023-05-23', 'User', 12, 'U- PCZ'),
('hernii', 'Herni Suhartati', '0823521231', 'Jalan Mulawarman', '123', 'Perempuan', '2002-01-11', 'User', 13, 'U- Y2K');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `nota`
--
ALTER TABLE `nota`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbbuku`
--
ALTER TABLE `tbbuku`
  ADD PRIMARY KEY (`idbuku`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `nota`
--
ALTER TABLE `nota`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=86;

--
-- AUTO_INCREMENT for table `tbbuku`
--
ALTER TABLE `tbbuku`
  MODIFY `idbuku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
