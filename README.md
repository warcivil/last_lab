

# last_lab
последняя лабораторная работа по дисциплине администрирование информационных систем

1) Виртуальная сеть малого предприятия, "стартапа", состоящего из студентов. Денег - нет, офиса - нет, есть оборудование (ноутбуки, телефоны...) и Сеть. Предприятие занимается дизайном стикеров для соцсетей и по-мелочи торгует разным через соц площадки. Необходимо обеспечить единое файловое пространство на компьютерах участников, резервное копирование данных, обмен контактами, ведение проектов (контроль версий). 

группа: 
Чупахин Андрей
Балуев Руслан

мы развернули radmin vpn и на основе его сделали внутренние папки на двух компьютерах 
1 экземпляр папки на другом компьютере
![Screenshot_1](https://user-images.githubusercontent.com/36387132/115717201-5fefc080-a393-11eb-9cf1-08d58d289ee5.png)

2 основная папка

![изображение](https://user-images.githubusercontent.com/36387132/115717284-75fd8100-a393-11eb-888d-b38fb6faafce.png)

в папке находятся репозитории проекта и так же бэкап, но основной бэкап находится в google диск
эта папка доступна только разрабочикам проекта

![изображение](https://user-images.githubusercontent.com/36387132/115717647-cecd1980-a393-11eb-88ee-0f144e9d13ba.png)

для хранения контактов была создана программа с базой данных, база данных распологается в интернете:
remotemysql.com

здесь вводятся контакты и добавляются в бд после добавления они отображаются в таблице

![изображение](https://user-images.githubusercontent.com/36387132/115717803-f9b76d80-a393-11eb-9374-5fb69315f725.png)

так же был создан github репозиторй на 2 человек и создана дополнительная ветка dev_1

