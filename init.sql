-- phpMyAdmin SQL Dump
-- version 5.2.2
-- https://www.phpmyadmin.net/
--
-- Hôte : db:3306
-- Généré le : mer. 11 mars 2026 à 23:13
-- Version du serveur : 8.1.0
-- Version de PHP : 8.2.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `GSB-Manager`
--
CREATE DATABASE IF NOT EXISTS `GSB-Manager` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `GSB-Manager`;

-- --------------------------------------------------------

--
-- Structure de la table `Appartient`
--

CREATE TABLE `Appartient` (
  `prescription_id` int DEFAULT NULL,
  `medicine_id` int DEFAULT NULL,
  `quantity` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Appartient`
--

INSERT INTO `Appartient` (`prescription_id`, `medicine_id`, `quantity`) VALUES
(55, 2, 1),
(55, 8, 7),
(56, 2, 1),
(58, 26, 1),
(58, 2, 7);

-- --------------------------------------------------------

--
-- Structure de la table `Log`
--

CREATE TABLE `Log` (
  `log_id` int NOT NULL,
  `origin_user_id` int NOT NULL,
  `date` datetime NOT NULL,
  `field` varchar(100) NOT NULL,
  `action_type` varchar(50) NOT NULL DEFAULT 'OTHER',
  `element_id` int NOT NULL,
  `description` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Log`
--

INSERT INTO `Log` (`log_id`, `origin_user_id`, `date`, `field`, `action_type`, `element_id`, `description`) VALUES
(2, 16, '2025-12-16 15:33:46', 'User', 'OTHER', 16, 'User Durand Claire logged in successfully'),
(3, 16, '2025-12-16 15:34:17', 'Medicine', 'OTHER', 25, 'Medicine created: testlog - h 5mg'),
(4, 16, '2025-12-16 15:35:00', 'Medicine', 'OTHER', 25, 'Medicine modified: testlog_modify - h 50mg'),
(5, 16, '2025-12-16 15:35:13', 'Medicine', 'OTHER', 25, 'Medicine deleted: testlog_modify (ID: 25)'),
(6, 16, '2025-12-16 15:35:40', 'Prescription', 'OTHER', 57, 'Prescription created: ID 57, Patient ID 2, Validity: 2025-12-16'),
(7, 16, '2025-12-16 15:36:08', 'Prescription', 'OTHER', 57, 'Prescription modified: ID 57, Patient ID 2, Validity: 2025-12-16'),
(8, 16, '2025-12-16 15:36:22', 'Prescription', 'OTHER', 57, 'Prescription deleted: Prescription #57 — Patient: Jean Lambert | Médecin: Dr. Claire Durand (ID: 57)'),
(9, 16, '2025-12-16 15:36:41', 'Patient', 'OTHER', 19, 'Patient created: a a, 8 years old, Male'),
(10, 16, '2025-12-16 15:37:14', 'Patient', 'OTHER', 19, 'Patient modified: a2 a2, 82 years old, Female'),
(11, 16, '2025-12-16 15:37:21', 'Patient', 'OTHER', 1, 'Patient deleted: Marie Dupont (ID: 1)'),
(12, 1, '2025-12-16 15:49:53', 'User', 'OTHER', 1, 'User Martin Paul logged in successfully'),
(13, 1, '2025-12-16 15:57:09', 'User', 'OTHER', 1, 'User Martin Paul logged in successfully'),
(14, 1, '2025-12-16 16:07:34', 'User', 'OTHER', 1, 'User Martin Paul logged in successfully'),
(15, 1, '2025-12-16 16:10:06', 'User', 'OTHER', 1, 'User Martin Paul logged in successfully'),
(16, 1, '2025-12-16 16:16:07', 'User', 'OTHER', 1, 'User Martin Paul logged in successfully'),
(17, 16, '2025-12-16 16:17:19', 'User', 'OTHER', 16, 'User Durand Claire logged in successfully'),
(18, 16, '2025-12-16 16:18:25', 'User', 'OTHER', 16, 'User Durand Claire logged in successfully'),
(19, 1, '2025-12-16 16:18:53', 'User', 'OTHER', 1, 'User Martin Paul logged in successfully'),
(20, 1, '2026-01-07 11:30:38', 'User', 'OTHER', 1, 'User Martin Paul logged in successfully');

-- --------------------------------------------------------

--
-- Structure de la table `Medicine`
--

CREATE TABLE `Medicine` (
  `medicine_id` int NOT NULL,
  `user_id` int DEFAULT NULL,
  `dosage` int DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `description` text,
  `molecule` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Medicine`
--

INSERT INTO `Medicine` (`medicine_id`, `user_id`, `dosage`, `name`, `description`, `molecule`) VALUES
(2, 1, 250, 'Amoxicilline', 'Antibiotique à large spectre', 'Amoxicilline trihydratée'),
(8, 7, 500, 'Metformine', 'Antidiabétique oral', 'Metformine'),
(23, 16, 500, 'Aspirine', 'Pour douleurs de tête', 'jsp'),
(24, 16, 400, 'Paracétamol', 'calmer la douleur', 'p'),
(26, 16, 500, 'z', 'z', 'z');

-- --------------------------------------------------------

--
-- Structure de la table `Patients`
--

CREATE TABLE `Patients` (
  `patient_id` int NOT NULL,
  `user_id` int DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `age` int DEFAULT NULL,
  `gender` varchar(20) DEFAULT NULL,
  `firstname` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Patients`
--

INSERT INTO `Patients` (`patient_id`, `user_id`, `name`, `age`, `gender`, `firstname`) VALUES
(2, 1, 'Lambert', 45, 'Homme', 'Jean'),
(6, 5, 'Richard', 41, 'Homme', 'Noah'),
(7, 6, 'Simon', 30, 'Femme', 'Emma'),
(8, 7, 'Michel', 27, 'Homme', 'Tom'),
(9, 8, 'David', 36, 'Femme', 'Sarah'),
(18, 7, 'e7', 5, 'Male', 'e'),
(19, 16, 'a2', 82, 'Female', 'a2');

-- --------------------------------------------------------

--
-- Structure de la table `Prescription`
--

CREATE TABLE `Prescription` (
  `prescription_id` int NOT NULL,
  `user_id` int DEFAULT NULL,
  `patient_id` int DEFAULT NULL,
  `validity` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Prescription`
--

INSERT INTO `Prescription` (`prescription_id`, `user_id`, `patient_id`, `validity`) VALUES
(55, 8, 8, '2025-12-09'),
(56, 8, 18, '2025-12-09'),
(58, 16, 2, '2026-01-10');

-- --------------------------------------------------------

--
-- Structure de la table `Users`
--

CREATE TABLE `Users` (
  `user_id` int NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `firstname` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` varchar(200) DEFAULT NULL,
  `role` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Users`
--

INSERT INTO `Users` (`user_id`, `name`, `firstname`, `email`, `password`, `role`) VALUES
(1, 'Martin', 'Paul', 'paul.martin@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 1),
(5, 'Petit', 'Hugo', 'hugo.petit@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 1),
(6, 'Moreau', 'Sophie', 'sophie.moreau@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(7, 'Leroy', 'Nicolas', 'nicolas.leroy@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(8, 'Fontaine', 'Emma', 'emma.fontaine@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(9, 'Benoit', 'Lucas', 'lucas.benoit@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 1),
(16, 'Durand', 'Claire', 'claire.durand@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `Appartient`
--
ALTER TABLE `Appartient`
  ADD KEY `prescription_id` (`prescription_id`),
  ADD KEY `medicine_id` (`medicine_id`);

--
-- Index pour la table `Log`
--
ALTER TABLE `Log`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `idx_date` (`date`),
  ADD KEY `idx_origin_user` (`origin_user_id`);

--
-- Index pour la table `Medicine`
--
ALTER TABLE `Medicine`
  ADD PRIMARY KEY (`medicine_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Index pour la table `Patients`
--
ALTER TABLE `Patients`
  ADD PRIMARY KEY (`patient_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Index pour la table `Prescription`
--
ALTER TABLE `Prescription`
  ADD PRIMARY KEY (`prescription_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `patients_id` (`patient_id`);

--
-- Index pour la table `Users`
--
ALTER TABLE `Users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `Log`
--
ALTER TABLE `Log`
  MODIFY `log_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT pour la table `Medicine`
--
ALTER TABLE `Medicine`
  MODIFY `medicine_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT pour la table `Patients`
--
ALTER TABLE `Patients`
  MODIFY `patient_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT pour la table `Prescription`
--
ALTER TABLE `Prescription`
  MODIFY `prescription_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT pour la table `Users`
--
ALTER TABLE `Users`
  MODIFY `user_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `Appartient`
--
ALTER TABLE `Appartient`
  ADD CONSTRAINT `Appartient_ibfk_1` FOREIGN KEY (`prescription_id`) REFERENCES `Prescription` (`prescription_id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  ADD CONSTRAINT `Appartient_ibfk_2` FOREIGN KEY (`medicine_id`) REFERENCES `Medicine` (`medicine_id`) ON DELETE CASCADE ON UPDATE RESTRICT;

--
-- Contraintes pour la table `Log`
--
ALTER TABLE `Log`
  ADD CONSTRAINT `Log_ibfk_1` FOREIGN KEY (`origin_user_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `Medicine`
--
ALTER TABLE `Medicine`
  ADD CONSTRAINT `Medicine_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE ON UPDATE RESTRICT;

--
-- Contraintes pour la table `Patients`
--
ALTER TABLE `Patients`
  ADD CONSTRAINT `Patients_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE ON UPDATE RESTRICT;

--
-- Contraintes pour la table `Prescription`
--
ALTER TABLE `Prescription`
  ADD CONSTRAINT `Prescription_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  ADD CONSTRAINT `Prescription_ibfk_2` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
