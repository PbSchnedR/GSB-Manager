-- phpMyAdmin SQL Dump
-- version 5.2.2
-- https://www.phpmyadmin.net/
--
-- Hôte : db:3306
-- Généré le : mer. 19 nov. 2025 à 09:08
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
-- Base de données : `GSB-manager`
--

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
(2, 2, 1),
(3, 4, 2),
(4, 1, 1),
(5, 5, 8),
(6, 7, 4),
(7, 6, 1),
(8, 8, 2),
(9, 9, 1),
(10, 10, 2),
(10, 3, 1),
(13, 3, 1),
(13, 6, 2),
(17, 5, 1);

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
(1, 2, 600, 'Paracétamol', 'Antidouleur et antipyrétique', 'Acétaminophène'),
(2, 1, 250, 'Amoxicilline', 'Antibiotique à large spectre', 'Amoxicilline trihydratée'),
(3, 2, 100, 'Ibuprofène', 'Anti-inflammatoire non stéroïdien', 'Ibuprofène'),
(4, 3, 20, 'Oméprazole', 'Inhibiteur de la pompe à protons', 'Oméprazole'),
(5, 4, 75, 'Aspirine', 'Antidouleur, antipyrétique', 'Acide acétylsalicylique'),
(6, 5, 10, 'Loratadine', 'Antihistaminique', 'Loratadine'),
(7, 6, 40, 'Atorvastatine', 'Réducteur du cholestérol', 'Atorvastatine'),
(8, 7, 500, 'Metformine', 'Antidiabétique oral', 'Metformine'),
(9, 8, 5, 'Bisoprolol', 'Bêta-bloquant', 'Bisoprolol fumarate'),
(10, 9, 50, 'Sertraline', 'Antidépresseur ISRS', 'Sertraline'),
(11, 1, 500, 'aspirine', 'anti-douleur', 'acide acétylsalicylique');

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
(1, 1, 'Dupont', 34, 'Femme', 'Marie'),
(2, 1, 'Lambert', 45, 'Homme', 'Jean'),
(3, 2, 'Rousseau', 29, 'Femme', 'Camille'),
(4, 3, 'Bernard', 53, 'Homme', 'Luc'),
(5, 4, 'Robert', 22, 'Femme', 'Chloé'),
(6, 5, 'Richard', 41, 'Homme', 'Noah'),
(7, 6, 'Simon', 30, 'Femme', 'Emma'),
(8, 7, 'Michel', 27, 'Homme', 'Tom'),
(9, 8, 'David', 36, 'Femme', 'Sarah'),
(10, 9, 'Morel', 39, 'Homme', 'Nathan'),
(11, 1, 'bourré', 24, 'masculin', 'morgan'),
(12, 1, 'stucked', 20, 'masculin', 'hugo');

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
(2, 1, 2,  '2025-10-10'),
(3, 2, 3,  '2025-09-20'),
(4, 3, 4,  '2025-10-05'),
(5, 4, 5,  '2025-11-01'),
(6, 5, 6,  '2025-10-15'),
(7, 6, 7,  '2025-09-25'),
(8, 7, 8,  '2025-10-12'),
(9, 8, 9,  '2025-10-18'),
(10, 9, 10,  '2025-11-10'),
(11, 1, 1,  '2025-11-29'),
(12, 1, 1,  '2025-11-05'),
(13, 2, 2,  '2025-11-06'),
(14, 2, 11,  '2025-11-21'),
(15, 2, 4,  '2025-11-05'),
(17, 2, 12,  '2025-11-29');

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
(2, 'Durand', 'Claire', 'claire.durand@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(3, 'Lemoine', 'Alex', 'alex.lemoine@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(4, 'Dubois', 'Julie', 'julie.dubois@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(5, 'Petit', 'Hugo', 'hugo.petit@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 1),
(6, 'Moreau', 'Sophie', 'sophie.moreau@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(7, 'Leroy', 'Nicolas', 'nicolas.leroy@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(8, 'Fontaine', 'Emma', 'emma.fontaine@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(9, 'Benoit', 'Lucas', 'lucas.benoit@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 1),
(11, 'f', 's', 'flemme@mail.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0);

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
-- AUTO_INCREMENT pour la table `Medicine`
--
ALTER TABLE `Medicine`
  MODIFY `medicine_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT pour la table `Patients`
--
ALTER TABLE `Patients`
  MODIFY `patient_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT pour la table `Prescription`
--
ALTER TABLE `Prescription`
  MODIFY `prescription_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT pour la table `Users`
--
ALTER TABLE `Users`
  MODIFY `user_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `Appartient`
--
ALTER TABLE `Appartient`
  ADD CONSTRAINT `Appartient_ibfk_1` FOREIGN KEY (`prescription_id`) REFERENCES `Prescription` (`prescription_id`),
  ADD CONSTRAINT `Appartient_ibfk_2` FOREIGN KEY (`medicine_id`) REFERENCES `Medicine` (`medicine_id`);

--
-- Contraintes pour la table `Medicine`
--
ALTER TABLE `Medicine`
  ADD CONSTRAINT `Medicine_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`user_id`);

--
-- Contraintes pour la table `Patients`
--
ALTER TABLE `Patients`
  ADD CONSTRAINT `Patients_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`user_id`);

--
-- Contraintes pour la table `Prescription`
--
ALTER TABLE `Prescription`
  ADD CONSTRAINT `Prescription_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`user_id`),
  ADD CONSTRAINT `Prescription_ibfk_2` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
