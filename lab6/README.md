# Облік складу товарів

Цей проект демонструє використання декількох принципів програмування, шаблонів проектування та технік рефакторингу в системі управління інвентарем.

## Принципи Програмування

1. **Принцип Єдиної Відповідальності (SRP)**:
   - Кожен клас відповідає за певну функціональність.
   - `ProductRepository`: Виконує CRUD-операції для продуктів. ([ProductRepository.cs](C:/Users/PC/Desktop/політех/Software_design/lab6/Inventory/ClassLibrary/Repositories/ProductRepository.cs#L6-L202))
   - `SupplierRepository`: Виконує операції для постачальників. ([SupplierRepository.cs](./ClassLibrary/SupplierRepository.cs#L6-L34))
   - `MainController`: Діє як фасад для операцій з продуктами та постачальниками. ([MainController.cs](./Inventory/MainController.cs#L6-L77))
   - `AddTovarPage`: Керує інтерфейсом користувача для додавання нового продукту. ([AddTovarPage.cs](./Inventory/AddTovarPage.cs#L6-L45))
   - `EditTovarPage`: Керує інтерфейсом користувача для редагування існуючого продукту. ([EditTovarPage.cs](./Inventory/EditTovarPage.cs#L6-L45))
   - `ShowSuppliersForm`: Відображає інформацію про постачальників. ([ShowSuppliersForm.cs](./Inventory/ShowSuppliersForm.cs#L6-L39))
   - `ShowTovar`: Відображає інформацію про продукти. ([ShowTovar.cs](./Inventory/ShowTovar.cs#L6-L92))
   - `MainForm`: Основна форма інтерфейсу користувача для різних операцій. ([MainForm.cs](./Inventory/MainForm.cs#L6-L103))

2. **Впровадження Залежностей**:
   - Залежності впроваджуються через конструктори, що сприяє слабкій зв'язності та легкому тестуванню.

3. **Інкапсуляція**:
   - Деталі реалізації приховані в межах класів, відкриваючи тільки необхідні інтерфейси.

4. **DRY (Don't Repeat Yourself)**:
   - Створюються багаторазові методи, щоб уникнути дублювання коду. Наприклад, методи `ExecuteNonQuery` та `ExecuteReader` в `ProductRepository`. ([ProductRepository.cs](./ClassLibrary/ProductRepository.cs#L144-L202))

5. **KISS (Keep It Simple, Stupid)**:
   - Код залишається простим і зрозумілим. Методи є лаконічними і зосереджені на виконанні однієї задачі. Наприклад, `LoadProducts` та `DisplayProducts` в `ShowTovar`. ([ShowTovar.cs](./Inventory/ShowTovar.cs#L15-L27))

6. **Принципи SOLID**:
   - **Принцип Єдиної Відповідальності (SRP)**: Кожен клас має одну відповідальність.
   - **Принцип Відкритості/Закритості (OCP)**: Класи відкриті для розширення, але закриті для модифікації. Наприклад, можна додавати нові класи команд, не змінюючи існуючі. ([ProductCommandBase.cs](./ClassLibrary/ProductCommandBase.cs))
   - **Принцип Підстановки Барбари Лісков (LSP)**: Підтипи повинні бути взаємозамінними з їх базовими типами. Наприклад, `AddProductCommand` може замінити `ProductCommandBase`. ([AddProductCommand.cs](./ClassLibrary/ProductCommandBase.cs))
   - **Принцип Розділення Інтерфейсів (ISP)**: Інтерфейси мають бути маленькими і специфічними. Наприклад, `IProductRepository` та `ISupplierRepository` специфічні для своїх операцій. ([IProductRepository.cs](./ClassLibrary/IProductRepository.cs) та [ISupplierRepository.cs](./ClassLibrary/ISupplierRepository.cs))
   - **Принцип Інверсії Залежностей (DIP)**: Модулі високого рівня залежать від абстракцій, а не від модулів низького рівня. Наприклад, `MainController` залежить від інтерфейсів `IProductRepository` та `ISupplierRepository`. ([MainController.cs](./Inventory/MainController.cs#L6-L77))

7. **YAGNI (You Aren't Gonna Need It)**:
   - Реалізується тільки необхідна функціональність. Наприклад, до `MainController` додаються лише необхідні методи. ([MainController.cs](./Inventory/MainController.cs#L6-L77))

8. **Композиція Понад Наслідування**:
   - Проект використовує композицію замість наслідування для досягнення повторного використання коду та гнучкості. Наприклад, `MainController` складається з `IProductRepository` та `ISupplierRepository`. ([MainController.cs](./Inventory/MainController.cs#L6-L77))

9. **Програмування до Інтерфейсів, а не до Реалізацій**:
   - Код написаний до інтерфейсів, що дозволяє гнучкі та взаємозамінні реалізації. Наприклад, `MainController` залежить від `IProductRepository` та `ISupplierRepository`. ([MainController.cs](./Inventory/MainController.cs#L6-L77))

10. **Fail Fast**:
   - Код перевіряє на наявність помилок на ранніх етапах і негайно завершується у разі виявлення помилки. Наприклад, конструктори викидають виключення, якщо залежності дорівнюють null. ([AddTovarPage.cs](./Inventory/AddTovarPage.cs#L12-L14) та [EditTovarPage.cs](./Inventory/EditTovarPage.cs#L12-L14))

## Техніки Рефакторингу

1. **Extract Method**:
   - Методи розділені на менші, багаторазові функції для поліпшення читабельності та підтримуваності.
   - Приклад: `LoadProducts`, `DisplayProducts`, `SetColumnHeaders` в `ShowTovar`. ([ShowTovar.cs](./Inventory/ShowTovar.cs#L15-L42))

2. **Introduce Parameter**:
   - У методи введені параметри для передачі необхідних даних, що забезпечує гнучкість та багаторазовість.
   - Приклад: `LoadProductsSorted` в `ShowTovar`. ([ShowTovar.cs](./Inventory/ShowTovar.cs#L44-L92))

3. **Encapsulate Field**:
   - Приватні поля використовуються для зберігання стану залежностей, що забезпечує кращу інкапсуляцію.
   - Приклад: `_mainController`, `_selectedProductId` в `MainForm`. ([MainForm.cs](./Inventory/MainForm.cs#L10-L11))

## Шаблони Проектування

1. **Шаблон Команди (Command Pattern)**:
   - **Опис**: Інкапсулює запит як об'єкт, що дозволяє параметризувати клієнтів з різними запитами, ставити запити в чергу або вести журнал запитів.
   - **Використання**: Класи `ProductCommandBase`, `AddProductCommand`, `UpdateProductCommand`, `DeleteProductCommand` та `GetProductByIdQuery` реалізують шаблон Команди, інкапсулюючи різні операції над продуктами.
   - **Приклад**: [ProductCommandBase.cs](./ClassLibrary/ProductCommandBase.cs).

2. **Шаблон Репозиторію (Repository Pattern)**:
   - **Опис**: Інкапсулює логіку доступу до даних, забезпечуючи централізований інтерфейс для CRUD-операцій.
   - **Використання**: Реалізовано в класах `ProductRepository` та `SupplierRepository` для обробки операцій з базою даних для продуктів та постачальників відповідно.
   - **Приклад**: [ProductRepository.cs](./ClassLibrary/ProductRepository.cs#L6-L202) та [SupplierRepository.cs](./ClassLibrary/SupplierRepository.cs#L6-L34).

3. **Шаблон Посередника (Mediator Pattern)**:
   - **Опис**: Шаблон Посередника надає спосіб спілкування між об'єктами без необхідності посилатися один на одного безпосередньо, сприяючи слабкій зв'язності.
   - **Використання**: `MainController` діє як посередник між формами інтерфейсу користувача (такими як `AddTovarPage`, `EditTovarPage`, `ShowSuppliersForm` та `ShowTovar`) і бізнес-логікою.
   - **Приклад**: [MainController.cs](./Inventory/MainController.cs).

4. **Шаблон Фабричного Методу (Factory Method Pattern)**:
   - **Опис**: Визначає інтерфейс для створення об'єкта, але дозволяє підкласам змінювати тип створюваних об'єктів.
   - **Використання**: Метод `GetConnection` в `ProductRepository` та `SupplierRepository` діє як фабричний метод для створення екземплярів `MySqlConnection`.
   - **Приклад**: [ProductRepository.cs](./ClassLibrary/ProductRepository.cs#L22-L24) та [SupplierRepository.cs](./ClassLibrary/SupplierRepository.cs#L16-L18).

5. **Шаблон Шаблонного Методу (Template Method Pattern)**:
   - **Опис**: Визначає скелет алгоритму в методі, відкладаючи деякі кроки до підкласів.
   - **Використання**: Методи `ExecuteNonQuery`, `ExecuteReader` та `ExecuteReaderSingle` в `ProductRepository` використовують шаблон Шаблонного Методу для визначення послідовності кроків для виконання SQL-команд, дозволяючи підкласам надавати конкретні деталі запиту.
   - **Приклад**: [ProductRepository.cs](./ClassLibrary/ProductRepository.cs#L144-L202).