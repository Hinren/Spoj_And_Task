<?php
require_once ('class_pojazd.php');
require_once ('Motocykl.php');

$moto=new Motocykl("Yamaha",25,6);
$moto->ustawPojemnoscBaku(20.5);
echo "Zasięg {$moto->pokazProducenta()} w teorii {$moto->obliczZasieg()} km";
?>