<?php
sleep(1);
$host = 'h004316863.mysql'; // адрес сервера 
$database = 'h004316863_ngy'; // имя базы данных
$user = 'h004316863_ngy'; // имя пользователя
$password = 'admnhcx123XZ'; // пароль
$mysqli = new mysqli($host, $user, $password, $database);
$query ="SELECT * FROM users where login = \"".$_POST['login']."\" and password = \"".$_POST['password']."\"";
//echo $_POST['login']." ".$_POST['password'];
$mysqli->set_charset("utf8");
$result = $mysqli->query($query);
$myArray = array();
if($result->num_rows==0)
{
    echo 0;
} 
else{
	$query ="SELECT * FROM crit_param where 1";
	$result = $mysqli->query($query);
	$myArray = array();
	while($row = $result->fetch_array(MYSQLI_ASSOC)) {
            $myArray[] = $row;
    }
	echo json_encode($myArray);
}
?>