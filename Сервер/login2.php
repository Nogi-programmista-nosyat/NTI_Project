<?php
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
	echo "[";
	while($row = $result->fetch_array(MYSQLI_ASSOC)) {
            $myArray[] = $row;
			echo "{\"id\":\"".$row['id']."\",\"name\":\"".$row['name']."\",\"sex\":\"".$row['sex']."\",\"position\":\"".$row['position']."\",\"experience\":\"".$row['experience']."\",\"password\":\"".$row['password']."\",\"login\":\"".$row['login']."\",\"perm_level\":\"".$row['perm_level']."\"}";
    }
    echo "]";
}
?>