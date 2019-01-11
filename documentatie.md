# GinoBokhorst.github.io
<h1>Documentatie monopolonycolonieVanCatan</h1>
<p2>  - Het spel is gebasseerd op Monopolie en heeft een Russisch tintje. </p2>
<p1>  
  <BR>
<ul>
<li>productOwner           = Simon Holman</li>
<li>documentatieSchrijver  = Gino Bokhorst </li>
<li>backend                = Martijn Kruijer </li>
<li>frontend               = Obe Kaldeway </li>
<li>architectuur           = Daniël Scheepstra </li>
<li>assistent1             = Thomas Doornkamp </li>
<li>assistent2             = Gerald Wolff </li>
</ul>

<B>Korte samenvatting van hoe het project in elkaar zit:

De game is opgebouwd in het programma "Unity". In deze omgeving kan de game dan ook getest en gespeeld worden. De frontend is geheel opgebouwd in "Unity". Links in "Unity" zie je een foldersysteem waarin alle aspecten van de game zijn geordend. Deze komen in redelijke wijze overeen met de architectuur die hier nader besproken wordt. De scripts die zijn geschreven voor de objecten in "Unity" zijn geschreven in het programma "Windows Visual Code" en vervolgens gekoppeld aan de canvasbuttons in "Unity". Het overzicht van de taken wordt bewaard in het programma "Github", hierin is dus de architectuur opgebouwd. In "Github" tref je een repository aan en dit is de overzichtelijke weergave van welke regels en objecten er in de game moeten worden toegevoegd. Het hele project is te vinden en te clonen/downloaden in code van "MKruijer/2018-aa6-monopolonycolonieVanCatan"</B>

Stappenplan nieuwe collega's:
<ul>
  <li>  1. Kijk welke programma's je nodig hebt voor jouw rol (zie "Gebruikte programma's"). </li>
  <li>  2. Volg de instructies voor de programma's die je nodig hebt (zie tekst onder de genoemde programma's). </li>
  <li>  3. Lees de memo's van jouw rol. </li>
</ul>

Gebruikte programma's:
<ul>
<li>Brackets (documentatieSchrijver) </li>
    -> Downloaden (http://brackets.io/) en installeren.
       In dit programma wordt de documentatie geschreven. Dit programma is gekoppeld aan GithubPages. 
<li>Github (Iedereen) </li>
    -> Account aanmaken en Github Desktop downloaden (https://desktop.github.com/) en installeren en daarna de backend(;Martijn Kruijer) vragen om jouw gebruikersnaam laten toevoegen aan het GitHub project.                    Gebonden aan de repository(;MKruijer/2018-aa6-monopolonycolonieVanCatan) is het project "Monopolycolonievancatan" wanneer je hierop klikt zie je verscheidene columns en cards. Dit is eigenlijk een overzichtelijke      weergave van de regels van het spel. Al die spelregels zijn zo exact mogelijk geschreven en wanneer je nieuwe spelregels toevoegd wordt er ook van je verwacht dat je deze zo concreet mogelijk opschrijft.
<li>Unity (backend, frontend)</li>
    -> Downloaden (https://unity3d.com/get-unity/download) en installeren. 
       Hierin wordt de werkende game gebouwd. Het is handig om de Roll-a-ball tutorial te voltooien (https://unity3d.com/learn/tutorials/s/roll-ball-tutorial). 
<li>Windows Visual Studio Code (backend) </li>
    -> Downloaden (https://code.visualstudio.com/) en installeren.
       Dit programma wordt gebruikt om het script voor de game te schrijven. Dit script is gekoppeld aan het progamma "Unity". </p1>
  
<li>productOwner: Zorg ervoor dat je het overzicht bewaard en dat iedereen zijn/haar taak volbrengt.</li>
<li>backend     : De backend is opgebouwd vanuit "Windows Visual Studio Code". Hierin wordt elk script geschreven die vervolgens wordt gekoppeld aan de canvasbuttons in Unity. Variabele in scripts worden aan elkaar gekoppeld                 door middel van een "." voor het desbetreffende script. Alle straten moeten een unique script hebben, wanneer dit niet het geval is of er bepaalde aspecten van de game getest worden wordt als vervanging het script "ActionScript.cs" gebruikt te vinden in "MKruijer/2018-aa6-monopolonycolonieVanCatan/Assets/Scripts/".</li>
<li>frontend    : De frontend is opgebouwd vanuit Unity. Het begon allemaal met het creeëren van het 3D Object - Plane, die Plane is de basis; onderkant van het spelbord (verder in de tekst is deze Plane aangeduidt                           als basis). Op de basis zijn 40 andere Planes geplaats. Deze Planes komen overeen met de spelvakjes van het spel. 4/40 Planes zijn de hoekpunten van het spel en de resterende 36/40 Planes zijn de spelvakjes; straten. De spelvakjes en de hoekpunten zijn geordend in mapjes en hebben elk ook een eigen naam gekregen.</li>
<li>achitectuur : In Github vind je in de repository(;MKruijer/2018-aa6-monopolonycolonieVanCatan) het project "Monopolycolonievancatan" terug. Hierin staan 7 columns en in die columns staan verscheidene cards. Hieronder elke colum met een korte toelichting.</li>
<ul>
<li> colum 1(;spelers)              : Hierin staat globaal welke variable spelers moeten gaan bevatten. </li>
<li> colum 2(;objecten)             : Hierin staat welke objecten de game uiteindelijk moet gaan bevatten. </li>
<li> colum 3(;handelsysteem)        : Hierin staat wat voor transacties er uiteindelijk moeten kunnen plaatsvinden tussen spelers en de bank.</li>
<li> colum 4(;besturing)            : Hierin staat hoe de speler moet reageren op de verschillende vakjes en bepaalde kaarten.</li>
<li> colum 5(;vakjes)               : Hierin staat elk vakje en hoe die moet heten en welke regels eraan gebonden moeten worden.</li>
<li> colum 6(;kanskaarten)          : Hierin staat elke kanskaart met het de tekst die op de kaart moet gaan staan plus het gewenste effect dat de kaart moet gaan leveren.</li>
<li> colum 7(;algemeen fondskaarten): Hierin staat elke algemeen fondskaart met de de tekst die op die kaart moet gaan staan plus het gewenste effect dat de kaart moet gaan leveren.</li></ul>
  <BR>
De reden van dit format is dat deze manier van schematisch dingen ordenen erg overzichtelijk is. Wanneer je nu als backend of frontend bezig bent kan je meteen zien wat er allemaal moet gebeuren en zal het aantal vragen qua wat een object of speler of wat dan ook moet doen ook afnemen. 
</ul>
Het einddoel:
Het einddoel is het creeëren van een game die qua code hetzelfde zou zijn als een werkelijk Monopolie spel, maar met een andere stijl; een russische. Dus alle aspecten van de orginele Monopolie alleen dan anders weergegeven. Dus wel hetzelfde aantal vakjes en kanskaarten en algemeenfondskaarten maar dan met andere teksten. Qua animaties laten we het voor wat het is, dus die worden niet appart gemaakt en ook niet gebruikt als het niet standaard in "Unity" zit. Qua dobbelstenen moet het zo realitisch mogelijk dus met de kansen van twee dobbelstenen. 
<BR>
Done:<ul>
<li>Bord met vakjes</li>
<li>Straatnamen op de vakjes</li>
<li>Speelbaar met 2 spelers</li>
<li>Dobbelsteen geïmplementeerd in de game</li>
<li>Het in staat zijn om straten te kunnen kopen</li>
<li>Het in staat zijn van geld hebben</li>
<li>Het bewegen van een tweetal pionen</li>
<li>Geld eraf halen wanneer mensen op andermans straat komt</li>

</ul>
To-do:
<ul>
<li>Kans aanpassen voor de dobbelsteen</li>
<li>Uitsluiten dat spelers meerdere beurten achterelkaar kunnen spelen</li>
<li>Kanskaarten implementeren</li>
<li>Algemeenfondskaarten implementeren</li>
<li>De opmaak van de pionen</li>
<li>Het kunnen kiezen uit 2,3 of 4 spelers</li>
<li>Het cameraperspectief dynamisch maken</li>
<li>Hotels kunnen bouwen</li>
<li>Huizen kunnen bouwen</li>
<li>Veiling implementeren</li>
<li>Bedrijven implenteren</li>
<li>Hypotheek implementeren</li>
<BR>
<p2>Statusrapport (6-12-2018)
productOwner: Verscheidene cards aan het column "spelers" van Monopolie toegevoegd aan de repository (Aangegeven door: "added by SimonHolman").
backend     : Frontend begeleid in het opzetten van het begin van de game in Unity.
frontend    : Begin gemaakt in het opzetten van de game in Unity, zoals het maken van het bord en enkele vakjes daarop.
architectuur: Verscheidene cards aan de columns "Vakjes", "Kans Kaarten" en "Algemeen fonds" van Monopolie toegevoegd aan de repository (Aangegeven door: "added by dscheepstra"). Daarnaast verscheidene bestaande cards                     aangepast.
assistent   : Verscheidene cards aan het column "Kans Kaarten" van Monopolie toegevoegd aan de repository (Aangegeven door: "added by heinzdoofenschmirtz").

Statusrapport (10-12-2018)
productOwner:  Overlegd over wat het minimum viable product(;MVP) en later gepresenteerd in de les in de vorm van een elevator pitch.
backend     :  Frontend begeleid in het opzetten van de eerste paar spelvakjes van de 40 spelvakjes van het Monopolybord in de game in Unity.
frontend    :  Begonnen met het opzetten van de 40 spelvakjes van het Monopolybord en daar ook kleuren aan gebonden, kleuren kunnen nog veranderen op dit moment, in de game in Unity. 10/40 vlakjes geplaatst maar sloten                    niet op elkaar aan.
architectuur:  Overlegd over wat het minimum viable product(;MVP) gaat worden.
assistent   :  Overlegd over wat het minimum viable product(;MVP) gaat worden.

Uitkomst elevatorpitch; wat willen wij realiseren?
    -> Een bord met vakjes.
    -> Een dobbelsteen maken die in staat is een getal te genereren.
    -> Informatie binden aan een speler: straten en geld.
    -> Meldingscherm als je op een vrije straat komt.
    
Statusrapport (13-12-2018)
productOwner:  Verscheidene cards aan de columns "Spelers" en "Objecten" van Monopolie toegevoegd aan de repository (Aangegeven door: "added by SimonHolman"). Daarnaast verscheidene bestaande cards aangepast.
backend     :  Code geïmplementeerd waardoor de speler over het bord kan lopen en dat een speler een straat kan kopen waarbij zijn geld dus naar beneden gaat in een testomgeving. 
frontend    :  Het goed plaatsen van de 10/40 spelvakjes op (10-12-2018) is nu gelukt en de overige 30/40 spelvakjes is nu ook succesvol verlopen. 
architectuur:  Verscheidene cards aan de columns "Handelsysteem" en "Besturing" van Monopolie toegevoegd aan de repository (Aangegeven door: "added by dscheepstra"). Daarnaast verscheidene bestaande cards aangepast.
assistent   :  Begin gemaakt met het verzinnen van de namen van de straten van het spel (zie het column "vakjes" in de repository). 

Statusrapport (17-12-2018)
productOwner: Overlegd met productOwners van andere teams.
backend     : Overlegd met backenddevelopers van andere teams. De frontend geholpen met het toevoegen van tekst op het spelbord.
frontend    : Overlegd met frontenddevelopers van andere teams. Begonnen met het plaatsen van tekst op het spelbord.
achitectuur : Overlegd met architecten van andere teams.
assistent   : Resterende straatnamen bedacht voor de straten van het spel (zie het column "vakjes" in de repository). </p2>
