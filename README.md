# Mindbox Тестовое задание

## Задача C#

    Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

* Юнит-тесты

* Легкость добавления других фигур

* Вычисление площади фигуры без знания типа фигуры в compile-time

* Проверку на то, является ли треугольник прямоугольным 

## Задача SQL

    В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

### 1) Создать и заполнить схему базы данных

    CREATE TABLE Products(
    id INT PRIMARY KEY, 
    name VARCHAR(255) NOT NULL);

    CREATE TABLE Categories(
    id INT PRIMARY KEY,
    name VARCHAR(255) NOT NULL);

    CREATE TABLE ProductCategories(
    product_id INT NOT NULL,
    category_id INT NOT NULL,
    FOREIGN KEY(product_id) REFERENCES Products(id) ON DELETE CASCADE,
    FOREIGN KEY(category_id) REFERENCES Categories(id) ON DELETE CASCADE);

    CREATE UNIQUE INDEX product_category_index ON ProductCategories(product_id, category_id);

    INSERT INTO Products VALUES(1, 'Обезболивающее'), (2, 'Вилка'), (3, 'Ложка');
    INSERT INTO Categories VALUES(1, 'Медикаменты'), (2, 'Столовые приборы');
    INSERT INTO ProductCategories VALUES(1, 1), (2, 2);

### 2) Вывести данные по заданию
    SELECT p.name AS product_name, c.name AS category_name FROM products AS p
    LEFT JOIN productCategories AS pc ON p.id = pc.product_id
    LEFT JOIN categories AS c ON c.id = pc.category_id
    ORDER BY product_name;