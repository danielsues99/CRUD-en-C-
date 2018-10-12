<?php

// Instancias de otra clase

include '../clases/conexion.php';
include '../clases/usuario.php';

$objConexion = new conexion();
$conexion = $objConexion->conectar();

$objUsuario = new Usuario();

echo $objUsuario->resgistrar($conexion, $_POST['nombre'], $_POST['apellido'], $_POST['documento'], $_POST['fechaNacimiento']);