# 📝 Episode 09: ScrollViewer - Quick Reference

> **Problem**: Content is too long for the available space. How to show it all?
> 
> **Solution**: **ScrollViewer** - Automatic scrollbars when content overflows!

---

## 🎯 The Problem ScrollViewer Solves

### Scenario: Long Form

You're building a **registration form** with many fields:

```xml
<!-- ❌ Without ScrollViewer: Content overflows, bottom fields not visible -->
<StackPanel>
    <TextBlock Text="Name:"/>
    <TextBox/>
    <TextBlock Text="Email:"/>
    <TextBox/>
    <TextBlock Text="Address:"/>
    <TextBox/>
    <TextBlock Text="City:"/>
    <TextBox/>
    <TextBlock Text="Country:"/>
    <ComboBox/>
    <TextBlock Text="Phone:"/>
    <TextBox/>
    <TextBlock Text="Notes:"/>
    <TextBox Height="100"/>
    <Button Content="Submit"/>
    <!-- Bottom fields cut off! Can't see or access them! -->
</StackPanel>
```

**Problems:**
- ❌ **Content overflows** - Bottom fields not visible
- ❌ **Can't access** - No way to reach hidden content
- ❌ **Bad UX** - Users can't complete the form

### ScrollViewer Solution

```xml
<ScrollViewer Height="400" VerticalScrollBarVisibility="Auto">
    <StackPanel>
        <TextBlock Text="Name:"/>
        <TextBox/>
        <TextBlock Text="Email:"/>
        <TextBox/>
        <TextBlock Text="Address:"/>
        <TextBox/>
        <TextBlock Text="City:"/>
        <TextBox/>
        <TextBlock Text="Country:"/>
        <ComboBox/>
        <TextBlock Text="Phone:"/>
        <TextBox/>
        <TextBlock Text="Notes:"/>
        <TextBox Height="100"/>
        <Button Content="Submit"/>
        <!-- All fields accessible via scrolling! -->
    </StackPanel>
</ScrollViewer>
```

**Benefits:**
- ✅ **Scrollbar appears** - Automatically when content overflows
- ✅ **All content accessible** - Scroll to see everything
- ✅ **Great UX** - Mouse wheel, scrollbar, touch support
- ✅ **Responsive** - Adapts to window size

---

## 📚 ScrollViewer Basics

### What is ScrollViewer?

**ScrollViewer** = Container that adds scrolling capability

**Think of it like:**
- **Window with blinds** - You see part of the content, scroll to see more
- **Reading a long document** - Scroll up/down to see different parts
- **Viewing a large map** - Pan around to see different areas

### Basic Usage

```xml
<ScrollViewer Height="200" VerticalScrollBarVisibility="Auto">
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

**Result:**
- ScrollViewer height: 200 pixels
- Content height: More than 200 pixels
- Scrollbar appears automatically!
- Scroll to see all lines

---

## 🧭 ScrollBarVisibility Property

### VerticalScrollBarVisibility

Controls vertical scrollbar appearance:

**Auto** (Recommended) - Show when needed:
```xml
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <!-- Scrollbar appears only when content overflows -->
</ScrollViewer>
```

**Visible** - Always show:
```xml
<ScrollViewer VerticalScrollBarVisibility="Visible">
    <!-- Scrollbar always visible, even if content fits -->
</ScrollViewer>
```

**Hidden** - Hide scrollbar, but still scrollable:
```xml
<ScrollViewer VerticalScrollBarVisibility="Hidden">
    <!-- No scrollbar, but can still scroll with mouse wheel -->
</ScrollViewer>
```

**Disabled** - Disable vertical scrolling:
```xml
<ScrollViewer VerticalScrollBarVisibility="Disabled">
    <!-- Cannot scroll vertically at all -->
</ScrollViewer>
```

### Comparison

| Value | Scrollbar Visible? | Can Scroll? | When to Use |
|-------|-------------------|-------------|-------------|
| **Auto** | When needed | ✅ Yes | Most common (recommended) |
| **Visible** | Always | ✅ Yes | Always show scrollbar |
| **Hidden** | Never | ✅ Yes (wheel only) | Clean UI, mouse wheel scrolling |
| **Disabled** | Never | ❌ No | Prevent scrolling |

### HorizontalScrollBarVisibility

Same options for horizontal scrolling:

```xml
<ScrollViewer HorizontalScrollBarVisibility="Auto"
              VerticalScrollBarVisibility="Disabled"
              Height="150">
    <StackPanel Orientation="Horizontal">
        <Border Width="100" Height="100" Background="Red" Margin="5"/>
        <Border Width="100" Height="100" Background="Orange" Margin="5"/>
        <Border Width="100" Height="100" Background="Yellow" Margin="5"/>
        <Border Width="100" Height="100" Background="Green" Margin="5"/>
        <Border Width="100" Height="100" Background="Blue" Margin="5"/>
        <!-- Scroll horizontally to see all colors -->
    </StackPanel>
</ScrollViewer>
```

---

## 💡 Common Patterns

### Pattern 1: Vertical Scrolling (Long Content)

```xml
<ScrollViewer Height="300" VerticalScrollBarVisibility="Auto">
    <StackPanel Margin="10">
        <TextBlock Text="Article Title" FontSize="24" FontWeight="Bold" Margin="0,0,0,20"/>
        <TextBlock TextWrapping="Wrap" Margin="0,10">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
            Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </TextBlock>
        <TextBlock TextWrapping="Wrap" Margin="0,10">
            Duis aute irure dolor in reprehenderit in voluptate velit esse 
            cillum dolore eu fugiat nulla pariatur.
        </TextBlock>
        <!-- More paragraphs... -->
    </StackPanel>
</ScrollViewer>
```

### Pattern 2: Horizontal Scrolling (Image Gallery)

```xml
<ScrollViewer HorizontalScrollBarVisibility="Auto"
              VerticalScrollBarVisibility="Disabled"
              Height="200">
    <StackPanel Orientation="Horizontal">
        <Image Source="photo1.jpg" Width="200" Height="150" Margin="5"/>
        <Image Source="photo2.jpg" Width="200" Height="150" Margin="5"/>
        <Image Source="photo3.jpg" Width="200" Height="150" Margin="5"/>
        <Image Source="photo4.jpg" Width="200" Height="150" Margin="5"/>
        <Image Source="photo5.jpg" Width="200" Height="150" Margin="5"/>
    </StackPanel>
</ScrollViewer>
```

### Pattern 3: Both Directions (Large Content)

```xml
<ScrollViewer Height="400" Width="600"
              VerticalScrollBarVisibility="Auto"
              HorizontalScrollBarVisibility="Auto">
    <Grid Width="1000" Height="800" Background="LightGray">
        <TextBlock Text="Large Content Area" 
                   FontSize="48" 
                   HorizontalAlignment="Center" 
                   VerticalAlignment="Center"/>
        <!-- Content larger than ScrollViewer -->
    </Grid>
</ScrollViewer>
```

### Pattern 4: Long Form

```xml
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <StackPanel Margin="20">
        <TextBlock Text="Registration Form" FontSize="24" FontWeight="Bold" Margin="0,0,0,20"/>
        
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
        <TextBox Height="100" TextWrapping="Wrap" AcceptsReturn="True" Margin="0,5,0,15"/>
        
        <Button Content="Submit" Width="100" HorizontalAlignment="Left"/>
    </StackPanel>
</ScrollViewer>
```

### Pattern 5: Settings Panel

```xml
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <StackPanel Margin="20">
        <GroupBox Header="General Settings" Margin="0,10">
            <StackPanel>
                <CheckBox Content="Enable notifications" Margin="0,5"/>
                <CheckBox Content="Auto-save" Margin="0,5"/>
                <CheckBox Content="Dark mode" Margin="0,5"/>
            </StackPanel>
        </GroupBox>
        
        <GroupBox Header="Display Settings" Margin="0,10">
            <StackPanel>
                <TextBlock Text="Font Size:"/>
                <Slider Minimum="10" Maximum="24" Value="14" Margin="0,5"/>
                <TextBlock Text="Zoom:"/>
                <Slider Minimum="50" Maximum="200" Value="100" Margin="0,5"/>
            </StackPanel>
        </GroupBox>
        
        <GroupBox Header="Privacy Settings" Margin="0,10">
            <StackPanel>
                <CheckBox Content="Share usage data" Margin="0,5"/>
                <CheckBox Content="Allow cookies" Margin="0,5"/>
                <CheckBox Content="Track location" Margin="0,5"/>
            </StackPanel>
        </GroupBox>
        
        <!-- More settings groups... -->
    </StackPanel>
</ScrollViewer>
```

---

## 🔧 Advanced Properties

### CanContentScroll

Controls scrolling mode:

```xml
<ScrollViewer CanContentScroll="True">
    <ListBox>
        <!-- Items -->
    </ListBox>
</ScrollViewer>
```

**CanContentScroll:**
- `True` = **Logical scrolling** (scroll by item)
- `False` = **Physical scrolling** (scroll by pixel, default)

**When to use:**
- `True`: For ListBox, ListView with many items (enables virtualization)
- `False`: For general content (smooth pixel scrolling)

### PanningMode

Enables touch screen support:

```xml
<ScrollViewer PanningMode="Both">
    <!-- Content -->
</ScrollViewer>
```

**Values:**
- `None` - No touch support
- `HorizontalOnly` - Touch pan horizontally only
- `VerticalOnly` - Touch pan vertically only
- `Both` - Touch pan in both directions (recommended)

### Programmatic Scrolling (Code-Behind)

```csharp
// Scroll to specific position
scrollViewer.ScrollToVerticalOffset(100);
scrollViewer.ScrollToHorizontalOffset(50);

// Scroll to edges
scrollViewer.ScrollToTop();
scrollViewer.ScrollToBottom();
scrollViewer.ScrollToLeftEnd();
scrollViewer.ScrollToRightEnd();

// Line/Page scrolling
scrollViewer.LineUp();
scrollViewer.LineDown();
scrollViewer.PageUp();
scrollViewer.PageDown();
```

### ScrollChanged Event

```xml
<ScrollViewer ScrollChanged="ScrollViewer_ScrollChanged">
    <!-- Content -->
</ScrollViewer>
```

```csharp
private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
{
    var scrollViewer = (ScrollViewer)sender;
    
    // Current position
    double verticalOffset = scrollViewer.VerticalOffset;
    double horizontalOffset = scrollViewer.HorizontalOffset;
    
    // Viewport size (visible area)
    double viewportHeight = scrollViewer.ViewportHeight;
    double viewportWidth = scrollViewer.ViewportWidth;
    
    // Scrollable area
    double scrollableHeight = scrollViewer.ScrollableHeight;
    double scrollableWidth = scrollViewer.ScrollableWidth;
    
    // Check if scrolled to bottom
    if (verticalOffset >= scrollableHeight)
    {
        MessageBox.Show("Reached bottom!");
    }
}
```

---

## ⚠️ Common Problems & Solutions

### Problem 1: ScrollViewer Doesn't Show Scrollbar

```xml
<!-- ❌ Problem: No height specified, ScrollViewer expands to fit content -->
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <StackPanel>
        <!-- Long content -->
    </StackPanel>
</ScrollViewer>
<!-- ScrollViewer expands, no scrollbar appears! -->

<!-- ✅ Solution: Specify Height -->
<ScrollViewer Height="400" VerticalScrollBarVisibility="Auto">
    <StackPanel>
        <!-- Long content -->
    </StackPanel>
</ScrollViewer>
```

### Problem 2: Nested ScrollViewers

```xml
<!-- ❌ Bad: ScrollViewer inside ScrollViewer (confusing) -->
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <StackPanel>
        <ScrollViewer VerticalScrollBarVisibility="Auto">
            <!-- Content -->
        </ScrollViewer>
    </StackPanel>
</ScrollViewer>
<!-- Which scrollbar do you use? Confusing! -->

<!-- ✅ Good: Single ScrollViewer -->
<ScrollViewer VerticalScrollBarVisibility="Auto">
    <StackPanel>
        <!-- All content here -->
    </StackPanel>
</ScrollViewer>
```

### Problem 3: ScrollViewer with Control That Has Built-in Scrolling

```xml
<!-- ❌ Bad: ListBox already has ScrollViewer -->
<ScrollViewer>
    <ListBox>
        <!-- Items -->
    </ListBox>
</ScrollViewer>
<!-- Double scrolling! Confusing! -->

<!-- ✅ Good: ListBox handles its own scrolling -->
<ListBox>
    <!-- Items -->
</ListBox>
```

**Controls with built-in ScrollViewer:**
- ListBox
- ListView
- DataGrid
- TreeView
- TextBox (with TextWrapping)

### Problem 4: Content Doesn't Fit Horizontally

```xml
<!-- ❌ Problem: Content too wide, but no horizontal scrollbar -->
<ScrollViewer VerticalScrollBarVisibility="Auto" Width="400">
    <StackPanel>
        <TextBlock Text="Very long text that exceeds 400 pixels width..." TextWrapping="NoWrap"/>
    </StackPanel>
</ScrollViewer>
<!-- Text gets cut off! -->

<!-- ✅ Solution: Enable horizontal scrolling -->
<ScrollViewer VerticalScrollBarVisibility="Auto" 
              HorizontalScrollBarVisibility="Auto" 
              Width="400">
    <StackPanel>
        <TextBlock Text="Very long text that exceeds 400 pixels width..." TextWrapping="NoWrap"/>
    </StackPanel>
</ScrollViewer>
```

---

## 💪 Best Practices

### Do's ✅

1. **Use Auto for ScrollBarVisibility**
   ```xml
   <ScrollViewer VerticalScrollBarVisibility="Auto">
   ```

2. **Specify ScrollViewer size**
   ```xml
   <ScrollViewer Height="400" Width="600">
   ```

3. **Use for long forms and articles**
   ```xml
   <ScrollViewer>
       <StackPanel>
           <!-- Long form fields -->
       </StackPanel>
   </ScrollViewer>
   ```

4. **Enable touch support**
   ```xml
   <ScrollViewer PanningMode="Both">
   ```

5. **Use single ScrollViewer per area**
   - Avoid nesting ScrollViewers

### Don'ts ❌

1. **Don't nest ScrollViewers**
   - Creates confusion about which scrollbar to use

2. **Don't forget to set size**
   - ScrollViewer needs height/width constraint

3. **Don't wrap controls with built-in scrolling**
   - ListBox, DataGrid, etc. have their own ScrollViewer

4. **Don't use Visible unless needed**
   - Auto is better (shows only when needed)

5. **Don't disable scrolling on touch devices**
   - Always set PanningMode="Both" for touch support

---

## 📋 Quick Reference

### ScrollBarVisibility Values

```xml
<ScrollViewer VerticalScrollBarVisibility="Auto"      <!-- Show when needed (default) -->
              HorizontalScrollBarVisibility="Auto">   <!-- Show when needed (default) -->
</ScrollViewer>
```

| Value | Scrollbar | Can Scroll | Use Case |
|-------|-----------|------------|----------|
| **Auto** | When needed | ✅ Yes | Most common |
| **Visible** | Always | ✅ Yes | Always show |
| **Hidden** | Never | ✅ Yes | Clean UI |
| **Disabled** | Never | ❌ No | No scrolling |

### Common Properties

```xml
<ScrollViewer Height="400"                           <!-- Viewport height -->
              Width="600"                            <!-- Viewport width -->
              VerticalScrollBarVisibility="Auto"     <!-- Vertical scrollbar -->
              HorizontalScrollBarVisibility="Auto"   <!-- Horizontal scrollbar -->
              CanContentScroll="False"               <!-- Pixel vs logical scrolling -->
              PanningMode="Both">                    <!-- Touch support -->
</ScrollViewer>
```

### Programmatic Scrolling

```csharp
// Scroll to position
scrollViewer.ScrollToVerticalOffset(100);
scrollViewer.ScrollToHorizontalOffset(50);

// Scroll to edges
scrollViewer.ScrollToTop();
scrollViewer.ScrollToBottom();
scrollViewer.ScrollToLeftEnd();
scrollViewer.ScrollToRightEnd();

// Get current position
double verticalPos = scrollViewer.VerticalOffset;
double horizontalPos = scrollViewer.HorizontalOffset;

// Get viewport size
double viewportHeight = scrollViewer.ViewportHeight;
double viewportWidth = scrollViewer.ViewportWidth;

// Get scrollable size
double scrollableHeight = scrollViewer.ScrollableHeight;
double scrollableWidth = scrollViewer.ScrollableWidth;
```

---

## 🎯 Summary

**ScrollViewer** adds **scrolling capability** to content:

| Aspect | Description |
|--------|-------------|
| **Purpose** | Show content larger than available space |
| **Scrollbars** | Automatic (when content overflows) |
| **Directions** | Vertical, horizontal, or both |
| **Best For** | Long forms, articles, lists, settings |
| **Input** | Mouse wheel, scrollbar, touch |
| **Key Property** | ScrollBarVisibility (Auto, Visible, Hidden, Disabled) |

**When to use:**
- ✅ Long forms
- ✅ Articles and documents
- ✅ Settings panels
- ✅ Image galleries (horizontal)
- ✅ Large tables/grids
- ✅ Content that might overflow

**When NOT to use:**
- ❌ With ListBox, DataGrid (have built-in scrolling)
- ❌ When content always fits
- ❌ Nested ScrollViewers

---

## 🔗 Related

- **Previous**: [Episode 08 - UniformGrid](../WPF_Episode08_UniformGrid) - Equal-sized grids
- **Next**: [Episode 10 - Border](../WPF_Episode10_Border) - Borders and backgrounds
- **Complement**: [Episode 03 - StackPanel](../WPF_Episode03_StackPanel) - Often used inside ScrollViewer

---

*For complete examples, see [README.md](README.md)*
