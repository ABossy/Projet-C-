## C# Langage Orienté Objet

![logo c#](https://fr-images.tuto.net/tuto/thumb/648/288/89441.jpg)

**1. Class**

Une classe est une définition du comportement d'un objet.
La classe est l'essence de C # car elle définit la nature d'un objet.
La classe est la base sur laquelle le langage C # est construit.
Une classe est un modèle qui définit la forme d'un objet.

**2. Qu'est ce qu'une classe contient?**

Une classe contient une description complète des éléments suivants:
Les éléments de données que contient l'objet
Les méthodes que l'objet peut faire
La manière dont ces éléments de données et méthodes sont accessibles.

**3. Une classe est créee en utilisant le mot-clé **class**
par exemple: 

	public class Station
	{
	      // declare member variables
         // declare member properties
         // declare member methods
	}

**4. Accessibilité: Public ou Private ?**

Les classes et les membres de la classe peuvent être marqués comme publics, ce qui signifie que n'importe qui peut y accéder.
On ne peut pas marquer une classe privée à moins que cette classe ne soit dans une autre classe.
Les membres de la classe peuvent être marqués comme privés, ce qui signifie que seuls les autres membres peuvent y accéder ou que d'autres instances de cette classe peuvent y accéder.

**5. Une classe est une abstraction logique**
Ce n'est que lorsqu'un objet de cette classe a été créé qu'une représentation physique de cette classe existe en mémoire.
Vous utiliserez Station pour créer des objets de classe Station.
Les classes permettent de créer nos propres types de données similaires aux types de données intégrés tels que 
int, float, decimal, double, string et char.


**6. Les Objets sont des instances de classes**

Pour obtenir un objet, on dit au programme que nous voulons un nouvel objet de la classe Station. 
Ce nouvel objet est appelé une instance de la classe station.
*La création d'instances d'une classe est appelée instanciation.*
Par exemple, le code suivant créera des objets de Station appelés  Station bleue,  Station verte et  Station rouge

	Station bleue = nouveau Station ();
	Station verte = nouveau Station ();
	Station rouge = nouveau Station ();																										

**7. les Variables sont des elements de données**

Les classes peuvent contenir des données sous forme de variables.
Une variable stocke les données.
Les données sont de différents types. 

	Par exemple:
	int contient des nombres entiers
	string contient du texte
	bool contient des valeurs booléennes true / false

Il faut déclarez nos variables, le type suivi du nom. 

	int age; // cette variable contiendra l’âge de quelqu'un.

exemple:

	public class Station {
		 public string lines
		 public int passengers...
	}

**8.Methodes**

Lorsqu'une classe a besoin de faire quelque chose, elle utilise une méthode.
Une méthode prend une entrée, effectue une action et produit parfois une sortie.
Une méthode reçoit ses entrées via des paramètres.

       public void DoSomething (int count) {
           // les déclarations vont ici
       }
*void est un mot-clé que vous utilisez devant une méthode qui ne produira pas de sortie ou qui ne retournera pas de valeur.*


## Structure d'un Projet

**Types de fichiers projet et solution**

**1.Fichiers solution :**
Visual Studio utilise deux types de fichiers (.sln et .suo) pour stocker des paramètres spécifiques à des solutions. 
Ces fichiers, appelés collectivement fichiers solution, fournissent à l'Explorateur de solutions les informations dont il a besoin pour afficher une interface graphique de gestion de nos fichiers. 

|		 |         |                                      |
|--------|---------|------------------------------------- |
|Extension|Nom|Description|
| .sln | Solution Visual Studio |Organise les projets, les éléments de projet et les éléments de solution dans la solution.|
| .suo |Options utilisateur de solution|Assure le suivi des personnalisations au niveau de l'utilisateur que vous avez effectuées dans Visual Studio, telles que les points d'arrêt.|

**2.Library**
Une bibliothèque de classes définit des types et des méthodes qui peuvent être appelés par une application. 
Il s'agit d'un projet qui va permettre de contenir des classes que nous pourrons utiliser dans des applications. 
Ce type de projet permet donc de créer une assembly sous la forme d'un fichier avec l'extension .dll. Ces assemblys sont donc des bibliothèques qui seront utilisables par n'importe quelle application utilisant un langage compatible avec le framework .NET.

**Pourquoi créer une bibliothèque de classes ?**

Pour 2 raisons:

**Réutilisable:**
Nous pouvons y mettre tout le code C# que nous voulons, notamment des classes qui auront un intérêt à être utilisées à plusieurs endroits ou partagées par plusieurs applications

**Architecture:**
L’autre avantage dans la création de bibliothèques de classes est de pouvoir architecturer son application de manière à faciliter sa mise en place, sa maintenabilité et l’évolutivité du code. 

**3.L'injection de dépendance**
Lorsque deux classes entrent en interaction, un couplage se crée. 
l’injection permet d’établir de façon dynamique la relation entre plusieurs classes. 
Elle consiste à découper les responsabilités entres les différents modules, les différentes parties et facilite même la modification ultérieure des classes.
l’injection de dépendances est utile dans un objet. Elle permet de ne pas se soucier de l’instanciation d’autres objets /modules dont il dépend et par conséquent de pouvoir le réutiliser dans d’autre classes.

**4.Property**
Les propriétés se comportent comme des champs lorsqu'elles sont accédées. 
Cependant, contrairement aux champs, les propriétés sont implémentées avec des accesseurs qui définissent les instructions exécutées lors de l'accès ou de l'attribution d'une propriété.

		public class Person
	{
	    public string FirstName { get; set; }
	    // remaining implementation removed from listing
	}

**5.Debug & Release:**

**Debug**

Le mode debug permet de tracer son code a l’exécution, ou le modifier à la volée.., d’inspecter les variables etc..
En mode de débogage, notre fichier **.exe**contient des informations de débogage (code source, noms de variables et autres éléments similaires).
La taille du programme est donc plus conséquente qu’en release. 

**Release**

Le mode release c’est le mode de distribution de notre programme.
En mode de Release, le manque d'informations de débogage sur notre fichier **.exe** le rend plus petit et fonctionne probablement mieux en raison de son encombrement réduit.

On ne distribue pas un programme en mode debug.