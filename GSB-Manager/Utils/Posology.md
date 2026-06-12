# Posologie des prescriptions — requêtes SQL

Requête liée à la précision de la posologie dans la table de liaison `Appartient`
(prescription ↔ médicament). Base de données : `GSB-Manager`.

- `posology_int` : quantité (ex : `2`)
- `posology_string` : période, enum `par_jour` ou `par_semaine`

---

## ALTER TABLE `Appartient` — ajout de la posologie

```sql
ALTER TABLE `Appartient`
  ADD COLUMN `posology_int` int DEFAULT NULL,
  ADD COLUMN `posology_string` enum('par_jour','par_semaine') DEFAULT NULL;
```

---

## Correctif si la colonne a déjà été créée en `varchar`

Si l'`ALTER` ci-dessus a déjà été exécuté avec `varchar`, passer la colonne en `enum` :

```sql
ALTER TABLE `Appartient`
  MODIFY COLUMN `posology_string` enum('par_jour','par_semaine') DEFAULT NULL;
```
