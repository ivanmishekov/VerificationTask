# **Итоговая проверочная работа.**
## **Задача**: 
### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## **Примеры**:
### [ "hello", "2", "world", ":-)"] -> [ "2", ":-)"]
### [ "1234", "1567", "-2", "computer science"] -> [ "-2"]
### ["Russia", "Denmark", "Kazan"] -> []

## **Описание решения**
### Создаём два массива одинаковый длины. Заполняем произвольно первый массив. Затем в методе "Resolution" строки удовлетворяющие условию задания присваиваются во второй массив и с помощью метода "PrintArray" выводим этот массив на экран.