# Exammination3

# ระบบบันทึกข้อมูลนักศึกษา
ชื่อ นายชาญวิทย์ อุ่นสกุล 
รหัสนักศึกษา 673450187-3
# รายละเอียดโปรแกรม
โปรแกรมนี้สำหรับอาจารย์ใช้งาน
# นักศึกษา
เก็บข้อมูลชื่อ-นามสกุล สาขาที่เรียน อาจารย์ที่ปรึกษา
# อาจารย์ที่ปรึกษา
ชื่อ-นามสกุล สาขาที่สอน และอาจารยืสามารถเข้ามาเช็คขอมูลของนักเรียนแตลละคนได้
# ฟีเจอร์หลัก
# การเพิ่มข้อมูลนักศึกษา
บันทึกข้อมูลนักศึกษา ได้แก่ รหัสนักศึกษา, ชื่อ, สาขาวิชา, เกรด และอาจารย์ที่ปรึกษา
ตรวจสอบความถูกต้องของข้อมูล เช่น เกรดต้องเป็นตัวเลข
# การเพิ่มข้อมูลอาจารย์ที่ปรึกษา
เพิ่มข้อมูลอาจารย์ที่ปรึกษา พร้อมทั้งสาขาวิชาที่ดูแล
เลือกอาจารย์ที่ปรึกษาจากรายการ (ComboBox)
# การแสดงข้อมูลนักศึกษาทั้งหมด
แสดงรายชื่อนักศึกษาทั้งหมดใน ListBox
สามารถเลือกนักศึกษาเพื่อดูรายละเอียดเพิ่มเติมได้
# การค้นหานักศึกษาที่ได้เกรดสูงสุด
แสดงข้อมูลของนักศึกษาที่ได้คะแนนสูงสุดในโปรแกรม

# หลักการเขียนโปรแกรมเชิงวัตถุที่ใช้ในโปรแกรม

# 1. Encapsulation (การปกปิดข้อมูล)

ใช้ private ในการกำหนดฟิลด์ต่าง ๆ ของคลาส เพื่อป้องกันการเข้าถึงข้อมูลโดยตรงจากภายนอก

ใช้ public เมธอดในการเข้าถึงและแก้ไขข้อมูลที่ต้องการผ่านการควบคุมที่ถูกต้อง เช่น การเพิ่มนักศึกษา หรืออาจารย์ที่ปรึกษา

# 2. Abstraction (การซ่อนรายละเอียดที่ไม่จำเป็น)

มีการสร้างคลาสพื้นฐาน Person ที่มีฟิลด์พื้นฐาน เช่น Name

คลาส Student และ Advisor สืบทอดมาจากคลาส Person ซึ่งช่วยลดความซับซ้อนในการจัดการโค้ด

# 3. Polymorphism (พหุสัณฐาน)

ใช้การเขียนเมธอด ToString() ที่แตกต่างกันในคลาส Student เพื่อแสดงข้อมูลในรูปแบบที่ต้องการ

# 4. Inheritance (การสืบทอดคุณสมบัติ)

คลาส Student และ Advisor ถูกออกแบบให้สืบทอดคุณสมบัติจากคลาส Person ทำให้สามารถใช้คุณสมบัติที่คล้ายคลึงกันได้อย่างสะดวก
# วิธีใช่งานโปรแกรม
วิธีใช้งานโปรแกรม

1.เปิดโปรแกรม โดยดับเบิลคลิกที่ไฟล์ .exe หรือรันผ่าน Visual Studio

2.ในส่วน ComboBox (เมนูแบบเลื่อนลง) ให้เลือกชื่ออาจารย์ที่ปรึกษาที่ต้องการ (ถ้าไม่มี สามารถเพิ่มใหม่ได้)

3.กรอกข้อมูลนักศึกษาในช่องที่กำหนด ได้แก่

ID: รหัสนักศึกษา

Name: ชื่อนามสกุล

Major: สาขาที่เรียน

Grade: คะแนนเกรด (ตัวเลขทศนิยม)

4.กดปุ่ม AddStudent เพื่อบันทึกข้อมูลนักศึกษาลงในระบบ

5.กดปุ่ม ShowAll เพื่อแสดงรายชื่อนักศึกษาทั้งหมดที่ถูกบันทึกในระบบ

6.กดปุ่ม ShowTopStudent เพื่อแสดงชื่อนักศึกษาที่มีเกรดสูงสุดพร้อมคะแนนเกรดที่ได้รับ

7.กดที่ชื่อนักศึกษาใน ListBox เพื่อแสดงข้อมูลรายละเอียดของนักศึกษานั้น ๆ
# class diagram

```mermaid
classDiagram
    class Person {
        +string Name
        +string Major
        +Person(string name, string major)
    }
    
    class Student {
        +string ID
        +double Grade
        +Advisor Advisor
        +Student(string id, string name, string major, double grade, Advisor advisor)
    }
    
    class Advisor {
        +List~Student~ Students
        +Advisor(string name, string major)
        +void AddStudent(Student student)
        +string GetStudentList()
    }
    
    class Form1 {
        -List~Student~ students
        -List~Advisor~ advisors
        +Form1()
        +void LoadAdvisors()
        +void btnAddstudent_Click()
        +void btnShowStuent_Click()
        +void UpdateStudentList()
        +void lstStudent_SelectedIndexChanged()
        +void btnShowAll_Click()
    }

    Person <|-- Student
    Person <|-- Advisor
    Advisor "1" -- "*" Student : advises
    Form1 "1" -- "*" Student : manages
    Form1 "1" -- "*" Advisor : manages
'''




