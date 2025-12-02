#  GSB Manager — Application Desktop de Gestion Médicale

## 🧩 Description du projet

**GSB Manager** est une application **desktop C# (.NET Windows Forms)** développée pour le groupe **GSB (Galaxy Swiss Bourdin)**.
Ce logiciel a pour objectif de **centraliser et gérer les ordonnances**, les **patients**, les **médicaments** et les **utilisateurs (médecins, pharamaciens et administrateurs)**.

---

## ⚙️ Fonctionnalités principales

### 👤 Gestion des utilisateurs

* Connexion sécurisée (mot de passe haché SHA256)
* Rôles utilisateurs :

  * **Médecins** : création et gestion des ordonnances, patients et médicaments
  * **Administrateurs** : gestions des utilisateurs

### 🧍 Gestion des patients

* Création, consultation, modification et suppression de patients
* Informations stockées : nom, prénom, âge, genre, utilisateur associé (médecin référent)

### 💊 Gestion des médicaments

* Référencement des médicaments avec :

  * Nom
  * Description
  * Dosage
  * Molécule
  * Pharmacien référent

### 📜 Gestion des ordonnances

* Création de ordonnances liées à un patient et un médecin
* Ajout automatique des médicaments via la table de liaison **Appartient**
* Date de validité, quantité prescrite
---

## 🗃️ Structure de la base de données (MySQL)

| Table            | Description                                          | Colonnes principales                                                   |
| ---------------- | ---------------------------------------------------- | ---------------------------------------------------------------------- |
| **Users**        | Contient les comptes utilisateurs                    | `user_id`, `firstname`, `role`, `name`, `email`, `password`           |
| **Patients**     | Gère les informations patient                        | `patient_id`, `user_id`, `name`, `firstname`, `age`, `gender`        |
| **Medicine**     | Liste les médicaments disponibles                    | `medicine_id`, `user_id`, `name`, `description`, `dosage`, `molecule` |
| **Prescription** | Enregistre les prescriptions faites par les médecins | `prescription_id`, `user_id`, `patient_id`, `validity`   |
| **Appartient**   | Table de liaison entre `Prescription` et `Medicine`  | `prescription_id`, `medicine_id`, `quantity`                          |

---

## 🧱 Architecture du projet

```
GSB-Manager/
│
├── DAO                    → Accès aux données (Data Access Object)
│   ├── Database.cs        → Connexion à MySQL
│   ├── MedicineDAO.cs
│   ├── PatientDAO.cs
│   ├── PrescriptionDAO.cs
│   └── UserDAO.cs
├── Forms                  → Interfaces Windows Forms
│   ├── MainForm.Designer.cs
│   ├── MainForm.cs
│   ├── MainForm.resx
│   ├── UserForm.Designer.cs
│   ├── UserForm.cs
│   └── UserForm.resx
├── Models                 → Classes modèles (entités)
│   ├── Medicine.cs
│   ├── Patient.cs
│   ├── Prescription.cs
│   └── User.cs
|
├── GSB-Manager.csproj
├── GSB-Manager.csproj.user
├── GSB-Manager.sln
├── init.sql
├── Program.cs              → Point d’entrée principal
└── index.md               → Documentation du projet
```

| Classe              | Description                           | Méthodes clés                                                                        |
| ------------------- | ------------------------------------- | ------------------------------------------------------------------------------------ |
| **UserDAO**         | Gestion des utilisateurs              | `GetUserByEmail()`, `AuthenticateUser()`                                             |
| **PatientDAO**      | Gestion des patients                  | `GetPatientById()`, `CreatePatient()`, `GetAllPatients()`                            |
| **MedicineDAO**     | Gestion des médicaments               | `GetMedicineById()`, `GetAllMedicines()`                                             |
| **PrescriptionDAO** | Gestion des prescriptions et liaisons | `GetPrescriptionById()`, `CreatePrescription()`, `CreatePrescriptionWithMedicines()` |

---

## 💡 Exemple d’utilisation

```csharp
PrescriptionDAO dao = new PrescriptionDAO();
Prescription p = new Prescription(0, 1, 5, 2, "2025-12-01");
List<int> meds = new List<int> { 1, 3, 5 };

bool ok = dao.CreatePrescriptionWithMedicines(p, meds);
if (ok)
    MessageBox.Show("Prescription créée avec succès !");
else
    MessageBox.Show("Erreur lors de la création.");
```

---

## 🔐 Sécurité

* Les mots de passe utilisateurs sont **hachés en SHA256**
* Les interactions SQL utilisent des **requêtes paramétrées**
* Gestion des transactions pour les opérations critiques (`PrescriptionDAO`)

---

## 🧑‍💻 Auteur

* **[Pablo SCHNEIDER]**
* Projet réalisé dans le cadre de **GSB - BTS SIO**
* Année : **2025**