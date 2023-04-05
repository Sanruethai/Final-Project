# Final-Project
### ความเป็นมาของโปรแกรม
= เช็คสต็อกสินค้า เพราะว่าการใช้คนเช็คอาจผิดพลาดมากกว่าใช้โปรแกรมในการเช็ค
### จุดประสงค์ของโปรแกรม
= เพื่อบักทึกสินค้าและข้อมูลสินค้า ได้อย่างรวดเร็ว
### โครงสร้างของโปรแกรม (class diagram)

```mermaid
classDiagram
    Program <|-- NikeNy
    NikeNy <|-- Court_Vision_Low_Next_Nature_1
    NikeNy <|-- Court_Vision_Low_Next_Nature_2
    NikeNy <|-- Court_Legacy_Lift_3
    NikeNy <|-- Court_Vision_Alta_4
    NikeNy <|-- Court Vision Alta_5
    NikeNy <|-- Court_Legacy_Lift_6
    NikeNy <|-- Court VisionLow_7
    Program : +Main()
    class NikeNy{
        +openToolStripMenuItem_Click()
        +saveToolStripMenuItem_Click()
        +button2_Click()
    }
    class Court_Vision_Low_Next_Nature_1{
        +getName()
        +getColor()
        +getPrice()
        
    }
    class Court_Vision_Low_Next_Nature_2{
        +getName()
        +getColor()
        +getPrice()
    }
    class Court_Legacy_Lift_3{
        +getName()
        +getColor()
        +getPrice()    
    }
    class Court_Vision_Alta_4{
        +getName()
        +getColor()
        +getPrice()
    }
    class Court Vision Alta_5{
        +getName()
        +getColor()
        +getPrice()
    }
    class Court_Legacy_Lift_6{
        +getName()
        +getColor()
        +getPrice()
    }
    class Court VisionLow_7{
        +getName()
        +getColor()
        +getPrice()
    }
```
### ผู้พัฒนาโปรแกรม
