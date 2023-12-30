**Оринчук Андрей Васильевич**
===============================
Группа: ИП-20-7К
-------------------------------
Тема: Стройка
-------------------------------
![image](https://github.com/Dr4mple/Stroyka/assets/104494492/0c61ac74-bf6c-4430-9279-af8ee7a85a30)
-------------------------------
```mermaid
erDiagram
    Zakazhik ||--o{ Rabota : places
    Zakazhik {
        int ZakazhikId
        string Name
        string Address
        int Telefon
    }
  
    Rabota {
        int ZakazhikId
        string Name
        string Ispolnitel
        int Price
    }
  Material ||--o{ Rabota: is
    Material {
        string Name
        int Edizmer
        int Value
        int Price
    }
 Rabotnik ||--o{ Rabota: is
  Rabotnik {
    string Name
    int Index
    string Adres
    int Number
    string Email
   }
```
