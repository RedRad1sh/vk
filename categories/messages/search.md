---
layout: default
title: Метод Messages.Search
permalink: messages/search/
comments: true
---
# Метод Messages.Search
Возвращает список найденных личных сообщений текущего пользователя по введенной строке поиска.

## Синтаксис
```csharp
public ReadOnlyCollection<Message> Search(
	string query, 
	out int totalCount, 
	int? count = null, 
	int? offset = null
)
```

## Параметры
+ **query** - Подстрока, по которой будет производиться поиск.
+ **totalCount** - Общее количество найденных сообщений.
+ **count** - Количество сообщений, которое необходимо получить (но не более 100).
+ **offset** - Смещение, необходимое для выборки определенного подмножества сообщений из списка найденных.

## Результат
Список личных сообщений пользователя, удовлетворяющих условиям запроса.

## Исключения

## Пример
```csharp
// TODO:
```