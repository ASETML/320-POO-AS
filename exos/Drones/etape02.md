# Drones
## Etape 2

- Créez une nouvelle classe `Building` qui modélise un immeuble grâce aux attributs suivants:
  - Emplacement (coordonnées x,y)
  - Dimensions (Largeur, Profondeur (parce qu'on regarde depuis en haut! On ne peut pas représenter la hauteur du bâtiment))
  - Une couleur
- Déclarez une liste de `Building` dans le programme principal;  transmettez cette liste à `Airspace`
- Modifiez `Airspace` pour qu'il dessine les buildings lors du Render. (Il n'y a rien à faire durant l'Update car les bâtiments ne bougent pas)  
  
 **---- commit, nommé `feat(Drone): Afficher les bâtiments` ----**

- Créez deux nouvelles classes pour modéliser les usines de production `Factory` et les points de vente `Store`. Tous les deux sont des bâtiments, les classes doivent donc hériter de `Building`. Ce qui les distingue:
  - Les usines consomment beaucoup d'énergie, elles ont un attribut `PowerConsumption` que les magasins n'ont pas. Il s'agit du nombre de KwH par jour, un nombre décimal.
  - Les points de vente ont des horaires d'ouverture `OpeningHours`. Il s'agit d'une liste de chaînes de caractères du genre: "Lundi: 8h-18h","Mardi: 8h-18h","Mercredi: 8h-18h"
  - Les usines sont carrées, les magasins sont ronds
- Lorsqu'un bâtiment est instancié (usine ou magasin), ses caractéristiques sont affichées dans la console (`Console.WriteLine()`)

 **---- commit, nommé `feat(Drone): Distinguer les usines des magasins` ----**
