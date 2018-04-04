<!doctype html>
<html>
	<head>
	<meta charset="UTF-8" />
	<style type="text/css">
	body {
		font-family: sans-serif;
		font-size: 16px;
	}
	th,td {
		padding: 7px;
	}
	th {
		color: white;
		background-color: #222222;
	}
	</style>
	</head>
	<body>
<form><fieldset style="display: inline-block;"><legend>Parametry tabeli</legend>
	<table><tr><td>Rozmiar (wiersz x kolumna)</td><td>
	<input type="text" size="3" maxlength="3" /> 
	<input type="text" size="3" maxlength="3" /></td></tr>
	<tr><td>Modyfikacje:</td><td>
	<input type="radio" />Brak<br />
	<input type="radio" />Parzyste wiersze na niebiesko<br />
	<input type="radio" />Po przekątnej na czerwono (nr wiersza=nr kolumny)</td></tr>
	<tr><td colspan="2"><input type="submit" value="Generuj tabelę" /></td></tr>
	</table></fieldset></form>
	</body>
</html>