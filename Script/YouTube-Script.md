# สคริปต์การสอน: WPF Episode 09 - ScrollViewer

## เนื้อหาที่จะสอน

### 1. ScrollViewer คืออะไร
- Control สำหรับแสดงเนื้อหาที่ยาวเกินพื้นที่
- แสดง Scrollbar อัตโนมัติ
- รองรับ Mouse Wheel และ Touch

### 2. ScrollViewer Properties
- VerticalScrollBarVisibility - แสดง Scrollbar แนวตั้ง
- HorizontalScrollBarVisibility - แสดง Scrollbar แนวนอน
- CanContentScroll - เปิด/ปิด Virtualization
- PanningMode - รองรับ Touch

### 3. การใช้งาน
- แสดง Long Text
- Image Gallery
- List/Table ที่มีข้อมูลเยอะ
- Form ที่ยาว

---

## ส่วนที่ 1: Introduction (0:00 - 2:00)

**สวัสดีครับทุกคน**

ยินดีต้อนรับกลับมาสู่ WPF Tutorial Series ของเรา

วันนี้เราจะมาเรียนรู้เกี่ยวกับ **ScrollViewer** ซึ่งเป็น Control ที่สำคัญมาก!

คุณเคยเจอปัญหาไหมครับ ที่เนื้อหายาวเกินไป ไม่พอดีกับหน้าจอ?

**ScrollViewer ช่วยแก้ปัญหานี้ได้!**

ScrollViewer จะแสดง **Scrollbar** ให้อัตโนมัติ เมื่อเนื้อหายาวเกินพื้นที่ที่มี!

รองรับทั้ง Mouse Wheel, Scrollbar, และ Touch Screen!

---

## ส่วนที่ 2: ScrollViewer พื้นฐาน (2:00 - 6:00)

### Demo 2.1: Vertical Scrolling

```xml
<ScrollViewer Height="200" 
              VerticalScrollBarVisibility="Auto">
    <StackPanel>
        <TextBlock Text="Line 1" Margin="5"/>
        <TextBlock Text="Line 2" Margin="5"/>
        <TextBlock Text="Line 3" Margin="5"/>
        <TextBlock Text="Line 4" Margin="5"/>
        <TextBlock Text="Line 5" Margin="5"/>
        <TextBlock Text="Line 6" Margin="5"/>
        <TextBlock Text="Line 7" Margin="5"/>
        <TextBlock Text="Line 8" Margin="5"/>
        <TextBlock Text="Line 9" Margin="5"/>
        <TextBlock Text="Line 10" Margin="5"/>
    </StackPanel>
</ScrollViewer>
```

**อธิบาย:**
- `Height="200"` - กำหนดความสูง ScrollViewer
- `VerticalScrollBarVisibility="Auto"` - แสดง Scrollbar เมื่อจำเป็น
- เนื้อหาภายใน StackPanel ยาวเกิน 200 pixels
- Scrollbar จะปรากฏอัตโนมัติ!

### Demo 2.2: ทดสอบการเลื่อน

ลองเลื่อนดู!
- ใช้ Mouse Wheel
- คลิกลาก Scrollbar
- หรือใช้ Touch Screen (ถ้ามี)

**มันทำงานได้ราบรื่นมาก!**

---

## ส่วนที่ 3: ScrollBarVisibility (6:00 - 12:00)

### Demo 3.1: VerticalScrollBarVisibility

มี 4 ค่าให้เลือก:

**Auto** - แสดงเมื่อจำเป็น (แนะนำ)
```xml
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <!-- Content -->
</ScrollViewer>
```

**Visible** - แสดงเสมอ
```xml
<ScrollViewer VerticalScrollBarVisibility="Visible">
    <!-- Content -->
</ScrollViewer>
```

**Hidden** - ซ่อน แต่ยังเลื่อนได้
```xml
<ScrollViewer VerticalScrollBarVisibility="Hidden">
    <!-- Content -->
</ScrollViewer>
```

**Disabled** - ปิดการเลื่อนแนวตั้งเลย
```xml
<ScrollViewer VerticalScrollBarVisibility="Disabled">
    <!-- Content -->
</ScrollViewer>
```

### Demo 3.2: เปรียบเทียบ

**Auto vs Visible:**
```xml
<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="*"/>
        <ColumnDefinition Width="*"/>
    </Grid.ColumnDefinitions>
    
    <!-- Auto: แสดงเมื่อจำเป็น -->
    <ScrollViewer Grid.Column="0" Height="150" 
                  VerticalScrollBarVisibility="Auto"
                  Margin="10">
        <StackPanel>
            <TextBlock Text="Auto Mode" FontWeight="Bold"/>
            <TextBlock Text="Line 1"/>
            <TextBlock Text="Line 2"/>
            <TextBlock Text="Line 3"/>
        </StackPanel>
    </ScrollViewer>
    
    <!-- Visible: แสดงเสมอ -->
    <ScrollViewer Grid.Column="1" Height="150" 
                  VerticalScrollBarVisibility="Visible"
                  Margin="10">
        <StackPanel>
            <TextBlock Text="Visible Mode" FontWeight="Bold"/>
            <TextBlock Text="Line 1"/>
            <TextBlock Text="Line 2"/>
            <TextBlock Text="Line 3"/>
        </StackPanel>
    </ScrollViewer>
</Grid>
```

**เห็นความแตกต่างไหมครับ:**
- Auto: Scrollbar ปรากฏเมื่อเนื้อหายาว
- Visible: Scrollbar แสดงเสมอ แม้เนื้อหาสั้น

---

## ส่วนที่ 4: Horizontal Scrolling (12:00 - 16:00)

### Demo 4.1: HorizontalScrollBarVisibility

```xml
<ScrollViewer Height="100" 
              VerticalScrollBarVisibility="Disabled"
              HorizontalScrollBarVisibility="Auto">
    <StackPanel Orientation="Horizontal">
        <Border Width="100" Height="60" Background="Red" Margin="5"/>
        <Border Width="100" Height="60" Background="Orange" Margin="5"/>
        <Border Width="100" Height="60" Background="Yellow" Margin="5"/>
        <Border Width="100" Height="60" Background="Green" Margin="5"/>
        <Border Width="100" Height="60" Background="Blue" Margin="5"/>
        <Border Width="100" Height="60" Background="Purple" Margin="5"/>
    </StackPanel>
</ScrollViewer>
```

**อธิบาย:**
- `VerticalScrollBarVisibility="Disabled"` - ปิดการเลื่อนแนวตั้ง
- `HorizontalScrollBarVisibility="Auto"` - เปิดการเลื่อนแนวนอน
- StackPanel Orientation="Horizontal" - เรียงแนวนอน
- เลื่อนดูรูปได้!

### Demo 4.2: Image Gallery

```xml
<ScrollViewer HorizontalScrollBarVisibility="Auto"
              VerticalScrollBarVisibility="Disabled"
              Height="200">
    <StackPanel Orientation="Horizontal">
        <Image Source="photo1.jpg" Width="200" Margin="5"/>
        <Image Source="photo2.jpg" Width="200" Margin="5"/>
        <Image Source="photo3.jpg" Width="200" Margin="5"/>
        <Image Source="photo4.jpg" Width="200" Margin="5"/>
        <Image Source="photo5.jpg" Width="200" Margin="5"/>
    </StackPanel>
</ScrollViewer>
```

เหมาะมากสำหรับ Horizontal Image Gallery!

---

## ส่วนที่ 5: Both Direction Scrolling (16:00 - 20:00)

### Demo 5.1: เลื่อนทั้ง 2 ทิศทาง

```xml
<ScrollViewer Height="300" Width="400"
              VerticalScrollBarVisibility="Auto"
              HorizontalScrollBarVisibility="Auto">
    <Grid Width="800" Height="600" Background="LightGray">
        <!-- Content ขนาดใหญ่ -->
        <TextBlock Text="Large Content Area" 
                   FontSize="48" 
                   HorizontalAlignment="Center" 
                   VerticalAlignment="Center"/>
    </Grid>
</ScrollViewer>
```

**เลื่อนได้ทั้งขึ้น-ลง และซ้าย-ขวา!**

### Demo 5.2: Table/Grid ขนาดใหญ่

```xml
<ScrollViewer Height="300" Width="500"
              VerticalScrollBarVisibility="Auto"
              HorizontalScrollBarVisibility="Auto">
    <Grid Width="800" Height="600">
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>
        
        <Border Grid.Row="0" Grid.Column="0" Background="Red" Margin="5">
            <TextBlock Text="A1" HorizontalAlignment="Center" 
                       VerticalAlignment="Center" FontSize="24" 
                       Foreground="White" FontWeight="Bold"/>
        </Border>
        <Border Grid.Row="0" Grid.Column="1" Background="Orange" Margin="5">
            <TextBlock Text="B1" HorizontalAlignment="Center" 
                       VerticalAlignment="Center" FontSize="24" 
                       Foreground="White" FontWeight="Bold"/>
        </Border>
        <Border Grid.Row="0" Grid.Column="2" Background="Yellow" Margin="5">
            <TextBlock Text="C1" HorizontalAlignment="Center" 
                       VerticalAlignment="Center" FontSize="24"/>
        </Border>
        <Border Grid.Row="0" Grid.Column="3" Background="Green" Margin="5">
            <TextBlock Text="D1" HorizontalAlignment="Center" 
                       VerticalAlignment="Center" FontSize="24" 
                       Foreground="White" FontWeight="Bold"/>
        </Border>
        
        <!-- More cells... -->
    </Grid>
</ScrollViewer>
```

เหมาะมากสำหรับ Data Table ที่มีข้อมูลเยอะ!

---

## ส่วนที่ 6: Use Cases (20:00 - 27:00)

### 6.1 Long Form

```xml
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <StackPanel Margin="20">
        <TextBlock Text="Registration Form" 
                   FontSize="24" FontWeight="Bold" 
                   Margin="0,0,0,20"/>
        
        <TextBlock Text="First Name:"/>
        <TextBox Margin="0,5,0,15"/>
        
        <TextBlock Text="Last Name:"/>
        <TextBox Margin="0,5,0,15"/>
        
        <TextBlock Text="Email:"/>
        <TextBox Margin="0,5,0,15"/>
        
        <TextBlock Text="Phone:"/>
        <TextBox Margin="0,5,0,15"/>
        
        <TextBlock Text="Address:"/>
        <TextBox Margin="0,5,0,15"/>
        
        <TextBlock Text="City:"/>
        <TextBox Margin="0,5,0,15"/>
        
        <TextBlock Text="Country:"/>
        <ComboBox Margin="0,5,0,15"/>
        
        <TextBlock Text="Notes:"/>
        <TextBox Height="100" TextWrapping="Wrap" 
                 AcceptsReturn="True" Margin="0,5,0,15"/>
        
        <Button Content="Submit" Width="100" 
                HorizontalAlignment="Left"/>
    </StackPanel>
</ScrollViewer>
```

Form ยาวๆ ไม่เกินหน้าจอแล้ว!

### 6.2 Long Text/Article

```xml
<ScrollViewer VerticalScrollBarVisibility="Auto" Padding="20">
    <StackPanel>
        <TextBlock Text="Article Title" 
                   FontSize="28" FontWeight="Bold" 
                   Margin="0,0,0,20"/>
        
        <TextBlock TextWrapping="Wrap" Margin="0,10">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
            Sed do eiusmod tempor incididunt ut labore et dolore magna 
            aliqua. Ut enim ad minim veniam, quis nostrud exercitation 
            ullamco laboris nisi ut aliquip ex ea commodo consequat.
        </TextBlock>
        
        <TextBlock TextWrapping="Wrap" Margin="0,10">
            Duis aute irure dolor in reprehenderit in voluptate velit 
            esse cillum dolore eu fugiat nulla pariatur. Excepteur sint 
            occaecat cupidatat non proident, sunt in culpa qui officia 
            deserunt mollit anim id est laborum.
        </TextBlock>
        
        <!-- More paragraphs... -->
    </StackPanel>
</ScrollViewer>
```

### 6.3 List/DataGrid

```xml
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <ListBox>
        <ListBoxItem Content="Item 1"/>
        <ListBoxItem Content="Item 2"/>
        <ListBoxItem Content="Item 3"/>
        <!-- ... 100 items ... -->
        <ListBoxItem Content="Item 100"/>
    </ListBox>
</ScrollViewer>
```

**หมายเหตุ:** ListBox มี ScrollViewer ในตัวอยู่แล้ว!

### 6.4 Settings Panel

```xml
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <StackPanel Margin="20">
        <GroupBox Header="General Settings" Margin="0,10">
            <StackPanel>
                <CheckBox Content="Enable notifications"/>
                <CheckBox Content="Auto-save" Margin="0,5"/>
                <CheckBox Content="Dark mode" Margin="0,5"/>
            </StackPanel>
        </GroupBox>
        
        <GroupBox Header="Display Settings" Margin="0,10">
            <StackPanel>
                <TextBlock Text="Font Size:"/>
                <Slider Minimum="10" Maximum="24" Value="14"/>
                <TextBlock Text="Zoom:"/>
                <Slider Minimum="50" Maximum="200" Value="100"/>
            </StackPanel>
        </GroupBox>
        
        <GroupBox Header="Privacy Settings" Margin="0,10">
            <StackPanel>
                <CheckBox Content="Share usage data"/>
                <CheckBox Content="Allow cookies" Margin="0,5"/>
                <CheckBox Content="Track location" Margin="0,5"/>
            </StackPanel>
        </GroupBox>
        
        <!-- More settings... -->
    </StackPanel>
</ScrollViewer>
```

---

## ส่วนที่ 7: Advanced Properties (27:00 - 31:00)

### 7.1 CanContentScroll

```xml
<ScrollViewer CanContentScroll="True">
    <ListBox>
        <!-- Items -->
    </ListBox>
</ScrollViewer>
```

**CanContentScroll:**
- `True` = เลื่อนทีละ Item (Logical Scrolling)
- `False` = เลื่อนทีละ Pixel (Physical Scrolling)
- เปิด Virtualization ให้ ListBox

### 7.2 PanningMode

```xml
<ScrollViewer PanningMode="Both">
    <!-- Content -->
</ScrollViewer>
```

**PanningMode:** รองรับ Touch Screen
- `None` - ไม่รองรับ Touch
- `HorizontalOnly` - Touch แนวนอนอย่างเดียว
- `VerticalOnly` - Touch แนวตั้งอย่างเดียว
- `Both` - Touch ทั้ง 2 ทิศทาง (แนะนำ)

### 7.3 ScrollChanged Event

```xml
<ScrollViewer ScrollChanged="ScrollViewer_ScrollChanged">
    <!-- Content -->
</ScrollViewer>
```

**Code Behind:**
```csharp
private void ScrollViewer_ScrollChanged(object sender, 
                                        ScrollChangedEventArgs e)
{
    var scrollViewer = (ScrollViewer)sender;
    
    // ตำแหน่งปัจจุบัน
    double verticalOffset = scrollViewer.VerticalOffset;
    double horizontalOffset = scrollViewer.HorizontalOffset;
    
    // Viewport Size
    double viewportHeight = scrollViewer.ViewportHeight;
    double viewportWidth = scrollViewer.ViewportWidth;
    
    // Content Size
    double scrollableHeight = scrollViewer.ScrollableHeight;
    double scrollableWidth = scrollViewer.ScrollableWidth;
    
    // Check if scrolled to bottom
    if (verticalOffset >= scrollableHeight)
    {
        MessageBox.Show("Reached bottom!");
    }
}
```

### 7.4 Programmatic Scrolling

```csharp
// เลื่อนไปตำแหน่งที่ต้องการ
scrollViewer.ScrollToVerticalOffset(100);
scrollViewer.ScrollToHorizontalOffset(50);

// เลื่อนไปบนสุด
scrollViewer.ScrollToTop();

// เลื่อนไปล่างสุด
scrollViewer.ScrollToBottom();

// เลื่อนไปซ้ายสุด
scrollViewer.ScrollToLeftEnd();

// เลื่อนไปขวาสุด
scrollViewer.ScrollToRightEnd();
```

---

## ส่วนที่ 8: Tips & Best Practices (31:00 - 34:00)

### 8.1 ใช้ Auto แทน Visible

```xml
<!-- ✅ ดี: ใช้ Auto -->
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <!-- Content -->
</ScrollViewer>

<!-- ⚠️ ไม่แนะนำ: Visible แสดงเสมอ -->
<ScrollViewer VerticalScrollBarVisibility="Visible">
    <!-- Content -->
</ScrollViewer>
```

### 8.2 กำหนดขนาด ScrollViewer

```xml
<!-- ✅ ดี: กำหนดขนาดชัดเจน -->
<ScrollViewer Height="400" Width="600">
    <!-- Content -->
</ScrollViewer>

<!-- ⚠️ ระวัง: ไม่กำหนดขนาด อาจไม่เห็น Scrollbar -->
<ScrollViewer>
    <!-- Content -->
</ScrollViewer>
```

### 8.3 Nested ScrollViewer

```xml
<!-- ❌ หลีกเลี่ยง: ScrollViewer ซ้อน ScrollViewer -->
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <ScrollViewer VerticalScrollBarVisibility="Auto">
        <!-- Content -->
    </ScrollViewer>
</ScrollViewer>
```

จะทำให้สับสน และใช้งานยาก!

### 8.4 Performance

- ScrollViewer เหมาะกับเนื้อหาไม่มากเกินไป
- ถ้ามีข้อมูลเยอะ (1000+ items) ใช้ **VirtualizingStackPanel**
- เปิด **CanContentScroll="True"** สำหรับ ListBox

---

## ส่วนที่ 9: Wrap Up และ Outro (34:00 - 36:00)

**สรุปสิ่งที่เราได้เรียนรู้วันนี้:**

1. ✅ ScrollViewer = แสดงเนื้อหาที่ยาวเกินพื้นที่
2. ✅ VerticalScrollBarVisibility - Auto, Visible, Hidden, Disabled
3. ✅ HorizontalScrollBarVisibility - เลื่อนแนวนอน
4. ✅ รองรับ Mouse Wheel และ Touch Screen
5. ✅ Use Cases: Long Form, Article, List, Settings
6. ✅ Advanced: CanContentScroll, PanningMode
7. ✅ Programmatic Scrolling

**ScrollViewer เหมาะสำหรับ:**
- Long Form (แบบฟอร์มยาว)
- Article/Blog (บทความยาว)
- List/Table (รายการเยอะ)
- Settings Panel (ตั้งค่าเยอะ)
- Image Gallery (แนวนอน)

**จุดเด่นของ ScrollViewer:**
- Scrollbar แสดงอัตโนมัติ
- รองรับ Mouse Wheel
- รองรับ Touch Screen
- ใช้ง่าย

**ในตอนต่อไป:**

เราจะมาเรียนรู้เกี่ยวกับ **Border** ซึ่งเป็น Control สำหรับสร้าง
กรอบรอบๆ Element พร้อม BorderBrush, CornerRadius, และ Padding!

**อย่าลืม:**
- กด Like ถ้าชอบ
- Subscribe เพื่อติดตามตอนต่อไป
- Comment บอกว่าอยากเรียนเรื่องอะไรต่อไป

**ขอบคุณที่รับชมครับ แล้วพบกันใหม่ตอนหน้า สวัสดีครับ!**

---

## เอกสารอ้างอิง

### Official Documentation
- [ScrollViewer Class - Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollviewer)
- [ScrollBarVisibility Enum - Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollbarvisibility)

### Properties Reference
```
VerticalScrollBarVisibility: Auto, Visible, Hidden, Disabled
HorizontalScrollBarVisibility: Auto, Visible, Hidden, Disabled
CanContentScroll: Boolean (Logical vs Physical Scrolling)
PanningMode: None, HorizontalOnly, VerticalOnly, Both
VerticalOffset: Double (ตำแหน่งแนวตั้ง)
HorizontalOffset: Double (ตำแหน่งแนวนอน)
ViewportHeight: Double (ความสูงที่มองเห็น)
ViewportWidth: Double (ความกว้างที่มองเห็น)
ScrollableHeight: Double (ความสูงที่เลื่อนได้)
ScrollableWidth: Double (ความกว้างที่เลื่อนได้)
```

### Methods Reference
```csharp
ScrollToTop()
ScrollToBottom()
ScrollToLeftEnd()
ScrollToRightEnd()
ScrollToVerticalOffset(double offset)
ScrollToHorizontalOffset(double offset)
LineUp()
LineDown()
LineLeft()
LineRight()
PageUp()
PageDown()
PageLeft()
PageRight()
```

---

## Tips & Best Practices

1. **Use Auto**: ใช้ ScrollBarVisibility="Auto" เป็นค่าเริ่มต้น
2. **Set Size**: กำหนดขนาด ScrollViewer ให้ชัดเจน
3. **Avoid Nesting**: หลีกเลี่ยง ScrollViewer ซ้อนกัน
4. **Virtualization**: เปิด CanContentScroll สำหรับ List ขนาดใหญ่

---

## Common Mistakes (ข้อผิดพลาดที่พบบ่อย)

### ❌ ไม่กำหนดขนาด ScrollViewer
```xml
<!-- ผิด: ScrollViewer จะขยายตาม Content -->
<ScrollViewer>
    <StackPanel>
        <!-- Long content -->
    </StackPanel>
</ScrollViewer>
```

### ✅ ถูกต้อง
```xml
<ScrollViewer Height="400">
    <StackPanel>
        <!-- Long content -->
    </StackPanel>
</ScrollViewer>
```

### ❌ ScrollViewer ซ้อนกัน
```xml
<!-- ผิด: สับสน -->
<ScrollViewer>
    <ScrollViewer>
        <!-- Content -->
    </ScrollViewer>
</ScrollViewer>
```

### ✅ ถูกต้อง
```xml
<ScrollViewer>
    <!-- Content directly -->
</ScrollViewer>
```

### ❌ ใช้ ScrollViewer กับ Control ที่มี ScrollViewer อยู่แล้ว
```xml
<!-- ผิด: ListBox มี ScrollViewer อยู่แล้ว -->
<ScrollViewer>
    <ListBox>
        <!-- Items -->
    </ListBox>
</ScrollViewer>
```

### ✅ ถูกต้อง
```xml
<!-- ListBox มี ScrollViewer ในตัว -->
<ListBox>
    <!-- Items -->
</ListBox>
```

---

## Code Examples Repository

Source code สำหรับ Episode นี้สามารถดาวน์โหลดได้ที่:
- GitHub: [WPF_Episode09_ScrollViewer](https://github.com/koson/WPF_Episode09_ScrollViewer)

---

**End of Script**