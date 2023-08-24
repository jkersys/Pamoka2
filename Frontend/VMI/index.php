<?php

$conn = mysqli_connect('localhost', 'KVIRPA', 'kZakw9QWatP68PH5sJzT@orgs.vmi.lt', 'VMI');

if(!$conn){
   echo 'connection error: ' .mysqli_connect_error();}

?>



<?php

$servername = "10.246.12.17";
$username = "KVIRPA";
$password = "KVIRPA/kZakw9QWatP68PH5sJzT@orgs.vmi.lt";
$dbname = "VMI";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 


//$sql = "SELECT * FROM market";
//$result = $conn->query($sql);
//$row = $result->fetch_assoc();



$conn = null;
/* echo $row['eudol']; */

?>