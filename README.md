# Mindbox_Entry_Task

Вступительное испытание для компании Mindbox. Реализованна библиотека классов, которая может считать площади фигур.

![image](https://user-images.githubusercontent.com/69851710/214827453-085662f0-7b3a-4d2e-832b-bdfd6159cc1f.png)

Библиотека спроектирована с применением паттерна Facade. Внешнему пользователю доступен только класс AreaCalculator, остальные классы недоступны. Тем самым внешний пользователь не может нарушить логику библиотеки.

+ AreaCalculator - фасад, который объединяет в себя все классы фигур.
С помощью AreaCalculator можно получить доступ к нужным методам, которые были даны в задании. 
Класс не рассчитывает площади фигур, а только перенаправляет в нужный класс.  
Методы:
  + AreaBySides - Метод определяет тип фигуры по количеству параметров и возвращает площадь.  
  Если количество параметров не обработано выдаст ошибку.
  + CircleArea - Метод принимает радиус и вызывает метод класса Circle.
  + QuadrangleArea - Метод принимает стороны и вызывает метод класса Quadrangle.
  + TriangleArea - Метод принимает стороны и вызывает метод класса Triangle.
  + IsRiaghtTriangle - Метод принимает стороны и вызывает метод класса Triangle.

+ Circle содержит единственный метод Calculate, который рассчитывает площадь круга по радиусу.

+ Quadrangle содержит единственный метод Calculate, который рассчитывает площадь четырехугольника по сторонам.

+ Triangle рассчитывает площадь треугольника по сторонам и определяет, является ли треугольник прямоугольным. 

Для того чтобы добавить новую фигуру, необходимо:
1. Создать класс фигуры в папке Shapes
2. Добавить необходимые методы
3. Добавить новые методы в класс AreaCalculator
4. Добавить условие в метод AreaBySides
