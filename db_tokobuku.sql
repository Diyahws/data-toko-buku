-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 14 Jun 2022 pada 06.54
-- Versi server: 10.4.19-MariaDB
-- Versi PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_tokobuku`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `kodeAdmin` varchar(15) NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`kodeAdmin`, `username`, `password`) VALUES
('admin1', 'diahws', '123123'),
('admin2', 'dws', '112233');

-- --------------------------------------------------------

--
-- Struktur dari tabel `databuku`
--

CREATE TABLE `databuku` (
  `kodeBuku` varchar(15) NOT NULL,
  `judulBuku` varchar(50) NOT NULL,
  `penulis` varchar(50) NOT NULL,
  `penerbit` varchar(50) NOT NULL,
  `stok` int(4) NOT NULL,
  `harga` float NOT NULL,
  `adminKode` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `databuku`
--

INSERT INTO `databuku` (`kodeBuku`, `judulBuku`, `penulis`, `penerbit`, `stok`, `harga`, `adminKode`) VALUES
('BK001', 'Harry Potter', 'J.K.Rowling', 'Gramedia', 4, 168900, 'admin1'),
('BK002', 'Bumi Manusia', 'Pramoedya Ananta Toer', 'Hasta Mitra', 8, 147000, 'admin2'),
('BK003', 'The Hunger Games', 'Suzanne Collins', 'Gramedia', 5, 254000, 'admin1'),
('BK004', 'Pulang', 'Tere Liye', 'Republika', 7, 67900, 'admin1'),
('BK005', 'Atomic Habit', 'James Clear', 'Gramedia', 9, 264000, 'admin1');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`kodeAdmin`);

--
-- Indeks untuk tabel `databuku`
--
ALTER TABLE `databuku`
  ADD PRIMARY KEY (`kodeBuku`),
  ADD KEY `adminKode` (`adminKode`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `databuku`
--
ALTER TABLE `databuku`
  ADD CONSTRAINT `databuku_ibfk_1` FOREIGN KEY (`adminKode`) REFERENCES `admin` (`kodeAdmin`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
