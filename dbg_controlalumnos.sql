/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50649
Source Host           : localhost:3306
Source Database       : dbg_controlalumnos

Target Server Type    : MYSQL
Target Server Version : 50649
File Encoding         : 65001

Date: 2023-02-14 18:17:59
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for alumnosadulto
-- ----------------------------
DROP TABLE IF EXISTS `alumnosadulto`;
CREATE TABLE `alumnosadulto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(255) NOT NULL,
  `dni` varchar(15) NOT NULL,
  `celular` varchar(15) DEFAULT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `polo` varchar(10) DEFAULT NULL,
  `ubicacionImagen` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `dni` (`dni`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of alumnosadulto
-- ----------------------------
INSERT INTO `alumnosadulto` VALUES ('1', 'yossec', '75148266', '939925891', 'jr: miguel grau #255', 'no', null);
INSERT INTO `alumnosadulto` VALUES ('2', 'sandra', '22521464', '962534121', 'asfhsafhjasfgasfgasf', 'no', null);
INSERT INTO `alumnosadulto` VALUES ('3', 'ricardo pillco', '78945612', '789456123', 'jr: miguel grau 255', 'si', null);

-- ----------------------------
-- Table structure for alumnosniños
-- ----------------------------
DROP TABLE IF EXISTS `alumnosniños`;
CREATE TABLE `alumnosniños` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(255) NOT NULL,
  `dni` varchar(15) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `celularMadre` varchar(15) NOT NULL,
  `celularPadre` varchar(15) NOT NULL,
  `dniPadre` varchar(15) NOT NULL,
  `nombrePadre` varchar(15) NOT NULL,
  `fechaNacimiento` date NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `dni` (`dni`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of alumnosniños
-- ----------------------------

-- ----------------------------
-- Table structure for dia
-- ----------------------------
DROP TABLE IF EXISTS `dia`;
CREATE TABLE `dia` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `dia` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `dia` (`dia`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of dia
-- ----------------------------

-- ----------------------------
-- Table structure for tipoentrenamientodia
-- ----------------------------
DROP TABLE IF EXISTS `tipoentrenamientodia`;
CREATE TABLE `tipoentrenamientodia` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idTipoEntrenamiento` int(11) NOT NULL,
  `idDia` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `tipoEntrenamientoDia_fk0` (`idTipoEntrenamiento`),
  KEY `tipoEntrenamientoDia_fk1` (`idDia`),
  CONSTRAINT `tipoEntrenamientoDia_fk0` FOREIGN KEY (`idTipoEntrenamiento`) REFERENCES `tiposentrenamiento` (`id`),
  CONSTRAINT `tipoEntrenamientoDia_fk1` FOREIGN KEY (`idDia`) REFERENCES `dia` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tipoentrenamientodia
-- ----------------------------

-- ----------------------------
-- Table structure for tiposentrenamiento
-- ----------------------------
DROP TABLE IF EXISTS `tiposentrenamiento`;
CREATE TABLE `tiposentrenamiento` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `entrenamiento` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tiposentrenamiento
-- ----------------------------

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(255) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `usuario` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of usuarios
-- ----------------------------

-- ----------------------------
-- Procedure structure for registrar_adulto
-- ----------------------------
DROP PROCEDURE IF EXISTS `registrar_adulto`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrar_adulto`(IN _dni varchar(15),in _name varchar(255),in _cel varchar(15),in _dir varchar(255))
BEGIN
INSERT INTO `alumnosadulto` (`nombres`, `dni`, `celular`, `direccion`) VALUES (_name, _dni, _cel, _dir);
END
;;
DELIMITER ;
