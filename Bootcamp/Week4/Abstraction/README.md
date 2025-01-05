# Abstraction Örneği

Bu proje, C# programlama dilinde **Soyutlama (Abstraction)** kavramını göstermektedir. Proje, çalışanların görevlerini tanımlayan bir soyut sınıf ve ondan türetilen sınıfları içerir.

## Özellikler
- **Soyut Sınıf (Employee):**
  - Ortak özellikler (`Name`, `Surname`, `Department`) içerir.
  - `Task()` adında soyut bir metod tanımlar.
- **Alt Sınıflar:**
  - `ProjectManager`: Proje yöneticisi görevlerini tanımlar.
  - `SoftwareDeveloper`: Yazılım geliştirici görevlerini tanımlar.
  - `SalesManager`: Satış yöneticisi görevlerini tanımlar.

## Kullanım

### Örnek Kod:
```csharp
Employee pManager = new ProjectManager()
{
    Name = "Kutay",
    Surname = "Özcan",
    Department = "IT"
};
pManager.Task();
```

### Beklenen Çıktı:
```
Kutay Özcan: Working as Project Manager at IT
```

