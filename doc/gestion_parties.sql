-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 24 mai 2023 à 08:23
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion_parties`
--

-- --------------------------------------------------------

--
-- Structure de la table `events`
--

CREATE TABLE `events` (
  `evt_id` int(11) NOT NULL,
  `evt_date` date NOT NULL,
  `evt_name` varchar(100) NOT NULL,
  `evt_location` varchar(100) NOT NULL,
  `evt_status` enum('Visible','Caché') NOT NULL,
  `evt_max_morning_games` int(11) NOT NULL,
  `evt_max_afternoon_games` int(11) NOT NULL,
  `evt_max_evening_games` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `events`
--

INSERT INTO `events` (`evt_id`, `evt_date`, `evt_name`, `evt_location`, `evt_status`, `evt_max_morning_games`, `evt_max_afternoon_games`, `evt_max_evening_games`) VALUES
(1, '2023-05-25', 'Tournoi Fifa', 'Chemin d\'aux 20, 1205 Genève\r\n', 'Visible', 12, 12, 12),
(2, '2023-05-24', 'Tournoi RL', 'Chemin d\'aux 12, 1205 Genève', 'Visible', 5, 5, 5);

-- --------------------------------------------------------

--
-- Structure de la table `games`
--

CREATE TABLE `games` (
  `gme_id` int(11) NOT NULL,
  `gme_name` varchar(100) NOT NULL,
  `gme_period` enum('Matin','Après-midi','Soir') NOT NULL,
  `gme_description` varchar(100) NOT NULL,
  `gme_image` blob NOT NULL,
  `gme_min_players` int(11) NOT NULL,
  `gme_max_players` int(11) NOT NULL,
  `gme_price` int(11) NOT NULL,
  `gme_mj_usr_id` int(11) NOT NULL,
  `gme_evt_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `players`
--

CREATE TABLE `players` (
  `plr_usr_id` int(11) NOT NULL,
  `plr_gme_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `usr_id` int(11) NOT NULL,
  `usr_first_name` varchar(100) NOT NULL,
  `usr_last_name` varchar(100) NOT NULL,
  `usr_phone` varchar(20) NOT NULL,
  `usr_email` varchar(100) NOT NULL,
  `usr_pseudo` varchar(30) NOT NULL,
  `usr_password` varchar(50) NOT NULL,
  `usr_status` enum('actif','inactif') NOT NULL,
  `usr_role` enum('Admin','Joueur','MJ à valider','MJ') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`usr_id`, `usr_first_name`, `usr_last_name`, `usr_phone`, `usr_email`, `usr_pseudo`, `usr_password`, `usr_status`, `usr_role`) VALUES
(1, 'kevin', 'flplm', '0776239484', 'kevin.flplm@eduge.ch', 'admin', 'Super2022', 'actif', 'Admin');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`evt_id`);

--
-- Index pour la table `games`
--
ALTER TABLE `games`
  ADD PRIMARY KEY (`gme_id`),
  ADD KEY `gme_mj_usr_id` (`gme_mj_usr_id`,`gme_evt_id`),
  ADD KEY `gme_evt_id` (`gme_evt_id`);

--
-- Index pour la table `players`
--
ALTER TABLE `players`
  ADD KEY `plr_usr_id` (`plr_usr_id`,`plr_gme_id`),
  ADD KEY `plr_gme_id` (`plr_gme_id`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`usr_id`),
  ADD KEY `usr_id` (`usr_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `events`
--
ALTER TABLE `events`
  MODIFY `evt_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `games`
--
ALTER TABLE `games`
  MODIFY `gme_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `users`
--
ALTER TABLE `users`
  MODIFY `usr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `games`
--
ALTER TABLE `games`
  ADD CONSTRAINT `games_ibfk_1` FOREIGN KEY (`gme_mj_usr_id`) REFERENCES `users` (`usr_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `games_ibfk_2` FOREIGN KEY (`gme_evt_id`) REFERENCES `events` (`evt_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `players`
--
ALTER TABLE `players`
  ADD CONSTRAINT `players_ibfk_1` FOREIGN KEY (`plr_usr_id`) REFERENCES `users` (`usr_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `players_ibfk_2` FOREIGN KEY (`plr_gme_id`) REFERENCES `games` (`gme_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
