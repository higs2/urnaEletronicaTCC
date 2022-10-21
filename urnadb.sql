-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Out-2022 às 02:07
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 8.0.13

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
(1, 'Recristalização', 1, 'Química', 'C:\\Users\\LAB-16\\Downloads\\ferramentas-quimicas.png', 0),
(2, 'O Poder Bélico', 2, 'Ensino Médio', 'C:\\Users\\LAB-16\\Desktop\\135151-004-0D4D550E.jpg', 0),
(3, 'Lâmpada de Lava', 3, 'Química', 'C:\\Users\\LAB-16\\Downloads\\31c9668127c2b883d1d6e42ca8e73c96.png', 0),
(4, 'Máquina de Sorvete', 4, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\produtora-de-sorvete-soft-psoft-500.png', 0),
(5, 'Narcóticos', 5, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\Narcoticos.jpg', 0),
(6, 'Essencial', 6, 'Química', 'C:\\Users\\LAB-16\\Downloads\\curaplantasbanner.jpg', 0),
(7, 'Queimaduras', 7, 'Enfermagem', 'C:\\Users\\LAB-16\\Downloads\\queimaduras_1-1.jpg', 0),
(8, 'Diabete', 8, 'Enfermagem', 'C:\\Users\\LAB-16\\Downloads\\960x720-11-2.png', 0),
(9, 'Doenças Sexualmente Transmissíveis', 9, 'Enfermagem', 'C:\\Users\\LAB-16\\Downloads\\DST-1.jpg', 0),
(10, 'Anti-Mofo', 10, 'Química', 'C:\\Users\\LAB-16\\Downloads\\anti-mofo-preventivo-allchem-900ml.png', 0),
(11, 'Inteligência Artificial', 11, 'Informática', 'C:\\Users\\LAB-16\\Downloads\\Artificial-intelligence-amico-2.png', 0),
(12, 'Saúde Mental', 12, 'Enfermagem', 'C:\\Users\\LAB-16\\Downloads\\dia-mundial-da-saude-mental.jpeg', 0),
(13, 'Corrida de Led', 13, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\Hero_Shot_Avatars_copy.jpg', 0),
(14, 'A Arte e Ciência', 14, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\da.jpg', 0),
(15, 'Manobra de Heimlich', 15, 'Enfermagem', 'C:\\Users\\LAB-16\\Downloads\\hwkb17_028.jpeg', 0),
(16, 'Braquistócrona', 16, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\download.png', 0),
(17, 'Aloína', 18, 'Química', 'C:\\Users\\LAB-16\\Downloads\\daf.jpg', 0),
(18, 'Investigação Criminal', 19, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\8f62cba2944bead08a1c4987ca1825b8.jpg', 0),
(19, 'Eletrônica e Segurança no Trabalho', 20, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\Projeto-de-Energia-Solar-Residencial-Quanto-Custa-4-Erros-Comuns-752x440.jpg', 0),
(20, 'Evolução Tecnológica da Cozinha', 21, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\09-the-100-year-evolution-of-9-kitchen-appliances-stove_resize_md.png', 0),
(21, 'MEI', 22, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\download (1).png', 0),
(22, 'Cancer de Mama', 23, 'Enfermagem', 'C:\\Users\\LAB-16\\Downloads\\images.jpg', 0),
(23, 'Realidade Virtual', 24, 'Informática', 'C:\\Users\\LAB-16\\Downloads\\i332959.jpeg', 0),
(24, 'Liptint', 25, 'Química', 'C:\\Users\\LAB-16\\Downloads\\liptint-amp_card-1.jpg', 0),
(25, 'Densidade ', 26, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\densidade-o-que-e-como-e-formada-forma-de-calcular-e-medidas.jpg', 0),
(26, 'Acidente Domiciliar na Infância', 27, 'Enfermagem', 'C:\\Users\\LAB-16\\Downloads\\bg1.png', 0),
(27, 'Câncer', 28, 'Enfermagem', 'C:\\Users\\LAB-16\\Downloads\\imagem-site-combate-ao-cancer.jpg', 0),
(28, 'Como Criamos Uma Pandemia', 29, 'Ensino Médico', 'C:\\Users\\LAB-16\\Downloads\\PANDEMIA-X-ENDEMIA--1024x766.jpg', 0),
(29, 'Interface Cérebro Máquina', 30, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\010180210809-riscos-interfaces-neurais-1.jpg', 0),
(30, 'Química Forense', 31, 'Química', 'C:\\Users\\LAB-16\\Downloads\\quimica-forense.jpg', 0),
(31, 'Despoluição da Água', 33, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\processos-de-despoluicao-2.jpeg', 0),
(32, 'Cinema', 34, 'Ensino Médio', 'C:\\Users\\LAB-16\\Downloads\\cinema-CRED-iStock_Roman-Valiev.jpg', 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro`
--
ALTER TABLE `cadastro`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro`
--
ALTER TABLE `cadastro`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
