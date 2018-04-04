<?php

class Pojazd{
private $_pojemnoscBaku;
private $_spalanie;
//private $zasieg;

public function __construct($bak,$spal){
	$this->_pojemnoscBaku=$bak;
	$this->_spalanie=$spal;
}

public function ustawPojemnoscBaku($bak){
	$this->_pojemnoscBaku=$bak;
}

function obliczZasieg(){
	/*$this->$zasieg=*/return ($this->_pojemnoscBaku/$this->_spalanie)*100;
}

}








?>