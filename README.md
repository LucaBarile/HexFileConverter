# HexFileConverter

<h3>Why HexFileConverter?</h3>
I needed to convert a hex file (saved in a <a href="https://github.com/LucaBarile/HexFileConverter/edit/main/README.md#hex-file-format" target="_blank" rel="noopener noreferrer">particular format</a>) in order to develop <a href="https://www.google.com" target="_blank" rel="noopener noreferrer">my exploit</a> for <a href="https://www.google.com" target="_blank" rel="noopener noreferrer">CVE-2022-0001</a>.<br>
(The exploit is quite interesting; read <a href="https://www.google.com" target="_blank" rel="noopener noreferrer">my report</a> if you have nothing better to do &#128580;).<br>
After developing the code to convert a hex file to its original format I thought I’d also implement the code to perform the reverse conversion as well.<br>
HexFileConverter was born Putting everything together in one program.<br>

<h3>What is it for?</h3>
Allows you to convert a file of any type to hexadecimal format (and vice versa).<br>

<h3>Usage</h3>
To convert a file of any type (e.g. <code>foo.txt</code>) to hex format:<br>
<code>HexFileConverter.exe foo.txt</code><br>
The <code>foo.txt.hex</code> file will be generated.<br>
<br>
To convert a file from hex format (e.g. <code>foo.txt.hex</code>) to its original format (txt):<br>
<code>HexFileConverter.exe foo.txt.hex</code><br>
The <code>foo.txt</code> file will be generated.<br>
<br>
Note:<br>
In this case the file you want to convert must be located in the same folder as <code>HexFileConverter.exe</code><br>
If not, you must specify the entire path of the file to convert (e.g. <code>C:\...\Desktop\foo.txt</code>).<br>
<br>
<img src="Usage.gif" alt="" title="secret.txt security settings">
<h3>Hex file format</h3>
To convert a hex file successfully, it must be formatted as follows:<br>
- Each hexadecimal number must be separated by a space.<br>
- There must be at most 16 hexadecimal numbers in a row.<br>
- The letters of a hexadecimal number can be either uppercase or lowercase.<br>
- After the last hexadecimal number there must be a newline.<br>
- The newline characters must be <a href="https://stackoverflow.com/questions/3986093/in-c-whats-the-difference-between-n-and-r-n" target="_blank" rel="noopener noreferrer">\r\n</a><br>
<br>
<img src="Format.png" alt="" title="secret.txt security settings">
Aaaa










<a href="https://www.google.com" target="_blank" rel="noopener noreferrer">my exploit</a>

<a href="https://www.google.com" target="_blank" rel="noopener noreferrer">my exploit</a>

<a href="https://www.google.com" target="_blank" rel="noopener noreferrer">my exploit</a>