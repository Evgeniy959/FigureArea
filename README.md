
Задание:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным 

Краткое описание основых моментов решения:

FigureArea - C# библиотека для фигур. Для ее реализации использовались рефлексия с поздним связыванием, наследование и необязательные параметры в методах. Это позволяет легко создавать фигуры без какой-либо необходимости регистрировать их в switch или его фабрику, а так же вычислять площади фигуры без знания типа фигуры в compile-time, передавая в параметры метода GetFigureInfo тип фигуры на английском языке и необходимые значения для определения площади. Необязательные параметры дают независимость от формулы для вычисления площади, так как для вычисления площади любой фигуры достаточно знать от 1 до 3 параметров.

Вариант с использованием интерфейса и реализация его классами с конструкторами с парметрами мне показался сложнее для расширения.
