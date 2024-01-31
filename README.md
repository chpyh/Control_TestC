# Control_test_C#
# Итоговая контрольная работа по основному блоку(GeekBrains).
## Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## Решение
В репозитории представленое универсальное решение для любого текста, введенного пользователем.
Решение состоит из 6 шагов: строчки кода, в котором к считанному с консоли тексту добавила в конце пробел, и 5 шагов-методов:
1. Превращаю считаный с консоли текст в массив из строк, где каждый символ = строка.
   Это необходимо, чтобы можно было сравнивать символы между собой.
2. Считаю, сколько в массиве слов. Для этого ориентируюсь на пробелы, игнорируя лишние пробелы.
3. Выделяю из массива строк-символов массив строк-слов.
4. Считаю, сколько в этом массиве элементов длинной меньше 4 символов.
5. Выделяю из массива слов массив со строками длинной меньше 4 сиволов.
## Почему такое вниманиек пробелам
Пользователи могут ввести текст как попало, поставить пробел в начале или в конце, понаставить пробелы в середине.
Если их не убрать, программа будет их считать за отдельные элементы и выдаст в конечном ответе.
Пробел в самом конце добавила сразу вручную, чтобы программа точно не "потеряла" последнее слово, если после него нет пробела.
