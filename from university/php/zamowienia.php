<?php
class Zamowienie{

private $odleglosc;
public static $cenaKm=2;

public function __construct($odl){
$this->odleglosc=$odl;
}

function pobierzOdleglosc(){
return $this->odleglosc;

}

function obliczTransport() {

return $this->odleglosc*self::$cenaKm;


}
}

?>