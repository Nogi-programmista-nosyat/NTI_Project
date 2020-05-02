<?php
$host = 'h004316863.mysql'; // адрес сервера 
$database = 'h004316863_ngy'; // имя базы данных
$user = 'h004316863_ngy'; // имя пользователя
$password = 'admnhcx123XZ'; // пароль
 
$link = mysqli_connect($host, $user, $password, $database) 
    or die("Ошибка " . mysqli_error($link));
 
$query ="SELECT 'name' FROM `employees`";
$result = mysqli_query($link, $query) or die("Ошибка " . mysqli_error($link)); 
if($result)
{
    echo $_POST['user'];
}
 
mysqli_close($link);
?>