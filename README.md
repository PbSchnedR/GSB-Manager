# GSB Manager - Guide d'Utilisation

![C#](https://img.shields.io/badge/C%23-11.0-blue?logo=c-sharp)
![.NET](https://img.shields.io/badge/.NET-6.0-blueviolet?logo=.net)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-WinForms-blue)
![MySQL](https://img.shields.io/badge/MySQL-8.1-orange?logo=mysql)
![Docker](https://img.shields.io/badge/Docker-Powered-blue?logo=docker)

---

## 📋 À Propos

**GSB Manager** est une application de bureau Windows destinée à la gestion des données médicales pour le laboratoire Galaxy Swiss Bourdin (GSB). Elle permet aux médecins et pharmaciens de gérer patients, médicaments et prescriptions de manière centralisée et sécurisée.

**Auteur** : Pablo Schneider  
**Année** : 2025  
**Contexte** : BTS SIO - Projet GSB

---

## 🚀 Installation

### Prérequis
- **Windows 10/11** (64 bits)
- **Docker Desktop** installé et lancé
- **.NET 8.0 SDK** ([télécharger](https://dotnet.microsoft.com/download/dotnet/8.0))
- **Visual Studio 2022** avec le workload "Développement desktop .NET"

### Procédure d'Installation

1. **Cloner le dépôt**
   ```bash
   git clone https://github.com/PbSchnedR/GSB-Manager
   cd GSB-Manager
   ```

2. **Lancer la base de données**
   ```bash
   docker-compose up -d
   ```
   Cela démarre un conteneur MySQL (port `3306`) et un phpMyAdmin. Le dump SQL (`init.sql`) est importé automatiquement au premier lancement.

3. **Vérifier que tout tourne**
   ```bash
   docker ps
   ```
   Vous devriez voir `gsb_mysql_db` et `gsb_phpmyadmin`.

4. **Ouvrir le projet**
   - Double-cliquer sur **`GSB-Manager.sln`** à la racine du projet
   - Appuyer sur **F5** pour lancer l'application

   Ou en ligne de commande :
   ```bash
   dotnet restore
   dotnet run --project GSB-Manager
   ```

> ⚠️ **Important :** Le port configuré dans `GSB-Manager/DAO/Database.cs` doit correspondre à celui exposé dans `docker-compose.yml` (par défaut `3306`).

### Accès phpMyAdmin
- URL : **http://localhost:8080**
- Utilisateur : `root`
- Mot de passe : `root`

### Réinitialiser la base de données
```bash
docker-compose down -v
docker-compose up -d
```

---

## 🔐 Première Connexion

### Identifiants de Test

Tous les comptes ont le mot de passe : **`password`**

| Rôle            | Email                      |
|-----------------|----------------------------|
| Administrateur  | paul.martin@example.com    |
| Administrateur  | hugo.petit@example.com     |
| Administrateur  | lucas.benoit@example.com   |
| Médecin/Pharma  | claire.durand@example.com  |
| Médecin/Pharma  | sophie.moreau@example.com  |
| Médecin/Pharma  | nicolas.leroy@example.com  |
| Médecin/Pharma  | emma.fontaine@example.com  |

> 🔒 **Sécurité** : Les mots de passe sont hashés en SHA-256 dans la base de données.

---

## 📖 Guide d'Utilisation

### Interface Principale

Une fois connecté, l'application affiche une interface à onglets avec les modules suivants :

#### 1️⃣ **Onglet Medicines (Médicaments)**

**Fonctionnalités disponibles :**
- 📋 **Consulter** : Liste de tous les médicaments disponibles
- ➕ **Ajouter** : Créer un nouveau médicament (pharmaciens)
- ✏️ **Modifier** : Mettre à jour les informations d'un médicament
- 🗑️ **Supprimer** : Retirer un médicament du catalogue

**Comment utiliser :**
1. Sélectionnez un médicament dans la liste de droite
2. Les détails s'affichent dans le panneau de gauche
3. Utilisez les boutons `Add`, `Edit`, `Delete` pour effectuer des actions

---

#### 2️⃣ **Onglet Prescriptions (Ordonnances)**

**Fonctionnalités disponibles :**
- 📋 **Consulter** : Historique des prescriptions
- ➕ **Créer** : Nouvelle prescription pour un patient
- ✏️ **Modifier** : Mettre à jour une prescription existante
- 🗑️ **Supprimer** : Annuler une prescription
- 📄 **Générer PDF** : Exporter l'ordonnance au format PDF

**Comment créer une prescription :**
1. Cliquez sur `Add`
2. Sélectionnez un patient dans la liste déroulante
3. Ajoutez des médicaments avec quantités
4. Définissez la date de validité
5. Cliquez sur `Register`

---

#### 3️⃣ **Onglet Patients**

**Fonctionnalités disponibles :**
- 📋 **Consulter** : Liste de tous vos patients (médecins uniquement)
- ➕ **Ajouter** : Créer une nouvelle fiche patient
- ✏️ **Modifier** : Mettre à jour les informations d'un patient
- 🗑️ **Supprimer** : Retirer un patient du système

---

#### 4️⃣ **Onglet Manager (Gestion des Utilisateurs)**

> ⚠️ **Réservé aux administrateurs uniquement (role 1)**

**Fonctionnalités disponibles :**
- 👥 **Consulter** : Liste de tous les utilisateurs du système
- ➕ **Ajouter** : Créer un nouveau compte utilisateur
- ✏️ **Modifier** : Mettre à jour les informations d'un utilisateur
- 🗑️ **Supprimer** : Désactiver un compte utilisateur

---

## 🔧 Fonctionnalités Techniques

### Base de Données
- **Type** : MySQL 8.1
- **Hébergement** : Local via Docker
- **Administration** : phpMyAdmin sur http://localhost:8080

### Sécurité
- ✅ Authentification par email et mot de passe
- ✅ Hachage SHA-256 des mots de passe
- ✅ Prévention des injections SQL (requêtes paramétrées)
- ✅ Gestion des droits d'accès par rôle
- ✅ Journalisation des actions (table Log)

### Architecture N-Tier
- **Couche Présentation** : Windows Forms (.NET 6)
- **Couche Métier** : Classes modèles (User, Patient, Medicine, Prescription)
- **Couche Données** : DAO (Data Access Objects)

### Schéma de la Base de Données

| Table | Description |
|-------|------------|
| `Users` | Utilisateurs (médecins, pharmaciens, admins) |
| `Patients` | Fiches patients rattachées à un médecin |
| `Medicine` | Catalogue des médicaments |
| `Prescription` | Ordonnances (médecin → patient) |
| `Appartient` | Liaison prescription ↔ médicament (avec quantité) |
| `Log` | Journal des actions utilisateurs |

Toutes les clés étrangères sont en **cascade** : la suppression d'un utilisateur entraîne la suppression de ses patients, prescriptions, médicaments et logs associés.

---

## ❓ FAQ

**Q : L'application ne se connecte pas à la base**  
R : Vérifiez que Docker tourne (`docker ps`) et que le port dans `Database.cs` correspond à celui du `docker-compose.yml` (par défaut `3306`).

**Q : Je ne peux pas me connecter**  
R : Le mot de passe par défaut est `password` pour tous les comptes de test.

**Q : Je ne vois pas certains onglets**  
R : Les onglets dépendent de votre rôle :
- **Médecins/Pharmaciens (role 0)** : Medicines, Prescriptions, Patients
- **Administrateurs (role 1)** : Tous les onglets + Manager

**Q : Les tables sont vides après un redémarrage Docker**  
R : Les données persistent grâce au volume Docker. Si vous avez fait `docker-compose down -v`, le dump sera réimporté au prochain `up -d`.
