-- GSB-Manager - Dump SQL
-- Base de données pour la gestion médicale Galaxy Swiss Bourdin

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

CREATE DATABASE IF NOT EXISTS `GSB-Manager` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `GSB-Manager`;

-- --------------------------------------------------------
-- Table `Users`
-- --------------------------------------------------------

CREATE TABLE `Users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `firstname` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` varchar(200) DEFAULT NULL,
  `role` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Mot de passe : password (SHA-256)
INSERT INTO `Users` (`user_id`, `name`, `firstname`, `email`, `password`, `role`) VALUES
(1,  'Martin',    'Paul',      'paul.martin@example.com',      '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 1),
(2,  'Petit',     'Hugo',      'hugo.petit@example.com',       '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 1),
(3,  'Benoit',    'Lucas',     'lucas.benoit@example.com',     '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 1),
(4,  'Durand',    'Claire',    'claire.durand@example.com',    '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(5,  'Moreau',    'Sophie',    'sophie.moreau@example.com',    '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(6,  'Leroy',     'Nicolas',   'nicolas.leroy@example.com',    '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(7,  'Fontaine',  'Emma',      'emma.fontaine@example.com',    '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(8,  'Bernard',   'Thomas',    'thomas.bernard@example.com',   '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(9,  'Rousseau',  'Julie',     'julie.rousseau@example.com',   '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0),
(10, 'Garcia',    'Antoine',   'antoine.garcia@example.com',   '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0);

-- --------------------------------------------------------
-- Table `Patients`
-- --------------------------------------------------------

CREATE TABLE `Patients` (
  `patient_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `age` int DEFAULT NULL,
  `gender` varchar(20) DEFAULT NULL,
  `firstname` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`patient_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `Patients_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `Patients` (`patient_id`, `user_id`, `name`, `age`, `gender`, `firstname`) VALUES
-- Dr. Claire Durand (user 4)
(1,  4,  'Dupont',      67, 'Homme',  'Jean'),
(2,  4,  'Lambert',     45, 'Femme',  'Marie'),
(3,  4,  'Mercier',     32, 'Homme',  'Pierre'),
(4,  4,  'Blanc',        8, 'Homme',  'Théo'),
(5,  4,  'Faure',       74, 'Femme',  'Jeanne'),
-- Dr. Sophie Moreau (user 5)
(6,  5,  'Richard',     41, 'Homme',  'Noah'),
(7,  5,  'Girard',      55, 'Femme',  'Catherine'),
(8,  5,  'Bonnet',      23, 'Homme',  'Maxime'),
(9,  5,  'Fournier',    38, 'Femme',  'Émilie'),
-- Dr. Nicolas Leroy (user 6)
(10, 6,  'Simon',       30, 'Femme',  'Emma'),
(11, 6,  'Morel',       62, 'Homme',  'Jacques'),
(12, 6,  'Gauthier',    19, 'Homme',  'Raphaël'),
(13, 6,  'Perrin',      48, 'Femme',  'Nathalie'),
-- Dr. Emma Fontaine (user 7)
(14, 7,  'Michel',      27, 'Homme',  'Tom'),
(15, 7,  'David',       36, 'Femme',  'Sarah'),
(16, 7,  'Lemaire',     81, 'Homme',  'Marcel'),
(17, 7,  'Roux',         3, 'Femme',  'Léa'),
-- Dr. Thomas Bernard (user 8)
(18, 8,  'Marchand',    52, 'Homme',  'Philippe'),
(19, 8,  'Picard',      29, 'Femme',  'Camille'),
(20, 8,  'Renard',      44, 'Homme',  'Sébastien'),
-- Dr. Julie Rousseau (user 9)
(21, 9,  'Caron',       71, 'Femme',  'Monique'),
(22, 9,  'Meunier',     16, 'Homme',  'Enzo'),
(23, 9,  'Chevalier',   33, 'Femme',  'Laura'),
-- Dr. Antoine Garcia (user 10)
(24, 10, 'Lefebvre',    58, 'Homme',  'François'),
(25, 10, 'Barbier',     42, 'Femme',  'Isabelle'),
(26, 10, 'Nguyen',      25, 'Homme',  'Kevin');

-- --------------------------------------------------------
-- Table `Medicine`
-- --------------------------------------------------------

CREATE TABLE `Medicine` (
  `medicine_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int DEFAULT NULL,
  `dosage` int DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `description` text,
  `molecule` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`medicine_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `Medicine_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `Medicine` (`medicine_id`, `user_id`, `dosage`, `name`, `description`, `molecule`) VALUES
(1,  4,  500,  'Paracétamol',        'Antalgique et antipyrétique',                          'Paracétamol'),
(2,  4,  250,  'Amoxicilline',       'Antibiotique à large spectre de la famille des pénicillines', 'Amoxicilline trihydratée'),
(3,  5,  400,  'Ibuprofène',         'Anti-inflammatoire non stéroïdien (AINS)',              'Ibuprofène'),
(4,  5,  500,  'Aspirine',           'Antalgique, antipyrétique et anti-inflammatoire',       'Acide acétylsalicylique'),
(5,  6,  500,  'Metformine',         'Antidiabétique oral de première intention',             'Chlorhydrate de metformine'),
(6,  6,   20,  'Oméprazole',         'Inhibiteur de la pompe à protons (anti-acide)',         'Oméprazole'),
(7,  7,   10,  'Amlodipine',         'Antihypertenseur inhibiteur calcique',                  'Bésylate d''amlodipine'),
(8,  7,   40,  'Atorvastatine',      'Hypolipémiant de la famille des statines',              'Atorvastatine calcique'),
(9,  8,   20,  'Fluoxétine',         'Antidépresseur inhibiteur sélectif de la recapture de la sérotonine', 'Chlorhydrate de fluoxétine'),
(10, 8,   50,  'Tramadol',           'Antalgique opioïde de palier 2',                        'Chlorhydrate de tramadol'),
(11, 9,    5,  'Ramipril',           'Inhibiteur de l''enzyme de conversion (IEC), antihypertenseur', 'Ramipril'),
(12, 9,   10,  'Cétirizine',         'Antihistaminique H1 contre les allergies',              'Dichlorhydrate de cétirizine'),
(13, 10,  75,  'Clopidogrel',        'Antiagrégant plaquettaire',                             'Bisulfate de clopidogrel'),
(14, 10, 100,  'Allopurinol',        'Hypo-uricémiant contre la goutte',                     'Allopurinol'),
(15, 4,   30,  'Codéine',            'Antalgique opioïde de palier 2, souvent associé au paracétamol', 'Phosphate de codéine'),
(16, 6,    5,  'Bisoprolol',         'Bêtabloquant cardiosélectif',                           'Fumarate de bisoprolol'),
(17, 7,  250,  'Lévofloxacine',      'Antibiotique fluoroquinolone',                          'Hémihydrate de lévofloxacine'),
(18, 9,   10,  'Montelukast',        'Antagoniste des récepteurs aux leucotriènes (asthme)',   'Montelukast sodique'),
(19, 5,  850,  'Metformine Forte',   'Antidiabétique oral dosage élevé',                      'Chlorhydrate de metformine'),
(20, 10,  25,  'Hydroxyzine',        'Anxiolytique antihistaminique',                         'Dichlorhydrate d''hydroxyzine');

-- --------------------------------------------------------
-- Table `Prescription`
-- --------------------------------------------------------

CREATE TABLE `Prescription` (
  `prescription_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int DEFAULT NULL,
  `patient_id` int DEFAULT NULL,
  `validity` date DEFAULT NULL,
  PRIMARY KEY (`prescription_id`),
  KEY `user_id` (`user_id`),
  KEY `patients_id` (`patient_id`),
  CONSTRAINT `Prescription_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `Prescription_ibfk_2` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `Prescription` (`prescription_id`, `user_id`, `patient_id`, `validity`) VALUES
-- Dr. Claire Durand → ses patients
(1,  4,  1,  '2026-04-15'),   -- Jean Dupont - patient âgé, traitement chronique
(2,  4,  1,  '2026-01-20'),   -- Jean Dupont - prescription expirée
(3,  4,  2,  '2026-06-01'),   -- Marie Lambert
(4,  4,  3,  '2026-03-30'),   -- Pierre Mercier
(5,  4,  4,  '2026-05-10'),   -- Théo Blanc (enfant)
(6,  4,  5,  '2026-07-01'),   -- Jeanne Faure - patiente âgée
-- Dr. Sophie Moreau → ses patients
(7,  5,  6,  '2026-04-20'),   -- Noah Richard
(8,  5,  7,  '2026-05-15'),   -- Catherine Girard
(9,  5,  8,  '2026-02-28'),   -- Maxime Bonnet - expirée
(10, 5,  9,  '2026-06-30'),   -- Émilie Fournier
-- Dr. Nicolas Leroy → ses patients
(11, 6,  10, '2026-04-01'),   -- Emma Simon
(12, 6,  11, '2026-08-01'),   -- Jacques Morel - traitement long
(13, 6,  12, '2026-03-15'),   -- Raphaël Gauthier
(14, 6,  13, '2026-05-20'),   -- Nathalie Perrin
-- Dr. Emma Fontaine → ses patients
(15, 7,  14, '2026-04-10'),   -- Tom Michel
(16, 7,  15, '2026-06-15'),   -- Sarah David
(17, 7,  16, '2026-09-01'),   -- Marcel Lemaire - patient très âgé, traitement long
(18, 7,  17, '2026-05-01'),   -- Léa Roux (enfant en bas âge)
-- Dr. Thomas Bernard → ses patients
(19, 8,  18, '2026-04-25'),   -- Philippe Marchand
(20, 8,  19, '2026-07-10'),   -- Camille Picard
(21, 8,  20, '2026-03-01'),   -- Sébastien Renard - expirée
-- Dr. Julie Rousseau → ses patients
(22, 9,  21, '2026-06-01'),   -- Monique Caron - patiente âgée
(23, 9,  22, '2026-04-30'),   -- Enzo Meunier (adolescent)
(24, 9,  23, '2026-05-20'),   -- Laura Chevalier
-- Dr. Antoine Garcia → ses patients
(25, 10, 24, '2026-08-15'),   -- François Lefebvre
(26, 10, 25, '2026-04-05'),   -- Isabelle Barbier
(27, 10, 26, '2026-05-30'),   -- Kevin Nguyen
-- Prescriptions multiples pour un même patient (historique)
(28, 4,  5,  '2025-12-01'),   -- Jeanne Faure - ancienne prescription expirée
(29, 7,  16, '2025-11-15'),   -- Marcel Lemaire - ancienne prescription expirée
(30, 9,  21, '2025-10-01');   -- Monique Caron - ancienne prescription expirée

-- --------------------------------------------------------
-- Table `Appartient` (liaison prescription ↔ médicament)
-- --------------------------------------------------------

CREATE TABLE `Appartient` (
  `prescription_id` int DEFAULT NULL,
  `medicine_id` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  KEY `prescription_id` (`prescription_id`),
  KEY `medicine_id` (`medicine_id`),
  CONSTRAINT `Appartient_ibfk_1` FOREIGN KEY (`prescription_id`) REFERENCES `Prescription` (`prescription_id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `Appartient_ibfk_2` FOREIGN KEY (`medicine_id`) REFERENCES `Medicine` (`medicine_id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `Appartient` (`prescription_id`, `medicine_id`, `quantity`) VALUES
-- Prescription 1: Jean Dupont (âgé, cardio + cholestérol)
(1,  7,  1),   -- Amlodipine 10mg x1
(1,  8,  1),   -- Atorvastatine 40mg x1
(1,  13, 1),   -- Clopidogrel 75mg x1
-- Prescription 2: Jean Dupont (ancienne, juste antalgique)
(2,  1,  2),   -- Paracétamol 500mg x2
-- Prescription 3: Marie Lambert (infection)
(3,  2,  2),   -- Amoxicilline 250mg x2
(3,  1,  3),   -- Paracétamol 500mg x3
-- Prescription 4: Pierre Mercier (douleur + inflammation)
(4,  3,  1),   -- Ibuprofène 400mg x1
(4,  15, 2),   -- Codéine 30mg x2
-- Prescription 5: Théo Blanc (enfant, fièvre)
(5,  1,  1),   -- Paracétamol 500mg x1
-- Prescription 6: Jeanne Faure (âgée, hypertension + diabète)
(6,  5,  2),   -- Metformine 500mg x2
(6,  16, 1),   -- Bisoprolol 5mg x1
(6,  11, 1),   -- Ramipril 5mg x1
-- Prescription 7: Noah Richard (grippe)
(7,  1,  3),   -- Paracétamol 500mg x3
(7,  4,  1),   -- Aspirine 500mg x1
-- Prescription 8: Catherine Girard (diabète type 2)
(8,  19, 2),   -- Metformine Forte 850mg x2
-- Prescription 9: Maxime Bonnet (angine)
(9,  2,  3),   -- Amoxicilline 250mg x3
-- Prescription 10: Émilie Fournier (allergie + asthme)
(10, 12, 1),   -- Cétirizine 10mg x1
(10, 18, 1),   -- Montelukast 10mg x1
-- Prescription 11: Emma Simon (reflux gastrique)
(11, 6,  1),   -- Oméprazole 20mg x1
-- Prescription 12: Jacques Morel (cardio chronique)
(12, 7,  1),   -- Amlodipine 10mg x1
(12, 16, 1),   -- Bisoprolol 5mg x1
(12, 8,  1),   -- Atorvastatine 40mg x1
-- Prescription 13: Raphaël Gauthier (douleur musculaire)
(13, 3,  2),   -- Ibuprofène 400mg x2
-- Prescription 14: Nathalie Perrin (hypertension)
(14, 11, 1),   -- Ramipril 5mg x1
(14, 16, 1),   -- Bisoprolol 5mg x1
-- Prescription 15: Tom Michel (infection urinaire)
(15, 17, 1),   -- Lévofloxacine 250mg x1
-- Prescription 16: Sarah David (anxiété + douleur)
(16, 20, 2),   -- Hydroxyzine 25mg x2
(16, 1,  2),   -- Paracétamol 500mg x2
-- Prescription 17: Marcel Lemaire (polypathologie âgé)
(17, 7,  1),   -- Amlodipine 10mg x1
(17, 8,  1),   -- Atorvastatine 40mg x1
(17, 5,  2),   -- Metformine 500mg x2
(17, 6,  1),   -- Oméprazole 20mg x1
-- Prescription 18: Léa Roux (enfant, otite)
(18, 2,  2),   -- Amoxicilline 250mg x2
(18, 1,  1),   -- Paracétamol 500mg x1
-- Prescription 19: Philippe Marchand (dépression + douleur)
(19, 9,  1),   -- Fluoxétine 20mg x1
(19, 10, 2),   -- Tramadol 50mg x2
-- Prescription 20: Camille Picard (allergie saisonnière)
(20, 12, 1),   -- Cétirizine 10mg x1
-- Prescription 21: Sébastien Renard (goutte)
(21, 14, 1),   -- Allopurinol 100mg x1
(21, 3,  1),   -- Ibuprofène 400mg x1
-- Prescription 22: Monique Caron (âgée, multiples)
(22, 7,  1),   -- Amlodipine 10mg x1
(22, 5,  2),   -- Metformine 500mg x2
(22, 6,  1),   -- Oméprazole 20mg x1
-- Prescription 23: Enzo Meunier (acné + allergie)
(23, 12, 1),   -- Cétirizine 10mg x1
-- Prescription 24: Laura Chevalier (migraine)
(24, 1,  2),   -- Paracétamol 500mg x2
(24, 15, 1),   -- Codéine 30mg x1
-- Prescription 25: François Lefebvre (cardio + goutte)
(25, 13, 1),   -- Clopidogrel 75mg x1
(25, 14, 1),   -- Allopurinol 100mg x1
(25, 8,  1),   -- Atorvastatine 40mg x1
-- Prescription 26: Isabelle Barbier (anxiété)
(26, 20, 1),   -- Hydroxyzine 25mg x1
-- Prescription 27: Kevin Nguyen (infection respiratoire)
(27, 2,  3),   -- Amoxicilline 250mg x3
(27, 1,  2),   -- Paracétamol 500mg x2
-- Anciennes prescriptions expirées
(28, 5,  1),   -- Jeanne Faure - ancienne
(28, 11, 1),
(29, 7,  1),   -- Marcel Lemaire - ancienne
(29, 5,  2),
(30, 7,  1),   -- Monique Caron - ancienne
(30, 6,  1);

-- --------------------------------------------------------
-- Table `Log`
-- --------------------------------------------------------

CREATE TABLE `Log` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `origin_user_id` int NOT NULL,
  `date` datetime NOT NULL,
  `field` varchar(100) NOT NULL,
  `action_type` varchar(50) NOT NULL DEFAULT 'OTHER',
  `element_id` int NOT NULL,
  `description` text,
  PRIMARY KEY (`log_id`),
  KEY `idx_date` (`date`),
  KEY `idx_origin_user` (`origin_user_id`),
  CONSTRAINT `Log_ibfk_1` FOREIGN KEY (`origin_user_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
