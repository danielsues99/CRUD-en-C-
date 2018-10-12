<?php

//Clase para conectar

class conexion{     

    public function conectar (){
    
        //variables para la conexion a la BD
        $host = "localhost";
        $user = "root";
        $passwor = "root";
        $db = "usuario";
        $conexion = new mysqli($host, $user, $passwor, $db);
        
        if($conexion == false){
            die("ERROR".mysqli_connect_error);    
        }

        return $conexion;
    }

}