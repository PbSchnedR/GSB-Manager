# GSB Manager - Guide d'Utilisation

![C#](https://img.shields.io/badge/C%23-11.0-blue?logo=c-sharp)
![.NET](https://img.shields.io/badge/.NET-6.0-blueviolet?logo=.net)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-WinForms-blue)
![MySQL](https://img.shields.io/badge/MySQL-8.1-orange?logo=mysql)
![AWS RDS](https://img.shields.io/badge/AWS-RDS_Aurora-orange?logo=amazon-aws)

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
- **Connexion Internet** (pour l'accès à la base de données AWS)

### Procédure d'Installation

1. **Télécharger l'application**
   - Téléchargez le fichier `GSB-Manager.exe` depuis la section [Releases](#)
   - Aucune installation n'est requise - l'application est portable

2. **Lancer l'application**
   - Double-cliquez sur `GSB-Manager.exe`
   - La fenêtre de connexion s'affiche automatiquement

> ℹ️ **Note** : La base de données est hébergée sur AWS RDS Aurora et est accessible automatiquement. Aucune configuration locale n'est nécessaire.

---

## 🔐 Première Connexion

### Identifiants de Test

Pour vous connecter à l'application, utilisez l'un des comptes suivants :

| Rôle            | Email                      | Mot de passe |
|-----------------|----------------------------|--------------|
| Administrateur  | paul.martin@example.com    | password     |
| Médecin/Pharma  | claire.durand@example.com  | password     |
| Administrateur  | hugo.petit@example.com     | password     |
| Administrateur  | lucas.benoit@example.com   | password     |

> 🔒 **Sécurité** : Les mots de passe sont hashés en SHA-256 dans la base de données.

---

## 📖 Guide d'Utilisation

### Interface Principale

Une fois connecté, l'application affiche une interface à onglets avec les modules suivants :

#### 1️⃣ **Onglet Medicines (Médicaments)**

**Fonctionnalités disponibles :**
- 📋 **Consulter** : Liste de tous les médicaments disponibles
- ➕ **Ajouter** : Créer un nouveau médicament (pharmaciens)
  - Nom du médicament
  - Description
  - Dosage
  - Molécule active
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
  - Sélection du patient
  - Ajout d'un ou plusieurs médicaments avec quantités
  - Date de validité
- ✏️ **Modifier** : Mettre à jour une prescription existante
- 🗑️ **Supprimer** : Annuler une prescription
- 📄 **Générer PDF** : Exporter l'ordonnance au format PDF

**Comment créer une prescription :**
1. Cliquez sur le bouton `Add`
2. Sélectionnez un patient dans la liste déroulante
3. Ajoutez des médicaments via le tableau :
   - Sélectionnez un médicament
   - Indiquez la quantité
   - Ajoutez à la liste
4. Définissez la date de validité
5. Cliquez sur `Register` pour enregistrer

> 💡 **Astuce** : Le bouton `Generate PDF` permet d'imprimer ou d'envoyer l'ordonnance au patient.

---

#### 3️⃣ **Onglet Patients**

**Fonctionnalités disponibles :**
- 📋 **Consulter** : Liste de tous vos patients (médecins uniquement)
- ➕ **Ajouter** : Créer une nouvelle fiche patient
  - Nom et prénom
  - Âge
  - Genre
- ✏️ **Modifier** : Mettre à jour les informations d'un patient
- 🗑️ **Supprimer** : Retirer un patient du système

**Comment ajouter un patient :**
1. Cliquez sur `Add`
2. Remplissez le formulaire dans le panneau de gauche :
   - Nom
   - Prénom
   - Âge
   - Genre (liste déroulante)
3. Cliquez sur `Register`

---

#### 4️⃣ **Onglet Manager (Gestion des Utilisateurs)**

> ⚠️ **Réservé aux administrateurs uniquement (role 1)**

**Fonctionnalités disponibles :**
- 👥 **Consulter** : Liste de tous les utilisateurs du système
- ➕ **Ajouter** : Créer un nouveau compte utilisateur
  - Nom, prénom, email
  - Mot de passe
  - Rôle (0 = Médecin/Pharmacien, 1 = Administrateur)
- ✏️ **Modifier** : Mettre à jour les informations d'un utilisateur
- 🗑️ **Supprimer** : Désactiver un compte utilisateur

---

## 🎨 Adaptation de l'Interface

L'application est **responsive** et s'adapte automatiquement à la taille de votre écran :
- Redimensionnez la fenêtre selon vos besoins
- Tous les éléments (textes, boutons, tableaux) gardent leurs proportions
- Taille minimale recommandée : 800x600 pixels

---

## 🔧 Fonctionnalités Techniques

### Base de Données
- **Type** : MySQL 8.1
- **Hébergement** : AWS RDS Aurora (cloud)
- **Connexion** : Automatique et sécurisée

### Sécurité
- ✅ Authentification par email et mot de passe
- ✅ Hachage SHA-256 des mots de passe
- ✅ Prévention des injections SQL (requêtes paramétrées)
- ✅ Gestion des droits d'accès par rôle

### Architecture
- **Couche Présentation** : Windows Forms (.NET 6)
- **Couche Métier** : Classes modèles (User, Patient, Medicine, Prescription)
- **Couche Données** : DAO (Data Access Objects)

---

## ❓ FAQ

**Q : L'application ne se lance pas**  
R : Vérifiez que vous disposez d'une connexion Internet active et que Windows Defender n'a pas bloqué l'exécutable.

**Q : Je ne peux pas me connecter**  
R : Assurez-vous d'utiliser l'un des identifiants de test fournis ci-dessus. Le mot de passe par défaut est `password`.

**Q : Je ne vois pas certains onglets**  
R : Les onglets visibles dépendent de votre rôle :
- **Médecins/Pharmaciens (role 0)** : Medicines, Prescriptions, Patients
- **Administrateurs (role 1)** : Tous les onglets + Manager pour gérer les utilisateurs

**Q : Puis-je utiliser l'application hors ligne ?**  
R : Non, une connexion Internet est requise pour accéder à la base de données AWS RDS.

**Q : Comment exporter une prescription ?**  
R : Sélectionnez une prescription dans l'onglet Prescriptions et cliquez sur `Generate PDF`. Le fichier sera enregistré sur votre ordinateur.
