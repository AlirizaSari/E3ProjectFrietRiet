# Friet van Riet

<h2>Ticket Format</h2>
In iedere ticket wordt het volgende verwerkt:

- **<afdeling > Bondige omschrijvende titel, bijvoorbeeld: 'Web - Tekst weghalen bestelpagina'**
- **Kleine beschrijving van de issue**
- **Toepasselijke labels** (bijvoorbeeld: de huidige sprint, wat voor issue het is, hulp? prioriteit etc.)
- **Iteratie** (dit is een nieuwe feature op het planboord. dit staat gelijk aan 1 week. deze weken staan weer gelijk aan de sprints zoals wij die kennen.)
- **Geschatte tijd** die je denkt nodig te hebben
- **Aangewezen persoon** voor de issue

Je maakt een eigen **branch** aan per onderdeel waar je aan gaat werken en merged die branch pas als hij 100% werkt. 

Deze voorzorgs maatregelen zorgen voor rust en regelmaat in ons werken. Door dit consequent te doen kunnen we makkelijk met minder stress werken. Hopelijk gaan ons kwaliteit van werken ook vooruit.

<h2>Conventies:</h2>
<h3>Review conventies:</h3>

- **Duidelijke reviewcommits**
- **1 reviewer**
- **Reviewer** moet de persoon zijn die het meest betrokken is bij jouw commit
- **Reviewcommits** moeten in het Engels
- **Pull Request** moet per functionaliteit gebeuren

<h3>Codeer conventies C#</h3>
Je code moet gedocumenteerd zijn d.m.v. van summaries (drie slashes voor een method)
Comments zijn ook goed, maar moeten in het Engels.
Commits moeten ook in het Engels, let op hoofdletters.
Let op spelfouten.
Alle namen gaan in het Engels.
De classes zetten we in de classes map.
Elke tekst die de klant te zien krijgt, heeft het lettertype 'Segoe UI'.
Alle if-statements die waar zijn, krijgen geen '== true', dat gebeurt automatisch.
Alle if-statements die niet waar zijn, krijgen geen '== false', die krijgen een ! voor de statement.

<b>Coding guidelines:</b>
- Classes zijn **PascalCase**
- Private fields **_camelCase**
- Public fields **PascalCase**
- Parameters zijn **camelCase**
- Locale variabelen **camelCase**
- Private functies **camelcase**
- Public functions **PascalCase**
- Linq-expressie = **camelCase** 
- Variabelen moeten een duidelijke naam hebben.
- Magic numbers = niet doen.
- Niet met errors pushen.

<b>Naamgevingen:</b>

Voor naamgevingen, volg deze link: https://jeffpar.github.io/kbarchive/kb/173/Q173738/

<h3>Codeer conventies Web</h3>

<b>Controllers</b><br>
Controllers moeten in **PascalCase** zijn. (Bijvoorbeeld: BlogController, AuthController, UserController.)

<b>Database</b><br>
DB-tabellen moeten in **kleine letters** zijn. (Bijvoorbeeld: posts, project_tasks, uploaded_images.)
De naam van de tabelkolommen moeten in **snake_case** zijn. (Bijvoorbeeld: post_body, id, created_at.)
Primary Key moet normaal gesproken 'id' zijn.
Foreign keys moeten de naam van het model zijn (enkelvoudig), met 'id' eraan toegevoegd. (Bijvoorbeeld: comment_id, user_id.)

<b>Variabelen</b><br>
Normale variabelen moeten meestal in **camelCase** zijn. (Bijvoorbeeld: $users = ..., $bannedUsers = ...)
Als de variabele een array of collectie van meerdere items bevat, dan moet de variabelenaam in **meervoud** zijn. (Bijvoorbeeld: $users = User::all();)

<b>Models</b><br>
Een model moet in **PascalCase** zijn. (Bijvoorbeeld: User (\App\User of \App\Models\User, etc), ForumThread, Comment.)
Model properties moeten in **kleine letters, snake_case** zijn. (Bijvoorbeeld: $this->updated_at, $this->title.)
Methoden in je modellen in Laravel-projecten, zoals alle methoden in je Laravel-projecten, moeten in **camelCase** zijn. (Bijvoorbeeld: public function get(), public function getAll().)

<b>Relaties</b><br>
HasOne of belongsTo relaties moeten in **camelCase** zijn. (Bijvoorbeeld: public function postAuthor(), public function phone().)
hasMany, belongsToMany, hasManyThrough moeten dezelfde zijn als de conventies voor één-naar-veelnamen, maar het moet in **meervoud** zijn. (Bijvoorbeeld: public function comments(), public function roles().)

<b>Blade views</b><br>
Blade-bestanden moeten in **kleine letters, snake_case** zijn (Bijvoorbeeld: all.blade.php, all_posts.blade.php, etc)
