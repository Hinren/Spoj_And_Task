<?php

class Motocykl extends Pojazd{
private $_producent;

function __construct($producent,$bak,$spalanie){
parent::__construct($bak,$spalanie);
$this->_producent=$producent;

}

function wprowadzProducenta($producent){

$this->_producent=$producent;
}
function pokazProducenta(){

return $this->_producent;
}
}









?>