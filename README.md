# 2026 WPF 選課系統

## ver1 (2026/11/25)
新增 WPF 選課系統的 UI 與資料模型

### 新增功能：
- 修改 `MainWindow.xaml`，設計選課系統的 UI，包括：
  - 視窗標題、`Grid` 行列定義、`StackPanel`、`StatusBar`。
  - 新增 `TabControl`，分為「以教師分類課程」與「所有課程」。
  - 新增按鈕（選課、退選、存檔）與 `ListView`。
- 在 `MainWindow.xaml.cs` 中：
  - 新增 `InitializeData` 方法，初始化學生、教師與課程資料。
  - 綁定資料至 UI 控件（如 `StudentComboBox`、`CourseListBox`）。
- 新增數據模型：
  - `Course.cs`：定義課程屬性。
  - `Record.cs`：定義選課記錄。
  - `Student.cs`：定義學生屬性，並覆寫 `ToString`。
  - `Teacher.cs`：定義教師屬性與授課課程集合。
- 新增圖片資源：
  - `teacher.png` 與 `course.png`。
- 更新 `2026_WpfApp5.csproj`，將 `teacher.png` 設為 `Resource` 類型。
