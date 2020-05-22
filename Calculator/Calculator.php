<!DOCTYPE html>
<html>
<head>
	<title>Máy tính</title>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
  	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
  	<script type="text/javascript">
  		function insert(num){
  			document.form.textview.value = document.form.textview.value + num;
  		}
  		function equal(){
  			var exp = document.form.textview.value;
  			if(exp){
  				document.form.textview.value = eval(exp);
  			}
  		}
  		function del(){
  			document.form.textview.value = "";
  		}
  		function del1(){
  			var ep = document.form.textview.value;
  			document.form.textview.value = ep.substring(0, ep.length - 1);
  		}
  		function percent(){
  			var ep = document.form.textview.value;
  			document.form.textview.value = ep/100;
  		}
  	</script>
  	<style type="text/css">
  		body{
  			background: linear-gradient(to right,#FA8AEC,#FF6600);
  		}
  		form{
  			margin-top: 50px;
  		}
  		.textview{
  			border: 0;
  			width: 400px;
  			height: 120px;
  			font-size: 20px;
  			font-weight: bold;
  		}
  		table{
  			margin-top: 40px;
  			margin-bottom: 40px;
  			margin-left: 90px;
  		}
  		button{
  			width: 70px;
  			height: 70px;
  			border: 0;
			font-size: 18px;
			font-weight: bold;
			margin: 8px;
  		}
  		button:hover{
  			background-color: #0084FF;
  			transition: 0.5s;
  		}
  		button:focus{
  			outline: 0;
  		}
		.circlex:hover{
			background-color: red;
		}
		.daucau{
			background-color: #FFD800;
		}
		.daucau:hover{
			background-color: #FF00EA;
			transition: 0.7s;
			transform: rotate(360deg);
		}
  	</style>
</head>
<body class="">
	<div class="container-fluid">
		<div class="row">
			<div class="col-sm-1 col-md-2 col-lg-3 col-xl-4"></div>
			<div class="col-12 col-sm-10 col-md-8 col-lg-6 col-xl-4 rounded text-center" style="margin-top: 50px;background: linear-gradient(to right,#FF6C00,#A652EE);">
				<form name="form">
					<input class="textview rounded" name="textview" disabled="">
				</form>

				<table>
					<tr>
						<td><button class="rounded-circle daucau" onclick="del1()">C</button></td>
						<td><button class="rounded-circle daucau" onclick="del()">CE</button></td>
						<td><button class="rounded-circle daucau" onclick="percent()">%</button></td>
						<td><button class="rounded-circle daucau" onclick="insert('/')">÷</button></td>
					</tr>
					<tr>
						<td><button class="rounded text-gray-dark" onclick="insert(7)">7</button></td>
						<td><button class="rounded text-gray-dark" onclick="insert(8)">8</button></td>
						<td><button class="rounded text-gray-dark" onclick="insert(9)">9</button></td>
						<td><button class="rounded-circle daucau" onclick="insert('*')">x</button></td>
					</tr>
					<tr>
						<td><button class="rounded text-gray-dark" onclick="insert(4)">4</button></td>
						<td><button class="rounded text-gray-dark" onclick="insert(5)">5</button></td>
						<td><button class="rounded text-gray-dark" onclick="insert(6)">6</button></td>
						<td><button class="rounded-circle daucau" onclick="insert('-')">-</button></td>
					</tr>
					<tr>
						<td><button class="rounded text-gray-dark" onclick="insert(1)">1</button></td>
						<td><button class="rounded text-gray-dark" onclick="insert(2)">2</button></td>
						<td><button class="rounded text-gray-dark" onclick="insert(3)">3</button></td>
						<td><button class="rounded-circle  daucau" onclick="insert('+')">+</button></td>
					</tr>
					<tr>
						<td colspan="2"><button class="rounded text-gray-dark" style="width: 156px;" onclick="insert(0)">0</button></td>
						<td><button class="rounded text-gray-dark" onclick="insert('.')">.</button></td>
						<td><button class="rounded-circle  daucau" onclick="equal()">=</button></td>
					</tr>
				</table>
			</div>
		</div>
	</div>
</body>
</html>