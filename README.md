# TP1 : Vigenère et Kasiski
TP 1 et 2 de crypto réalisé dans le but d'apprendre à coder et décoder un texte par la méthode de chiffrement de vigenère et connaitre les collisions des testes chiffrés par la méthode de Kasiski.

## Début

[Exercice 1]: Votre programme prendra en entrée deux chaines de caractères de longueur variable : la première entrée sera le texte clair, la deuxième, la clé. La sortie sera une chaine de caractère : le chiffré.
Votre programme devrait fonctionner pour toute longueur de clé et de texte clair.
On demandera (sur la console) un texte clair et une clé. Avec ces données on affichera sur la console le texte chiffré obtenu.

[Exercice 2]: implémentez le déchiffrement d’un chiffré obtenu par la méthode de Vigenère. Votre programme prendra en entrée deux chaines de caractères : un chiffré et une clé. Votre programme rendra en sortie une chaine de caractère : le texte clair.

[Exercice 3]: implémentez la méthode de Kasiski pour estimer la taille de la clé (inconnue) qui a été utilisée pour chiffrer un chiffré donné de Vigenère.

### Prérequis

Code réalisé en Java avec l'IDE Eclipse

## Exercice 1

Notre classe chiffrement de Vigenère contient une méthode chiffrer qui prend 2 paramètres (le texte clair et la clé) et qui retourne un tableau de String qui contient le texte chiffré. Dans cette méthode, notre texte clair est inséré dans un tableau de String. Nous avons initialisé 2 tableaux prenant les lettres de l'alphabet en minuscule pour l'un et en majuscule pour l'autre. Tout d'abord, nous calculons le décalage entre la clé et le texte clair par lettre. Puis, nous regardons lettre par lettre s'il s'agit d'une majuscule ou d'une minuscule afin de connaître en sommant notre décalage de la clé, notre nouvelle lettre qui composera notre texte chiffré. Cette méthode chiffrer renvoie notre tableau contenant les nouvelles lettres de notre texte chiffré. 

Notre fonction main quant à elle crée un scanner afin de lire l'entrée de l'utilisateur dans la console et les sauvegarde dans une variable afin de les traiter dans notre méthode chiffrer.

Par exemple, nous avons écrit un texte claire contenant des majuscules, des minuscules et des espaces : bonJourTout le monde.
Ainsi qu'une clé : poisson 

le texte chiffré est : qcvBgieIccl ds zdblw

![image](https://user-images.githubusercontent.com/63807458/153675794-dfc00e58-40ec-4a8a-9223-a10d73441cbf.png)


## Exercice 2

Notre classe déchiffrement de Vigenère contient une méthode dechiffrer qui prend 2 paramètres (le texte chiffré et la clé) et qui retourne un tableau de String qui contient le texte clair. Dans cette méthode, notre texte chiffré est inséré dans un tableau de String. Nous avons initialisé 2 tableaux prenant les lettres de l'alphabet en minuscule pour l'un et en majuscule pour l'autre. Tout d'abord, nous calculons le décalage entre la clé et le texte chiffré par lettre. Puis, nous regardons lettre par lettre s'il s'agit d'une majuscule ou d'une minuscule afin de connaître par rapport au décalage de la clé, notre nouvelle lettre qui composera notre texte clair. Cette méthode déchiffrer renvoie notre tableau contenant les nouvelles lettres de notre texte clair. 

Notre fonction main quant à elle crée un scanner afin de lire l'entrée de l'utilisateur dans la console et les sauvegarde dans une variable afin de les traiter dans notre méthode chiffrer.

Par exemple, reprenons notre texte chiffré de l'exercice 1 et notre clé, qui sont respectivement : qcvBgieIccl ds zdblw ET poisson
Notre texte clair est : bonJourTout le monde

![image](https://user-images.githubusercontent.com/63807458/153676748-cf3ea8d2-9d01-41f8-8e48-7579f8587a8a.png)


## Exercice 3

!!!!! Nous avons réalisé notre algorithme, qui paraissait marcher, malheureusement, lors des phases de tests, nous avons découvert que notre code contenait une erreur que nous n'avons pas pu identifier.

Dans notre méthode GCD prenant en méthode 2 entier, nous calculons simplement le plus grand diviseur commun entre eux et nous le renvoyons.
Dans la seconde méthode kasiski, nous prenons en paramètre notre texte chiffré, puis créons un tableau (HashMap) pour stocké les séquences avec une clé. Nous initialions 3 boucles for pour comparer toutes les séquences possibles de notre texte chiffré. Si jamais il y a collisions, nous stockons la distance et la séquence dans un tableau. Ce tableau servira par la suite, grâce à l'appel de notre fonction GCD de connaître notre PGDC 2 à 2 afin de connaître la taille de la clé probable. 



## Auteurs

* **FORESTIER Samuel et VERDEYME Nathan G5A ** 

## License

Projet sous licence de l'IUT de Limoges. 
