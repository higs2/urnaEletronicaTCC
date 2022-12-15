-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 15-Dez-2022 às 02:23
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `urnadb`
--
CREATE DATABASE IF NOT EXISTS `urnadb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `urnadb`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastro`
--

CREATE TABLE `cadastro` (
  `id_user` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `curso` varchar(50) DEFAULT NULL,
  `foto` varchar(200) DEFAULT NULL,
  `votos` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadastro`
--

INSERT INTO `cadastro` (`id_user`, `nome`, `numero`, `curso`, `foto`, `votos`) VALUES
(1, 'HANIEL10', 1, 'TEM10', '\\image\\Captura de tela_20221102_185626.png', 3),
(2, 'HANIEL10', 2, 'TEM10', '\\image\\Captura de tela_20221102_185626.png', 2),
(3, 'HANIEL10', 3, 'TEM10', '\\image\\Captura de tela_20221102_185626.png', 0),
(4, 'HANIEL10', 4, 'TEM10', '\\image\\Captura de tela_20221102_185626.png', 3),
(5, 'HANIEL10', 10, 'TEM10', '\\image\\Captura de tela_20221102_185626.png', 0),
(8, 'HANIEL10', 22, 'TEM10', '\\image\\Captura de tela_20221102_185626.png', 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro`
--
ALTER TABLE `cadastro`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `numero` (`numero`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro`
--
ALTER TABLE `cadastro`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
