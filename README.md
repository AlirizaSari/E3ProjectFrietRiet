# Friet van Riet
<h2>Ticket Format</h2>
In iedere ticket wordt het volgende verwerkt:
- een bondige omschrijvende titel. 
- een kleine beschrijving van de issue.
- toepasselijke labels voor bijvoorbeeld: de huidige sprint, wat voor issue het is, hulp? prioriteit etc.
- een iteratie. dit is een nieuwe feature op het planboord. dit staat gelijk aan 1 week. deze weken staan weer gelijk aan de sprints zoals wij die kennen.
- een geschatte tijd die je denkt nodig te hebben.
- en als laatst een aangewezen persoon voor de issue.
 
Je maakt een eigen branch aan per onderdeel waar je aan gaat werken en merged die branch pas als hij 100% werkt.
 
Deze voorzorgs maatregelen zorgen voor rust en regelmaat in ons werken. Door dit concecuent te doen kunnen we makkelijk met minder stress werken. Hopelijk gaan ons kwaliteit van werken ook vooruit.

<h2>Conventies:</h2>
<h3>Review conventies:</h3><br>
- Duidelijke reviewcommits<br>
- 1 reviewer<br>
- Reviewer moet de persoon zijn die het meest betrokken is bij jouw commit<br>
- Reviewcommits moeten in het Engels<br>
- Pull Request moet per functionaliteit gebeuren<br>

<h3>Codeer conventies C#</h3>
Je code moet gedocumenteerd zijn d.m.v. van summaries (drie slashes voor een method)<br>
Comments zijn ook goed, maar moeten in het Engels.
Commits moeten ook in het Engels, let op hoofdletters.
Let op spelfouten.
Alle namen gaan in het Engels.<br>
De classes zetten we in de classes map.<br>
Elke tekst die de klant te zien krijgt, heeft het lettertype 'Segoe UI'.<br>
Alle if-statements die waar zijn, krijgen geen '== true', dat gebeurt automatisch.<br>
Alle if-statements die niet waar zijn, krijgen geen '== false', die krijgen een ! voor de statement.<br><br>

<b>Coding guidelines:</b><br>
Classes zijn PascalCase<br>
Private fields _camelCase<br>
Public fields PascalCase.<br>
Parameters zijn camelCase<br>
Locale variabelen camelCase<br>
private functies camelcase<br>
public functions PascalCase<br>
Linq-expressie = camelCase<br>
Variabelen moeten een duidelijke naam hebben.<br>
Magic numbers = niet doen.<br>
Niet met errors pushen.<br>

<b>Naamgevingen:</b><br>

Pages:<br>
Begin met de functie van de page in PascalCase en daarna ‘Page’.<br>
Voorbeeld: ‘InvoicePage’ of ‘HomePage’<br>

Mappen:<br>
De naam van de map is de afdeling zoals die in de organigram staan. <br>
De naam van de map begint met hoofdletter.<br>

Knoppen:<br>
Begin met ‘btn’ en daarna PascalCase.<br>
Voorbeeld: ‘btnDirectHome’<br>

Labels:<br>
Begin met ‘lbl’ en daarna PascalCase.<br>
Voorbeeld: ‘lblResult’<br>

Datagridview:<br>
Begin met ‘dgv’ en daarna PascalCase.<br>
Voorbeeld: ‘dgvInvoice’<br>
Checkbox:<br>
Begin met 'cb' en daarna PascalCase.<br>
Voorbeeld: 'cbBkrCheck'<br>

Combobox:<br>
Begin met ‘cbox’ en daarna PascalCase<br>
Voorbeeld: ‘cboxColorChoice’<br>

Textbox:<br>
Begin met 'txb' en daarna PascalCase.<br>
Voorbeeld: 'txbNameOfItem'<br>

<h3>Codeer conventies Web</h3>

<b>Controllers</b><br>
Controllers moeten in PascalCase zijn.<br> (Bijvoorbeeld: BlogController, AuthController, UserController.)<br>

<b>Database</b><br>
DB-tabellen moeten in kleine letters zijn.<br> (Bijvoorbeeld: posts, project_tasks, uploaded_images.)<br>
De naam van de tabelkolommen moeten in snake_case zijn.<br> (Bijvoorbeeld: post_body, id, created_at.)<br>
Primary Key moet normaal gesproken 'id' zijn.<br>
Foreign keys moeten de naam van het model zijn (enkelvoudig), met 'id' eraan toegevoegd.<br> (Bijvoorbeeld: comment_id, user_id.)<br>

<b>Variabelen</b><br>
Normale variabelen moeten meestal in camelCase zijn.<br> (Bijvoorbeeld: $users = ..., $bannedUsers = ...)<br>
Als de variabele een array of collectie van meerdere items bevat, dan moet de variabelenaam in meervoud zijn.<br> (Bijvoorbeeld: $users = User::all();)<br>

<b>Models</b><br>
Een model moet in PascalCase zijn.<br> (Bijvoorbeeld: User (\App\User of \App\Models\User, etc), ForumThread, Comment.)<br>
Model properties moeten in kleine letters, snake_case zijn.<br> (Bijvoorbeeld: $this->updated_at, $this->title.)<br>
Methoden in je modellen in Laravel-projecten, zoals alle methoden in je Laravel-projecten, moeten in camelCase zijn.<br> (Bijvoorbeeld: public function get(), public function getAll().)<br>

<b>Relaties</b><br>
HasOne of belongsTo relaties moeten in camelCase zijn.<br> (Bijvoorbeeld: public function postAuthor(), public function phone().)<br>
hasMany, belongsToMany, hasManyThrough moeten dezelfde zijn als de conventies voor één-naar-veelnamen, maar het moet in meervoud zijn.<br> (Bijvoorbeeld: public function comments(), public function roles().)<br>

<b>Blade views</b><br>
Blade-bestanden moeten in kleine letters, snake_case zijn<br> (Bijvoorbeeld: all.blade.php, all_posts.blade.php, etc)<br>
