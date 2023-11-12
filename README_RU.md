[English](README.md) | [Русский](README_RU.md)


<p align="center"><h1>⭐ColorUtility for Unity⭐</h1></p>
 <p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
  <img alt="License" src="https://img.shields.io/github/license/RimuruDev/Unity-ColorUtility?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/Unity-ColorUtility?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/Unity-ColorUtility?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/Unity-ColorUtility/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/Unity-ColorUtility?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/Unity-ColorUtility?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/RimuruDev/Unity-ColorUtility?style=flat">
  </a>
</p>


## Описание
ColorUtility - это небольшой и эффективный класс, предназначенный для работы с цветами в Unity. Он позволяет легко преобразовывать шестнадцатеричные цветовые коды (формата RRGGBB) в объекты `Color` Unity. Этот инструмент особенно полезен при работе с цветовыми значениями, получаемыми из внешних источников, таких как веб-API, пользовательские интерфейсы или текстовые файлы.

## Особенности
- Простое преобразование шестнадцатеричных цветовых кодов в объекты `Color` Unity.
- Проверка корректности формата входных данных для повышения устойчивости к ошибкам.
- Легко интегрируется в любой проект Unity.

## Установка
Для использования `ColorUtility` скопируйте файл `ColorUtility.cs` в папку `Scripts` или `Codebase` вашего проекта Unity. Так же можно прсото скачать готовый `.package` в разделе Release.

## Примеры использования

### Преобразование шестнадцатеричной строки в цвет
```csharp
Color color = ColorUtility.HexToColor("FF5733");
```

Этот код преобразует строку "FF5733" в объект Color Unity, который теперь можно использовать для установки цветов в вашей игре или приложении.

## Обработка некорректных входных данных
Если переданная строка имеет некорректный формат, ColorUtility вернет белый цвет и выведет предупреждение в консоль Unity.
```csharp
Color color = ColorUtility.HexToColor("IncorrectFormat"); // Возвращает Color.white
```
## Вклад в проект
Любые предложения по улучшению или отзывы приветствуются! Если у вас есть идеи по улучшению ColorUtility, не стесняйтесь создавать pull request или issue в репозитории на GitHub.

- Telegram канал - https://t.me/DevLogUnity
- Чатик в Telegram - https://t.me/DevLogUnity3d

Лицензия
Этот проект распространяется под лицензией MIT. Подробную информацию смотрите в файле LICENSE.

Автор: RimuruDev
