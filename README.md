#Strona na przedmiot Architektura Serwisów Internetowych.
http://mvcmini.apphb.com/

#Wykorzystane technologie:
ASP.NET MVC 3 Framework
Entity Framework

#Wymagane oprogramowanie:
Visual Studio 2010 Express(Microsoft Visual Web Developer 2010 Express)
SQL Server 2008 express

#Język programowania:
C#

#Co zrobić aby stworzyć pierwszą aplikację?
	Otwieramy Microsoft Visual Web Developer 2010 Express
	klikamy "New Project"
	wybieramy Visual C# -> Web -> ASP.NET MVC 3 Web Application
	klikamy "start"(F5) i gotowe! Pierwsza aplikacja została uruchomiona!

#Kilka zalet...
- tworzy logiczną strukturę katalogów
- możemy stworzyć projekt na podstawie przykładowej aplikacji (ASP.NET MVC 3 Web Application)
- W kontrolerze jednym kliknięciem możemy stworzyć widok na podstawie modelu(szczegóły, edytuj, lista, dodaj, usuń)... a nawet tzw. widoku modelu
- łatwa walidacja dzięki jquery i klasom częściowym tj. wpisanie zaledwie 3 linijek: nazwy zmiennej, wiadomości przy wymagalności pola, maksymalnej długości pola

przykład:
[Required(ErrorMessage = “Title is required”)]
[StringLength(50, ErrorMessage = “Title may not be longer than 50 characters”)]
public string Title { get; set; }