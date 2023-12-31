
Задание по C#:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным 

Краткое описание основых моментов решения:

FigureArea - C# библиотека для фигур. Для ее реализации использовались рефлексия с поздним связыванием, наследование и необязательные параметры в методах. Это позволяет легко создавать фигуры без какой-либо необходимости регистрировать их в switch или его фабрику, а так же вычислять площади фигуры без знания типа фигуры в compile-time, передавая в параметры метода GetFigureInfo тип фигуры на английском языке и необходимые значения для определения площади. Необязательные параметры дают независимость от формулы для вычисления площади, так как для вычисления площади любой распространенной фигуры достаточно знать от 1 до 3 параметров.

ПРИМЕЧАНИЕ: Данный способ подходит для всех фигур у которых существуют формулы для вычисления площади т.е. у которых можно определить площадь без разбиения на несколько фигур, так как иначе потребуется больше трех парметров в методе, а это ведет к антипатерну. 

Вариант с использованием интерфейса и реализация его классами с конструкторами с парметрами мне показался сложнее для расширения.

Задание по SQL: 

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Решение задачи:

SELECT Products.name, Categorys.name
FROM Products_Categorys
LEFT JOIN Products ON Products_Categorys.product_id = Products.id
LEFT JOIN Categorys ON Products_Categorys.category_id = Categorys.id;
