<?php
require_once ('zamowienia.php');




$data=time();
if($data>1519858800 && $data<1522533600){
Zamowienie::$cenaKm=1;
}

$zam=new Zamowienie(10);
echo "Koszt dostawy wynosi: {$zam->obliczTransport()} zł<br/>";
echo "Odleglość: {$zam->pobierzOdleglosc()} zł";










?>