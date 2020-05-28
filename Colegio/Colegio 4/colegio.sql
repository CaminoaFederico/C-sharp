-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-11-2016 a las 18:37:17
-- Versión del servidor: 10.1.13-MariaDB
-- Versión de PHP: 5.6.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `guidogil`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `1º(primer grado)`
--

CREATE TABLE `1º(primer grado)` (
  `DNI` int(11) NOT NULL,
  `Apellido` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Teléfono` int(11) NOT NULL,
  `Grado` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Domicilio` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Fecha_de_nacimiento` date NOT NULL,
  `Lugar_de_nacimiento` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nacionalidad` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Responsable` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `2º(segundo grado)`
--

CREATE TABLE `2º(segundo grado)` (
  `DNI` int(11) NOT NULL,
  `Apellido` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Teléfono` int(11) NOT NULL,
  `Grado` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Domicilio` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Fecha_de_nacimiento` date NOT NULL,
  `Lugar_de_nacimiento` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nacionalidad` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Responsable` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `3º(tercer grado)`
--

CREATE TABLE `3º(tercer grado)` (
  `DNI` int(11) NOT NULL,
  `Apellido` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Teléfono` int(11) NOT NULL,
  `Grado` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Domicilio` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Fecha_de_nacimiento` date NOT NULL,
  `Lugar_de_nacimiento` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nacionalidad` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Responsable` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `4º(cuarto grado)`
--

CREATE TABLE `4º(cuarto grado)` (
  `DNI` int(11) NOT NULL,
  `Apellido` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Teléfono` int(11) NOT NULL,
  `Grado` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Domicilio` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Fecha_de_nacimiento` date NOT NULL,
  `Lugar_de_nacimiento` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nacionalidad` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Responsable` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `5º(quinto grado)`
--

CREATE TABLE `5º(quinto grado)` (
  `DNI` int(11) NOT NULL,
  `Apellido` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Teléfono` int(11) NOT NULL,
  `Grado` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Domicilio` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Fecha_de_nacimiento` date NOT NULL,
  `Lugar_de_nacimiento` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nacionalidad` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Responsable` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `6º(sexto grado)`
--

CREATE TABLE `6º(sexto grado)` (
  `DNI` int(11) NOT NULL,
  `Apellido` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Teléfono` int(11) NOT NULL,
  `Grado` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Domicilio` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Fecha_de_nacimiento` date NOT NULL,
  `Lugar_de_nacimiento` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nacionalidad` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Responsable` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `7º(septimo grado)`
--

CREATE TABLE `7º(septimo grado)` (
  `DNI` int(11) NOT NULL,
  `Apellido` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Teléfono` int(11) NOT NULL,
  `Grado` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Domicilio` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Fecha_de_nacimiento` date NOT NULL,
  `Lugar_de_nacimiento` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Nacionalidad` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Responsable` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentas`
--

CREATE TABLE `cuentas` (
  `DNI` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Cargo` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cuentas`
--

INSERT INTO `cuentas` (`DNI`, `Nombre`, `Apellido`, `Cargo`) VALUES
(11111111, 'Guido', '12345', 'puto'),
(22222222, 'Fede', 'Rico', 'puto');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personal`
--

CREATE TABLE `personal` (
  `DNI` int(11) NOT NULL,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Apellido` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Teléfono` int(11) NOT NULL,
  `Cargo` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `personal`
--

INSERT INTO `personal` (`DNI`, `Nombre`, `Apellido`, `Teléfono`, `Cargo`) VALUES
(235646, 'adgdgx', 'fgdfgsg', 57467453, 'sdgdrh'),
(2345235, 'asfsdgf', 'sdgdstr', 23426346, 'sdfsdg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tutores`
--

CREATE TABLE `tutores` (
  `DNI` int(11) NOT NULL,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Apellido` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Domicilio` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Fecha_de_nacimiento` date NOT NULL,
  `Nacionalidad` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Lugar_de_nacimiento` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Telefono` int(11) NOT NULL,
  `Celular` int(11) NOT NULL,
  `Numero_de_Trabajo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `tutores`
--

INSERT INTO `tutores` (`DNI`, `Nombre`, `Apellido`, `Domicilio`, `Fecha_de_nacimiento`, `Nacionalidad`, `Lugar_de_nacimiento`, `Telefono`, `Celular`, `Numero_de_Trabajo`) VALUES
(87984, 'sdgsag qfeff', 'ffffffffffffffff', 'fffffffffffffffffff', '2016-10-28', 'ffffffffffffffffffff', 'ffffffffff', 21022222, 23225555, 8988888),
(45564125, 'gfhjsdfjfg', 'hola', 'asfsadg23', '2016-10-20', 'arg', 'asfasdf', 23156489, 54814, 2156487);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `1º(primer grado)`
--
ALTER TABLE `1º(primer grado)`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Apellido` (`Apellido`),
  ADD KEY `Nombre` (`Nombre`),
  ADD KEY `Grado` (`Grado`),
  ADD KEY `Domicilio` (`Domicilio`,`Lugar_de_nacimiento`,`Nacionalidad`,`Responsable`);

--
-- Indices de la tabla `2º(segundo grado)`
--
ALTER TABLE `2º(segundo grado)`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Apellido` (`Apellido`),
  ADD KEY `Nombre` (`Nombre`),
  ADD KEY `Grado` (`Grado`),
  ADD KEY `Domicilio` (`Domicilio`,`Lugar_de_nacimiento`,`Nacionalidad`,`Responsable`);

--
-- Indices de la tabla `3º(tercer grado)`
--
ALTER TABLE `3º(tercer grado)`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Apellido` (`Apellido`),
  ADD KEY `Nombre` (`Nombre`),
  ADD KEY `Grado` (`Grado`),
  ADD KEY `Domicilio` (`Domicilio`,`Lugar_de_nacimiento`,`Nacionalidad`,`Responsable`);

--
-- Indices de la tabla `4º(cuarto grado)`
--
ALTER TABLE `4º(cuarto grado)`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Teléfono` (`Teléfono`),
  ADD KEY `Grado` (`Grado`),
  ADD KEY `Apellido` (`Apellido`),
  ADD KEY `Domicilio` (`Domicilio`,`Lugar_de_nacimiento`,`Nacionalidad`,`Responsable`);

--
-- Indices de la tabla `5º(quinto grado)`
--
ALTER TABLE `5º(quinto grado)`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Apellido` (`Apellido`),
  ADD KEY `Nombre` (`Nombre`),
  ADD KEY `Grado` (`Grado`),
  ADD KEY `Domicilio` (`Domicilio`,`Lugar_de_nacimiento`,`Nacionalidad`,`Responsable`);

--
-- Indices de la tabla `6º(sexto grado)`
--
ALTER TABLE `6º(sexto grado)`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Apellido` (`Apellido`),
  ADD KEY `Nombre` (`Nombre`),
  ADD KEY `Grado` (`Grado`),
  ADD KEY `Domicilio` (`Domicilio`,`Lugar_de_nacimiento`,`Nacionalidad`,`Responsable`);

--
-- Indices de la tabla `7º(septimo grado)`
--
ALTER TABLE `7º(septimo grado)`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Apellido` (`Apellido`),
  ADD KEY `Nombre` (`Nombre`),
  ADD KEY `Grado` (`Grado`),
  ADD KEY `Domicilio` (`Domicilio`,`Lugar_de_nacimiento`,`Nacionalidad`,`Responsable`);

--
-- Indices de la tabla `cuentas`
--
ALTER TABLE `cuentas`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Cargo` (`Cargo`);

--
-- Indices de la tabla `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Nombre` (`Nombre`),
  ADD KEY `Apellido` (`Apellido`),
  ADD KEY `Cargo` (`Cargo`),
  ADD KEY `Cargo_2` (`Cargo`);

--
-- Indices de la tabla `tutores`
--
ALTER TABLE `tutores`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `Nombre` (`Nombre`,`Apellido`,`Domicilio`,`Nacionalidad`,`Lugar_de_nacimiento`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
