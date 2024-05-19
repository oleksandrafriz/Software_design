# Облік складу товарів

Цей проект демонструє використання декількох принципів програмування, шаблонів проектування та технік рефакторингу в системі управління інвентарем.

## Programming Principles

1. **Single Responsibility Principle (SRP)**:
   - Кожен клас відповідає за певну функціональність.
   - `ProductRepository`: Виконує CRUD-операції для продуктів. ([ProductRepository.cs](Inventory/ClassLibrary/Repositories/ProductRepository.cs))
   - `SupplierRepository`: Виконує операції для постачальників. ([SupplierRepository.cs](Inventory/ClassLibrary/Repositories/SupplierRepository.cs))
   - `MainController`: Діє як фасад для операцій з продуктами та постачальниками. ([MainController.cs](Inventory/ClassLibrary/Controllers/MainController.cs))
   - `AddTovarPage`: Керує інтерфейсом користувача для додавання нового продукту. ([AddTovarPage.cs](Inventory/Inventory/Forms/AddTovarPage.cs))
   - `EditTovarPage`: Керує інтерфейсом користувача для редагування існуючого продукту. ([EditTovarPage.cs](Inventory/Inventory/Forms/EditTovarPage.cs))
   - `ShowSuppliersForm`: Відображає інформацію про постачальників. ([ShowSuppliersForm.cs](Inventory/Inventory/Forms/ShowSuppliersForm.cs))
   - `ShowTovar`: Відображає інформацію про продукти. ([ShowTovar.cs](Inventory/Inventory/Forms/ShowTovar.cs))
   - `MainForm`: Основна форма інтерфейсу користувача для різних операцій. ([MainForm.cs](Inventory/Inventory/Forms/MainForm.cs))
#### 
2. **DRY (Don't Repeat Yourself)**:
   - Створюються багаторазові методи, щоб уникнути дублювання коду. Наприклад, методи `ExecuteNonQuery` та `ExecuteReader` в `ProductRepository`. ([ProductRepository.cs](Inventory/ClassLibrary/Repositories/ProductRepository.cs))
#### 
3. **KISS (Keep It Simple, Stupid)**:
   - Код залишається простим і зрозумілим. Методи є лаконічними і зосереджені на виконанні однієї задачі. Наприклад, `LoadProducts` та `DisplayProducts` в `ShowTovar`. ([ShowTovar.cs](Inventory/Inventory/Forms/ShowTovar.cs))
####
4. **SOLID Principles**:
   - **Single Responsibility Principle (SRP)**: Кожен клас має одну відповідальність.
   - **Open/Closed Principle (OCP)**: Класи відкриті для розширення, але закриті для модифікації. Наприклад, можна додавати нові класи команд, не змінюючи існуючі. ([AddProductCommand.cs](Inventory/ClassLibrary/Commands/AddProductCommand.cs))
   - **Liskov Substitution Principle (LSP)**: Підтипи повинні бути взаємозамінними з їх базовими типами. Наприклад, `AddProductCommand` може замінити `ProductCommandBase`. ([AddProductCommand.cs](Inventory/ClassLibrary/Commands/AddProductCommand.cs))
   - **Interface Segregation Principle (ISP)**: Інтерфейси мають бути маленькими і специфічними. Наприклад, `IProductRepository` та `ISupplierRepository` специфічні для своїх операцій. ([IProductRepository.cs](Inventory/ClassLibrary/Interfaces/IProductRepository.cs) та [ISupplierRepository.cs](Inventory/ClassLibrary/Interfaces/ISupplierRepository.cs))
   - **Dependency Inversion Principle (DIP)**: Модулі високого рівня залежать від абстракцій, а не від модулів низького рівня. Наприклад, `MainController` залежить від інтерфейсів `IProductRepository` та `ISupplierRepository`. ([MainController.cs](Inventory/ClassLibrary/Controllers/MainController.cs))
####
5. **YAGNI (You Aren't Gonna Need It)**:
   - Реалізується тільки необхідна функціональність. Наприклад, до `MainController` додаються лише необхідні методи. ([MainController.cs](Inventory/ClassLibrary/Controllers/MainController.cs))
####
6. **Composition Over Inheritance**:
   - Проект використовує композицію замість наслідування для досягнення повторного використання коду та гнучкості. Наприклад, `MainController` складається з `IProductRepository` та `ISupplierRepository`. ([MainController.cs](Inventory/ClassLibrary/Controllers/MainController.cs))
####
7. **Fail Fast**:
   - Код перевіряє на наявність помилок на ранніх етапах і негайно завершується у разі виявлення помилки. Наприклад, конструктори викидають виключення, якщо залежності дорівнюють null. ([AddTovarPage.cs](Inventory/Inventory/Forms/AddTovarPage.cs) та [EditTovarPage.cs](Inventory/Inventory/Forms/EditTovarPage.cs))
##
## Refactoring Techniques

1. **Extract Method**:
   - Методи розділені на менші, багаторазові функції для поліпшення читабельності та підтримуваності.
   - Приклад: `LoadProducts`, `DisplayProducts`, `SetColumnHeaders` в `ShowTovar`. ([ShowTovar.cs](Inventory/Inventory/Forms/ShowTovar.cs))
####
2. **Introduce Parameter**:
   - У методи введені параметри для передачі необхідних даних, що забезпечує гнучкість та багаторазовість.
   - Приклад: `LoadProductsSorted` в `ShowTovar`. ([ShowTovar.cs](Inventory/Inventory/Forms/ShowTovar.cs))
####
3. **Encapsulate Field**:
   - Приватні поля використовуються для зберігання стану залежностей, що забезпечує кращу інкапсуляцію.
   - Приклад: `_mainController`, `_selectedProductId` в `MainForm`. ([MainForm.cs](Inventory/Inventory/Forms/MainForm.cs))
##
## Design Patterns

1. **Command Pattern**:
   - **Опис**: Інкапсулює запит як об'єкт, що дозволяє параметризувати клієнтів з різними запитами, ставити запити в чергу або вести журнал запитів.
   - **Використання**: Класи `ProductCommandBase`, `AddProductCommand`, `UpdateProductCommand`, `DeleteProductCommand` та `GetProductByIdQuery` реалізують шаблон Команди, інкапсулюючи різні операції над продуктами.
   - **Приклад**: ([AddProductCommand.cs](Inventory/ClassLibrary/Commands/AddProductCommand.cs)).
####
2. **Repository Pattern**:
   - **Опис**: Інкапсулює логіку доступу до даних, забезпечуючи централізований інтерфейс для CRUD-операцій.
   - **Використання**: Реалізовано в класах `ProductRepository` та `SupplierRepository` для обробки операцій з базою даних для продуктів та постачальників відповідно.
   - **Приклад**: [ProductRepository.cs](Inventory/ClassLibrary/Repositories/ProductRepository.cs) та [SupplierRepository.cs](Inventory/ClassLibrary/Repositories/SupplierRepository.cs).
####
3. **Mediator Pattern**:
   - **Опис**: Шаблон Посередника надає спосіб спілкування між об'єктами без необхідності посилатися один на одного безпосередньо, сприяючи слабкій зв'язності.
   - **Використання**: `MainController` діє як посередник між формами інтерфейсу користувача (такими як `AddTovarPage`, `EditTovarPage`, `ShowSuppliersForm` та `ShowTovar`) і бізнес-логікою.
   - **Приклад**: [MainController.cs](Inventory/ClassLibrary/Controllers/MainController.cs).
####
4. **Factory Method Pattern**:
   - **Опис**: Визначає інтерфейс для створення об'єкта, але дозволяє підкласам змінювати тип створюваних об'єктів.
   - **Використання**: Метод `GetConnection` в `ProductRepository` та `SupplierRepository` діє як фабричний метод для створення екземплярів `MySqlConnection`.
   - **Приклад**: [ProductRepository.cs](Inventory/ClassLibrary/Repositories/ProductRepository.cs) та [SupplierRepository.cs](Inventory/ClassLibrary/Repositories/SupplierRepository.cs).
####
5. **Template Method Pattern**:
   - **Опис**: Визначає скелет алгоритму в методі, відкладаючи деякі кроки до підкласів.
   - **Використання**: Методи `ExecuteNonQuery`, `ExecuteReader` та `ExecuteReaderSingle` в `ProductRepository` використовують шаблон Шаблонного Методу для визначення послідовності кроків для виконання SQL-команд, дозволяючи підкласам надавати конкретні деталі запиту.
   - **Приклад**: [ProductRepository.cs](Inventory/ClassLibrary/Repositories/ProductRepository.cs).