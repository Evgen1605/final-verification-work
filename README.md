# final-verification-work

## Алгоритм выполнения задания:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

### Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
### Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

## Алгоритм решения:
1. Перебираем значения из исходного массива
2. Проверяем каждое значение из массива на соответствие условию: _длина строки меньше или равна трём_
3. Если строка удовлетворяет условию кладем значение в новый массив
4. Повторяем пункты **2** и **3** до тех пор пока не достигнем конца исходного массива
5. Возвращаем новый заполненный массив как результат
