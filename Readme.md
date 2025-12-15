# Çoklu Dil Çeviri Uygulaması  
Multi-Language Translation Application

This project is a simple multi-language translation app built using **C# WinForms** and **DevExpress**.  
It demonstrates dictionary-based translation using a clean and structured **OOP architecture**.

---

## 🌍 Supported Languages

- English  
- Turkish  
- Arabic  

---

## ✨ Features

- Translate text from one language to another  
- Select source and target languages  
- Dictionary-based translation system  
- Supports word-by-word sentence translation  
- Keeps unknown words unchanged  
- Fully separated logic (Model → Service → UI)

---

## 🧩 Architecture Overview

The application is divided into three layers:

1. **Model Layer**  
2. **Service Layer**  
3. **UI Layer (Presentation)**

---

## 1️⃣ Model Layer

### `WordPair` (Model)

Represents a single word in three languages:

```csharp
public class WordPair
{
    public string English { get; set; }
    public string Turkish { get; set; }
    public string Arabic  { get; set; }
}

```

This class is used as an entry inside the internal dictionary.

---

## 2️⃣ Service Layer

The logic of translation is implemented in this layer.  
It contains two components:

### `ITranslationService` (Interface)

Defines the translation behavior:

```csharp
public interface ITranslationService
{
    string Translate(string input, string fromLang, string toLang);
}
```

### `TranslationService` (Implementation)

Implements dictionary-based translation:

- Stores predefined words as a list of `WordPair`
- Splits sentences into words
- Translates each word individually
- Keeps words unchanged if not found in the dictionary
- Returns the fully translated sentence

### Translation Logic (Step-by-step)

1. Validate input
2. Split text into individual words
3. For each word:
   - Search for it according to the source language
   - If found → return the equivalent in the target language
   - If not found → keep the word as-is
4. Combine translated words into a final output sentence

---

## 3️⃣ UI Layer (Presentation)

Built using WinForms + DevExpress controls.

### UI Components

- `txtInput` — input text
- `cmbFrom` — source language dropdown
- `cmbTo` — target language dropdown
- `btnTranslate` — triggers the translation
- `txtOutput` — displays the translated sentence

### Initialization (`Form1_Load`)

```csharp
cmbFrom.Items.AddRange(new[] { "English", "Turkish", "Arabic" });
cmbTo.Items.AddRange(new[] { "English", "Turkish", "Arabic" });

cmbFrom.SelectedIndex = 0; // English
cmbTo.SelectedIndex = 1;   // Turkish
```

### Button Click Event

```csharp
private void btnTranslate_Click(object sender, EventArgs e)
{
    string input = txtInput.Text;
    string from  = cmbFrom.SelectedItem.ToString();
    string to    = cmbTo.SelectedItem.ToString();

    txtOutput.Text = _translationService.Translate(input, from, to);
}
```

The UI does not contain any business logic — it simply interacts with the `TranslationService`.

---

## 🔧 Technologies Used

- C#
- Windows Forms
- DevExpress
- OOP (Models, Services, Interfaces)

---

## 🎯 Learning Outcomes

- Understanding layered architecture
- Using interfaces and service classes
- Handling string operations
- Designing a multilingual application
- Clean separation between UI and logic

---

## 📌 Notes

- You can extend the dictionary by simply adding more `WordPair` entries.
- New languages can be added by expanding the model and service logic.
```

لقد قمت بإنشاء ملف `README.md` بناءً على النص الذي قدمته. تم الحفاظ على جميع الأقسام والمعلومات مع تحسين التنسيق وترتيب العناوين لجعل الملف أكثر تنظيمًا وسهولة في القراءة.
