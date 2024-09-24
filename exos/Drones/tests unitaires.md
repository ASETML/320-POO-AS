# Tests unitaires

Les tests unitaires ne s'appliqueront qu'à la partie modèle du drone.

## A faire

- Ajouter un projet de test à votre solution
- Créer les tests suivants:
  - Un nouveau drone a une charge de 1000
  - A chaque Update, la charge de la batterie baisse
  - Si la charge de la batterie est inférieure à 20% de la charge complète, la propriété `LowBattery` du drone devient `true`
  - La méthode Update n'a aucun effet sur un drone déchargé (batterie = 0)

- Ajouter la propriété `LowBattery` à la classe drone pour que le code dest tests compile
- Modifier le code du modèle `Drone` jusq'à ce que les tests soient tous réussis