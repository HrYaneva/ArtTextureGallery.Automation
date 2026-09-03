ArtTextureGallery.Automation/
│
├── Drivers/
│   └── WebDriverFactory.cs
│
├── Pages/
│   ├── GalleryPage.cs
│   ├── ArtworkDetailsPage.cs
│   ├── FavoritesPage.cs
│   └── OrderFormPage.cs
│
├── Tests/
│   ├── GalleryTests.cs
│   ├── ArtworkDetailsTests.cs
│   ├── FavoritesTests.cs
│   └── OrderFormTests.cs
│
└── Utils/
    └── TestConfig.cs
Technology Stack
C# (.NET 6+)

Selenium WebDriver

NUnit

ChromeDriver

Page Object Model (POM)

Test Coverage
Gallery
Зареждане на галерията

Филтриране по текстура

Проверка на броя елементи

Artwork Details
Проверка на заглавие

Проверка на текстура

Проверка на размери

Проверка на цена

Favorites
Добавяне в любими

Премахване от любими

Проверка на броя

Order Form
Валидно изпращане

Празни полета

Невалиден email

How to Run Tests
1. Install dependencies
В Visual Studio → Manage NuGet Packages:

Selenium.WebDriver

Selenium.Support

Selenium.WebDriver.ChromeDriver

NUnit

NUnit3TestAdapter

Microsoft.NET.Test.Sdk

2. Execute tests
От Test Explorer → Run All

Author
Hristinka Yaneva  
QA Automation Engineer (C# / Selenium)