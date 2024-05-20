-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Час створення: Трв 20 2024 р., 10:53
-- Версія сервера: 8.2.0
-- Версія PHP: 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База даних: `inventory_db`
--

-- --------------------------------------------------------

--
-- Структура таблиці `postachalnik`
--

DROP TABLE IF EXISTS `postachalnik`;
CREATE TABLE IF NOT EXISTS `postachalnik` (
  `id_postach` int NOT NULL AUTO_INCREMENT,
  `name_postach` varchar(50) NOT NULL,
  `address` text NOT NULL,
  `phone_number` varchar(20) NOT NULL,
  `company_name` varchar(255) NOT NULL,
  PRIMARY KEY (`id_postach`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп даних таблиці `postachalnik`
--

INSERT INTO `postachalnik` (`id_postach`, `name_postach`, `address`, `phone_number`, `company_name`) VALUES
(1, 'Василь Семенко', 'вул.Велика Бердичівська, 98', '+380976543231', 'ТОВ\"Vasyl_Sem\"'),
(2, 'Катерина Бойко', 'вул.Лесі Українки, 45', '+380765402451', 'ФОП\"Катерина Бойко\"'),
(3, 'Денис Петренко', 'вул.Перемоги, 56', '+380976543218', 'KandyCrash');

-- --------------------------------------------------------

--
-- Структура таблиці `tovars`
--

DROP TABLE IF EXISTS `tovars`;
CREATE TABLE IF NOT EXISTS `tovars` (
  `id_tovar` int NOT NULL AUTO_INCREMENT,
  `tov_name` varchar(50) NOT NULL,
  `quantity` int NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `id_postach` int NOT NULL,
  PRIMARY KEY (`id_tovar`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп даних таблиці `tovars`
--

INSERT INTO `tovars` (`id_tovar`, `tov_name`, `quantity`, `price`, `id_postach`) VALUES
(1, 'Цукерки \"Зоряна ніч\"', 50, 12000, 3),
(2, 'М\'яч футбольний', 207, 150, 2),
(14, 'Чашка кавова', 569, 250, 2),
(6, 'чашка', 1699, 130, 1),
(7, 'Чохол для IPhone 13 Pro', 25, 400, 2),
(8, 'Іграшка для кота', 1200, 89, 2),
(9, 'Тарілка для супу', 349, 95, 1),
(10, 'Карта України', 500, 480, 1),
(11, 'М\'яч тенісний', 5, 520, 2),
(13, 'test3', 333, 333, 3);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
