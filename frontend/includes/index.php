<?php
$apiUrl = 
"http://localhost:5000/api/storage";
$jsonData=
file_get_contents{$apiUrl};
$tanks = json_decode($jsonData, 
true);
?>

<!DOCTYPE html>
<html lang="en">
 <head>
<link rel="stylesheet" href="css/style.css">
 </head>   
<body>
  <?php include 'includes/header.php';?>

<main class="dashboard-grid">
 <?php foreach($tanks as $tank): ?>
<div class= "status-card" <?php echo strtolower($tank['status']); ?>">
 <h1><?php echo htmlspecialchars($tank['tank name']
  
<p>Capacity: <?php echo $tank['currentCapacity']; ?>
 <span class ="badge"> <?php echo = htmlspecialchars($tank['status']); ?></span>   
  </div>
 <? php endforeach; ?>
 </main>
 </body>
 </html>

  




     
