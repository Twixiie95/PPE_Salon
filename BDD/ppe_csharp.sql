-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 07 juin 2021 à 16:47
-- Version du serveur :  5.7.26
-- Version de PHP :  7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ppe_csharp`
--

-- --------------------------------------------------------

--
-- Structure de la table `connexion`
--

DROP TABLE IF EXISTS `connexion`;
CREATE TABLE IF NOT EXISTS `connexion` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(200) DEFAULT NULL,
  `heureDebut` varchar(200) DEFAULT NULL,
  `heureFin` varchar(200) DEFAULT NULL,
  `Date` varchar(200) DEFAULT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `DateForma` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=202 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `connexion`
--

INSERT INTO `connexion` (`id`, `login`, `heureDebut`, `heureFin`, `Date`, `nom`, `prenom`, `DateForma`) VALUES
(49, 'azerty', '11:10', NULL, '05/02/2021', 'el ghoul', 'elias', '2021-02-05 00:00:00'),
(48, 'azerty', '11:08', NULL, '05/02/2021', 'el ghoul', 'elias', NULL),
(47, 'azerty', '11:07', '11:07', '05/02/2021', 'el ghoul', 'elias', NULL),
(46, 'azerty', '10:54', '10:54', '05/02/2021', 'el ghoul', 'elias', NULL),
(45, 'azerty', '10:45', '10:45', '05/02/2021', 'el ghoul', 'elias', NULL),
(44, 'azerty', '10:44', '10:44', '05/02/2021', 'el ghoul', 'elias', NULL),
(43, 'azerty', '10:44', NULL, '05/02/2021', 'el ghoul', 'elias', NULL),
(42, 'azerty', '10:41', '10:41', '05/02/2021', 'el ghoul', 'elias', NULL),
(41, 'azerty', '09:48', '09:48', '05/02/2021', 'el ghoul', 'elias', NULL),
(40, 'azerty', '09:47', '09:47', '05/02/2021', 'el ghoul', 'elias', NULL),
(39, 'azerty', '09:46', NULL, '05/02/2021', 'el ghoul', 'elias', NULL),
(38, 'azerty', '09:43', NULL, '05/02/2021', 'el ghoul', 'elias', NULL),
(37, 'azerty', '09:31', '09:30', '05/02/2021', 'el ghoul', 'elias', NULL),
(36, 'azerty', '09:28', '09:28', '05/02/2021', 'el ghoul', 'elias', NULL),
(35, 'azerty', '11:46', '11:46', '29/01/2021', 'elias', 'el ghoul', NULL),
(34, 'azerty', '11:38', '11:38', '29/01/2021', 'elias', 'el ghoul', NULL),
(50, '123', '11:14', '11:14', '05/02/2021', 'el ghoul', 'elias', NULL),
(51, '123', '11:15', '11:15', '05/02/2021', 'el ghoul', 'elias', NULL),
(52, '123', '11:18', '11:18', '05/02/2021', 'el ghoul', 'elias', NULL),
(53, '123', '11:19', '11:19', '05/02/2021', 'el ghoul', 'elias', NULL),
(54, '123', '11:19', NULL, '05/02/2021', 'el ghoul', 'elias', NULL),
(55, '123', '11:36', '11:35', '05/02/2021', 'el ghoul', 'elias', NULL),
(56, '123', '11:39', '11:39', '05/02/2021', 'el ghoul', 'elias', NULL),
(57, '123', '11:39', NULL, '05/02/2021', 'el ghoul', 'elias', NULL),
(58, '123', '11:40', '11:40', '05/02/2021', 'el ghoul', 'elias', NULL),
(59, '123', '11:41', '11:40', '05/02/2021', 'el ghoul', 'elias', NULL),
(60, '123', '11:45', '11:45', '05/02/2021', 'el ghoul', 'elias', NULL),
(61, '123', '11:19', NULL, '12/02/2021', 'el ghoul', 'elias', NULL),
(62, '123', '11:17', '11:16', '19/02/2021', 'el ghoul', 'elias', NULL),
(63, '123', '11:18', NULL, '19/02/2021', 'el ghoul', 'elias', NULL),
(64, '1', '11:27', '11:27', '19/02/2021', 'el ghoul', '123', NULL),
(65, '123', '11:27', NULL, '19/02/2021', 'el ghoul', '123', NULL),
(66, '123', '11:29', '11:29', '19/02/2021', 'el ghoul', '123', NULL),
(67, '123', '11:45', NULL, '19/02/2021', 'el ghoul', '123', NULL),
(68, '123', '11:46', NULL, '19/02/2021', 'el ghoul', '123', NULL),
(69, '123', '11:47', '11:47', '19/02/2021', 'el ghoul', '123', NULL),
(70, '123', '11:47', NULL, '19/02/2021', 'el ghoul', '123', NULL),
(71, '123', '11:48', NULL, '19/02/2021', 'el ghoul', '123', NULL),
(72, '123', '11:49', '11:49', '19/02/2021', 'el ghoul', '123', NULL),
(73, '123', '12:03', '12:02', '19/02/2021', 'el ghoul', '123', NULL),
(74, '123', '12:03', NULL, '19/02/2021', 'el ghoul', '123', NULL),
(75, '123', '11:34', '11:34', '12/03/2021', 'el ghoul', '123', NULL),
(76, '123', '11:34', NULL, '12/03/2021', 'el ghoul', '123', NULL),
(77, '123', '11:36', NULL, '12/03/2021', 'el ghoul', '123', NULL),
(78, '123', '10:51', '10:51', '26/03/2021', 'el ghoul', '123', NULL),
(79, '123', '10:53', '10:53', '09/04/2021', 'el ghoul', '123', NULL),
(80, '123', '10:53', NULL, '09/04/2021', 'el ghoul', '123', NULL),
(81, '123', '11:11', '11:11', '09/04/2021', 'el ghoul', '123', NULL),
(82, '123', '11:15', NULL, '09/04/2021', 'el ghoul', '123', NULL),
(83, '123', '11:15', NULL, '09/04/2021', 'el ghoul', '123', NULL),
(84, '123', '11:21', NULL, '09/04/2021', 'el ghoul', '123', NULL),
(85, '456', '11:23', '11:23', '09/04/2021', 'ELIAS', '456', NULL),
(86, '123', '11:23', NULL, '09/04/2021', 'el ghoul', '123', NULL),
(87, '123', '11:26', '11:26', '09/04/2021', 'el ghoul', '123', NULL),
(88, '123', '11:29', NULL, '09/04/2021', 'el ghoul', '123', NULL),
(89, '123', '11:29', NULL, '09/04/2021', 'el ghoul', '123', NULL),
(90, '123', '13:46', '13:46', '09/04/2021', 'el ghoul', '123', NULL),
(91, '123', '19:49', '19:48', '09/04/2021', 'el ghoul', '123', NULL),
(92, 'Correcteur', '19:50', '19:50', '09/04/2021', 'admin', 'Correcteur', NULL),
(93, '123', '00:28', NULL, '12/04/2021', 'el ghoul', '123', NULL),
(94, '123', '00:31', NULL, '12/04/2021', 'el ghoul', '123', NULL),
(95, '123', '00:33', NULL, '12/04/2021', 'el ghoul', '123', NULL),
(96, '123', '00:36', NULL, '12/04/2021', 'el ghoul', '123', NULL),
(97, '123', '00:42', NULL, '12/04/2021', 'el ghoul', '123', NULL),
(98, '123', '00:44', NULL, '12/04/2021', 'el ghoul', '123', NULL),
(99, '456', '01:52', '01:52', '13/04/2021', 'test', '456', NULL),
(100, '456', '01:58', '01:58', '13/04/2021', 'test', '456', NULL),
(101, '456', '01:59', '01:59', '13/04/2021', 'test', '456', NULL),
(102, '123', '01:59', NULL, '13/04/2021', 'el ghoul', '123', NULL),
(103, '456', '01:59', NULL, '13/04/2021', 'test', '456', NULL),
(104, '456', '02:05', NULL, '13/04/2021', 'test', '456', NULL),
(105, '456', '02:05', NULL, '13/04/2021', 'test', '456', NULL),
(106, '456', '02:06', NULL, '13/04/2021', 'test', '456', NULL),
(107, '456', '02:09', NULL, '13/04/2021', 'test', '456', NULL),
(108, '456', '02:09', NULL, '13/04/2021', 'test', '456', NULL),
(109, '456', '02:10', NULL, '13/04/2021', 'test', '456', NULL),
(110, '456', '02:11', NULL, '13/04/2021', 'test', '456', NULL),
(111, '456', '02:12', NULL, '13/04/2021', 'test', '456', NULL),
(112, '456', '12:38', '12:38', '13/04/2021', 'test', '456', NULL),
(113, '456', '12:39', '12:39', '13/04/2021', 'test', '456', NULL),
(114, '456', '12:40', '12:40', '13/04/2021', 'test', '456', NULL),
(115, '456', '12:42', '12:42', '13/04/2021', 'test', '456', NULL),
(116, '456', '12:56', '12:56', '13/04/2021', 'test', '456', NULL),
(117, '123', '12:59', NULL, '13/04/2021', 'el ghoul', '123', NULL),
(118, '456', '13:00', '13:00', '13/04/2021', 'test', '456', NULL),
(119, '123', '13:15', NULL, '13/04/2021', 'el ghoul', '123', NULL),
(120, '456', '13:16', '13:16', '13/04/2021', 'test', '456', NULL),
(121, '123', '18:38', NULL, '13/04/2021', 'el ghoul', '123', NULL),
(122, '123', '20:31', '20:31', '13/04/2021', 'el ghoul', '123', NULL),
(123, '456', '20:32', '20:32', '13/04/2021', 'test', '456', NULL),
(124, '123', '09:13', '09:13', '16/04/2021', 'el ghoul', '123', '2021-04-16 00:00:00'),
(125, '456', '09:14', '09:14', '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(126, '456', '09:32', '09:32', '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(127, '456', '09:47', NULL, '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(128, '456', '09:48', NULL, '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(129, '456', '09:58', '09:58', '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(130, '456', '11:31', '11:31', '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(131, '456', '11:32', '11:32', '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(132, '456', '11:33', '11:33', '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(133, '456', '11:33', NULL, '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(134, '456', '11:34', NULL, '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(135, '456', '11:34', NULL, '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(136, '456', '11:35', '11:35', '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(137, '456', '11:35', NULL, '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(138, '456', '11:36', NULL, '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(139, '456', '11:40', NULL, '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(140, '456', '11:43', '11:43', '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(141, '456', '11:45', NULL, '16/04/2021', 'test', '456', '2021-04-16 00:00:00'),
(142, '123', '09:47', NULL, '05/05/2021', 'el ghoul', '123', NULL),
(143, '456', '09:47', NULL, '05/05/2021', 'test', '456', NULL),
(144, '123', '10:24', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(145, '123', '10:26', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(146, '123', '10:28', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(147, '123', '10:30', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(148, '123', '10:31', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(149, '123', '10:32', '10:32', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(150, '123', '10:36', '10:36', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(151, '123', '10:36', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(152, '123', '10:37', '10:37', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(153, '123', '10:38', '10:38', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(154, '123', '10:38', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(155, '123', '10:39', '10:39', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(156, '123', '10:39', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(157, '123', '10:41', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(158, '123', '10:43', '10:43', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(159, '123', '10:43', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(160, '123', '10:43', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(161, '123', '10:46', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(162, '123', '10:50', '10:50', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(163, '123', '10:55', '10:55', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(164, '123', '10:55', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(165, '123', '11:04', '11:04', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(166, '123', '11:04', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(167, '123', '11:05', '11:05', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(168, '123', '11:06', '11:06', '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(169, '123', '11:07', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(170, '123', '11:11', NULL, '28/05/2021', 'el ghoul', '123', '2021-05-28 00:00:00'),
(171, '123', '11:34', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(172, '123', '11:36', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(173, '123', '11:38', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(174, '123', '11:39', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(175, '123', '11:39', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(176, '123', '11:41', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(177, '123', '11:42', '11:42', '28/05/2021', 'el ghoul', '123', NULL),
(178, '123', '11:43', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(179, '123', '11:45', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(180, '123', '11:45', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(181, '123', '11:49', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(182, '123', '11:50', '11:50', '28/05/2021', 'el ghoul', '123', NULL),
(183, '123', '11:51', '11:51', '28/05/2021', 'el ghoul', '123', NULL),
(184, '123', '11:53', '11:53', '28/05/2021', 'el ghoul', '123', NULL),
(185, '123', '11:54', '11:54', '28/05/2021', 'el ghoul', '123', NULL),
(186, '123', '11:56', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(187, '123', '12:00', '12:00', '28/05/2021', 'el ghoul', '123', NULL),
(188, '123', '12:00', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(189, '123', '12:01', '12:01', '28/05/2021', 'el ghoul', '123', NULL),
(190, '123', '12:02', '12:02', '28/05/2021', 'el ghoul', '123', NULL),
(191, '123', '12:03', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(192, '123', '12:05', NULL, '28/05/2021', 'el ghoul', '123', NULL),
(193, '123', '12:06', '12:06', '28/05/2021', 'el ghoul', '123', NULL),
(194, '123', '12:07', '12:07', '28/05/2021', 'el ghoul', '123', NULL),
(195, '123', '12:09', '12:09', '28/05/2021', 'el ghoul', '123', NULL),
(196, '123', '12:14', '12:14', '28/05/2021', 'el ghoul', '123', NULL),
(197, 'Correcteur', '12:54', '12:54', '05/06/2021', 'admin', 'Correcteur', NULL),
(198, '123', '12:56', NULL, '05/06/2021', 'el ghoul', '123', NULL),
(199, '456', '12:56', NULL, '05/06/2021', 'test', '456', NULL),
(200, '456', '12:58', '12:58', '05/06/2021', 'test', '456', NULL),
(201, 'Correcteur', '18:43', '18:43', '07/06/2021', 'admin', 'Correcteur', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `erreurco`
--

DROP TABLE IF EXISTS `erreurco`;
CREATE TABLE IF NOT EXISTS `erreurco` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(255) NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `erreurco`
--

INSERT INTO `erreurco` (`id`, `login`, `date`) VALUES
(3, 'azerty', '2021-01-29 11:58:25'),
(4, '5555', '2021-03-12 11:42:45'),
(5, '541', '2021-04-09 10:53:45');

-- --------------------------------------------------------

--
-- Structure de la table `participant`
--

DROP TABLE IF EXISTS `participant`;
CREATE TABLE IF NOT EXISTS `participant` (
  `idSalon` int(11) NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `Departement` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id` (`idSalon`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `participant`
--

INSERT INTO `participant` (`idSalon`, `id`, `nom`, `prenom`, `Departement`, `Email`) VALUES
(1, 2, 'El ghoul', 'Elias', '95170', 'test@gmail.com'),
(1, 3, 'Nicolle', 'Dylan', '75001', 'dylanN@outlook.fr'),
(1, 4, 'Quentin', 'Coqueran', '94130', 'Silkos@gmail.com'),
(2, 5, 'Da Costa ', 'Sophie', '95170', 'sophie@gmail.com'),
(3, 6, 'chikh', 'elisabeth', '94130', 'eliz@outlook.fr'),
(4, 7, 'el ghoul', 'youssef', '93800', 'youssef@gmail.com'),
(5, 8, 'elias', 'el ghoul', '95170', 'elias@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `salon`
--

DROP TABLE IF EXISTS `salon`;
CREATE TABLE IF NOT EXISTS `salon` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(45) DEFAULT NULL,
  `Lieu` varchar(45) DEFAULT NULL,
  `DateDeb` datetime DEFAULT NULL,
  `DateFin` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `salon`
--

INSERT INTO `salon` (`ID`, `Nom`, `Lieu`, `DateDeb`, `DateFin`) VALUES
(1, 'alternance', 'paris', '2021-04-12 00:00:00', '2021-04-12 00:00:00'),
(2, 'salon table', 'auxerre', '2021-04-15 00:00:00', '2021-04-22 00:00:00'),
(3, 'salon de nogent', 'nogent sur marne', '2021-05-03 00:00:00', '2021-05-08 00:00:00'),
(4, 'salon epinay', 'epinay sur seine', '2021-04-13 00:00:00', '2021-04-16 00:00:00'),
(5, 'cerfal', 'paris', '2021-04-19 00:00:00', '2021-04-24 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `pwd` varchar(255) NOT NULL,
  `adm` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `login`, `nom`, `prenom`, `pwd`, `adm`) VALUES
(1, '123', 'el ghoul', 'elias2', '40BD001563085FC35165329EA1FF5C5ECBDBBEEF', 3),
(2, '456', 'test', 'test', '51EAC6B471A284D3341D8C0C63D0F1A286262A18', 2),
(6, 'Correcteur', 'admin', 'Correcteur', '7B4D45627C1A52D3DD802E8345EE497BC5B45E86', 3),
(5, 'toto', 'tata', 'toto', '0B9C2625DC21EF05F6AD4DDF47C5F203837AA32C', 2);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `participant`
--
ALTER TABLE `participant`
  ADD CONSTRAINT `participant_ibfk_1` FOREIGN KEY (`idSalon`) REFERENCES `salon` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
