# ArtTextureGallery.Automation 🎨🧪  
Automated UI test suite for the ArtTextureGallery web application.  
Built with **C#**, **Selenium WebDriver**, **NUnit**, and **GitHub Actions CI**.

![CI](https://github.com/HrYaneva/ArtTextureGallery.Automation/actions/workflows/ci.yml/badge.svg)

---

## 🚀 Overview

This repository contains a complete UI automation framework for testing the ArtTextureGallery web application.  
It follows industry‑standard best practices:

- Page Object Model (POM)
- NUnit test structure
- Selenium WebDriver
- ChromeDriver auto‑setup
- GitHub Actions CI pipeline
- Automatic test reports (TRX artifacts)

The project is designed to be clean, scalable, and ready for real‑world QA Automation work.

---

## 📁 Project Structure

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
├── Utils/
│   ├── BasePage.cs
│   └── BaseTest.cs
│
├── .github/
│   └── workflows/
│       └── ci.yml
│
├── ArtTextureGallery.Automation.csproj
└── README.md

Код

---

## 🧪 Running Tests Locally

### 1️⃣ Restore dependencies
dotnet restore

Код

### 2️⃣ Run tests
dotnet test

Код

### 3️⃣ Run tests with detailed output
dotnet test --logger "trx;LogFileName=test_results.trx"

Код

---

## 🤖 Continuous Integration (GitHub Actions)

This project includes a full CI pipeline that:

- Installs .NET  
- Installs Chrome  
- Installs ChromeDriver  
- Builds the project  
- Runs all tests  
- Uploads test results as artifacts  

### CI Workflow File

name: CI Automation Tests

on:
push:
branches: [ "main" ]
pull_request:
branches: [ "main" ]

jobs:
build-and-test:
runs-on: ubuntu-latest

steps:
- name: Checkout repository
uses: actions/checkout@v4

name: Setup .NET
uses: actions/setup-dotnet@v4
with:
dotnet-version: '8.0.x'

name: Install Chrome
uses: browser-actions/setup-chrome@v1

name: Install ChromeDriver
uses: nanasess/setup-chromedriver@v2

name: Restore dependencies
run: dotnet restore

name: Build project
run: dotnet build --configuration Release

name: Run tests
run: dotnet test --logger "trx;LogFileName=test_results.trx"

name: Upload test results
uses: actions/upload-artifact@v4
with:
name: test-results
path: '*/.trx'

Код

---

## 📊 Test Reports

After each CI run, GitHub Actions generates:

- TRX test report  
- Full test logs  
- Downloadable artifacts  

You can find them under:

**Actions → Latest workflow → Artifacts**

---

## 🏛 Architecture (POM)

The framework follows the Page Object Model:

- Each page has its own class  
- Each class contains locators + actions  
- Tests call page methods, not raw Selenium commands  
- WebDriver is created through `WebDriverFactory`  
- BasePage contains shared utilities  
- BaseTest handles setup/teardown  

---

## 🧰 Technologies Used

- **C#**
- **Selenium WebDriver**
- **NUnit**
- **ChromeDriver**
- **GitHub Actions**
- **Page Object Model**
- **.NET 8**

---

## 📌 Future Improvements

- Add Allure reports  
- Add parallel test execution  
- Add cross‑browser testing (Firefox, Edge)  
- Add Dockerized Selenium Grid  
- Add screenshot on failure  
- Add logging (Serilog)

---

## 👩‍💻 Author

**Hristinka Yaneva**  
Aspiring Junior Web Developer & QA Automation Engineer  
Passionate about UI automation, clean code, and modern web development.

---

## ⭐ License

This project is open‑source and free to use for learning and portfolio purposes.
