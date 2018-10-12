<?php

class Usuario{

    //Metodo registrar

    public function registrar($conexion, $nombre, $apellido, $documento, $fechaNaci){
        $query = "INSERT INTO usuario (nombre, apellido, documento, fecha_nacimiento) VALUES ('$nombre', '$apellido', $documento, 'fechaNaci')";
        $consulta = mysqli_query($conexion, $query);

        if($consulta){
            $respuesta = "Usuario registrado";
        }else{
            $respuesta = "Problemas al registrar";
        }

        return $respuesta;
    }

}