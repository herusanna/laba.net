 laba.net
c#(5 var,герус)

№2 При использовании более новой версии .NET Framework по сравнению с целевой, платформа применяет режим совместимости для имитации поведения старой версии. Приложение будет работать на новой версии платформы, но все операции с ним выполняются так, как если бы оно было запущено на более ранней версии. Такая имитация позволяет устранить многие проблемы совместимости между версиями .NET Framework.

№6Переменная имеет тип, имя и значение. Тип определяет, какого рода информацию может хранить переменная.
Перед использованием любую переменную надо определить. Синтаксис определения переменной выглядит следующим образом:
•	тип имя_переменной;
Вначале идет тип переменной, потом ее имя.

№11 Область видимости, или контекст переменной — это часть кода, в пределах которого доступна данная переменная. В общем случае такая область определяется описанными ниже правилами:
Поле, также известное как переменная-член класса, находится в области видимости до тех пор, пока в этой области находится содержащий поле класс.
Локальная переменная находится в области видимости до тех пор, пока закрывающая фигурная скобка не укажет конец блока операторов или метода, в котором она объявлена.
Локальная переменная, объявленная в операторах цикла for, while или подобных им, видима в пределах тела цикла.

№16Пространство имён (англ. namespace) — некоторое множество, под которым подразумевается модель, абстрактное хранилище или окружение, созданное для логической группировки уникальных идентификаторов (то есть имён).

№21Директива using используется в следующих трех целях.
•	Для разрешения использования типов в пространстве имен, чтобы не нужно было квалифицировать использование типа в этом пространстве имен:
using System.Text;
•	Для разрешения доступа к статическим членам и вложенным типам без необходимости квалифицировать доступ с помощью имени типа.
using static System.Math;

