# Особливості дотримання принципів програмування в моєму коді
* **KISS:**
  - Впродовж виконання всієї лабораторної роботи використовувалися найбільш прості(до яких я зміг прийти) способи реалізації
    функціоналую.
* **YAGNI:**
  - Було реалізованно тільки тей функціонал що є потрібним на поточному етапі розробки. Для прикладу- було вирішено не
    реалізовувати метод для виведення [Частин грошей](Lab_1/ClassLibrary1/MoneyPart.cs)(Долар, цент і т.д) оскільки цей
    функціонал не буде використаний на поточному етапі розробки та може бути не актуальним в майбутньому.
* **Composition Over Inheritance:**
  - цей метод було реалізовано при створені [класів](Lab_1/ClassLibrary1), оскільки я використовуєю композицію для створення більш складного
    об'єкта, для прикладу [грошей](Lab_1/ClassLibrary1/USD.cs) з менших, але більш простих об'єктів ([MoneyPart](Lab_1/ClassLibrary1/MoneyPart.cs))
* **Program to Interfaces not Implementations:**
  - Використання інтерфейсу [IReporting](Lab_1/ClassLibrary1/IReporting.cs#L3-L6) для реалізації [звітності](Lab_1/ClassLibrary1/IReporting.cs)
    _(класи створювались "базуючись на контракті" цього інтерфейсу)_ гарантує що ці класи можуть бути виведенні _(тобто місять метод для виведення)_.
* **Fail Fast:**
  - при ініціалізації полів класу проводиться додаткова перевірка значень на коректність[*](Lab_1/ClassLibrary1/IReporting.cs#L16) (хоча перевірка
    значеннь повинна буде проводититсь самій програмі).
* **Single-responsibility:**
  - Для створення об'єкту [грошей](Lab_1/ClassLibrary1/USD.cs) викорустовується допоміжний клас [MoneyPart](Lab_1/ClassLibrary1/MoneyPart.cs)
    _(Тобто клас [грошей](Lab_1/ClassLibrary1/USD.cs) був розділений на два менші класи з різними задачами)_.
* **Open–closed principle:**
  - Для прикладу- клас [Reporting](Lab_1/ClassLibrary1/IReporting.cs) закритий для змін, але відкритий для розжирення, методом дописання нового
    інтерфейсу для реалізації певного(нового) функціоналу.
