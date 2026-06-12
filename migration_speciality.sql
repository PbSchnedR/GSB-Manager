-- Migration : ajout des spécialités des médecins
-- À exécuter sur une base GSB-Manager existante.
USE `GSB-Manager`;

-- Requête 1 : création de la table Speciality + quelques spécialités
CREATE TABLE `Speciality` (
  `speciality_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`speciality_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `Speciality` (`name`) VALUES
('Médecine générale'),
('Psychologie'),
('Cardiologie'),
('Dermatologie'),
('Pédiatrie'),
('Psychiatrie'),
('Neurologie');

-- Requête 2 : ajout de la clé étrangère speciality_id sur Users
ALTER TABLE `Users`
  ADD COLUMN `speciality_id` int DEFAULT NULL,
  ADD KEY `speciality_id` (`speciality_id`),
  ADD CONSTRAINT `Users_ibfk_speciality` FOREIGN KEY (`speciality_id`) REFERENCES `Speciality` (`speciality_id`) ON DELETE SET NULL ON UPDATE RESTRICT;
