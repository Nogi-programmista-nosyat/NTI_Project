<?php
	sleep(1);
	$host = 'h004316863.mysql'; // адрес сервера 
	$database = 'h004316863_ngy'; // имя базы данных
	$user = 'h004316863_ngy'; // имя пользователя
	$password = 'admnhcx123XZ'; // пароль
	$mysqli = new mysqli($host, $user, $password, $database);
	$result = $mysqli->query("SELECT * FROM users where login = \"".$_POST['curlogin']."\" and password = \"".$_POST['curpassword']."\"");
	if($result->num_rows>0 && ($result->fetch_assoc())['perm_level']==3){
		$result = $mysqli->query("SELECT * FROM	 'users' where 'login' = \"".$_POST['login']."\"");
		if($result->num_rows>0)echo 0;
		else{
			$result = $mysqli->query("SELECT * FROM users where mail = \"".$_POST['mail']."\"");
			if($result->num_rows>0)echo 1;
			else{
				$query ="INSERT INTO `users` (`id`, `name`, `age`, `sex`, `position`, `experience`, `password`, `login`, `mail`, `perm_level`) VALUES (NULL, '".$_POST['name']."', '".$_POST['age']."', '".$_POST['sex']."', '".$_POST['position']."', '".$_POST['experience']."', '".$_POST['password']."', '".$_POST['login']."', '".$_POST['mail']."', '".$_POST['perm_level']."');";
				$mysqli->set_charset("utf8");
				$result = $mysqli->query($query);
				echo "OK";
			}
		}
	}else echo 0;
?>