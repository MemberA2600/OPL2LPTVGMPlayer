# OPL2LPTVGMPlayer
<h2>A Video Game Music Player for the OPL2LPT sound card on Windows</h2>
<p><i>(tested on Windows 7 / 10)</i></p>
<a href="https://ibb.co/sKwYjFw"><img src="https://i.ibb.co/k48CKh8/OPL2-LPTPlayer.png" alt="OPL2-LPTPlayer" border="0"></a>
<p><b><u>I. What is this about?</u></b></p>

<p align = "justify" >Serdashop created a really cool device for old XT/AT laptops without expansion ports, so you can have proper music for the games of that era.</p>
https://www.serdashop.com/OPL2LPT
<p align = "justify" >I have to say, the games back then, like Alone in the Dark, Ultima VI or Duke Nukem II had great music that is worth to listen to. They are soo good I have an Adlib-clone card in my DOS machine (a Pentium III) so I can listen to them on the real deal, the OPL2 (YM3812).</p>

<p align = "justify" >Since I'm a big fan of this sound chip and I have a project related to the old-good Atari 2600 that will use this sound device, I had the idea I should create a player so I can listen to the music on my working PC without switching machines.</p>

<p><b><u>II. How does this work?</u></b></p>
<p align = "justify" >The original plan was to do this application thru Fortran 90, you can still find the original code in this repo. Unfortunately, even doing the proper process pointer thing, loading the inpout32 DLL worked and also I could ask if the DLL and the process was found in the proper location, but after that, in the DLL level, it failed to send the data to the LPT port adresses, so nothing happened.</p>

