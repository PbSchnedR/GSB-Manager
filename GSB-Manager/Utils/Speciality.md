# Spécialités des médecins — requêtes SQL

Requêtes liées à la fonctionnalité « spécialité » des médecins (table `Speciality` + clé étrangère sur `Users`).
Base de données : `GSB-Manager`.

---

## 1. Création de la table `Speciality`

```sql
CREATE TABLE `Speciality` (
  `speciality_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`speciality_id`)
)
```

---

## 2. Ajout de la clé étrangère `speciality_id` sur `Users` (ALTER)

```sql
ALTER TABLE `Users`
  ADD COLUMN `speciality_id` int DEFAULT NULL,
  ADD KEY `speciality_id` (`speciality_id`),
  ADD CONSTRAINT `Users_ibfk_speciality`
    FOREIGN KEY (`speciality_id`) REFERENCES `Speciality` (`speciality_id`)
    ON DELETE SET NULL ON UPDATE RESTRICT;
```

> `ON DELETE SET NULL` : si une spécialité est supprimée, le médecin associé la perd
> mais n'est pas supprimé.

---

## 3. Insertion de spécialités

```sql
INSERT INTO `Speciality` (`name`) VALUES
('Médecine générale'),
('Psychologie'),
('Cardiologie'),
('Dermatologie'),
('Pédiatrie'),
('Psychiatrie'),
('Neurologie');
```

### Ajouter une seule spécialité

```sql
INSERT INTO `Speciality` (`name`) VALUES ('Ophtalmologie');
```

### Affecter une spécialité à un médecin existant

```sql
UPDATE `Users` SET `speciality_id` = 2 WHERE `user_id` = 5;
```
