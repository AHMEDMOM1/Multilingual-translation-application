# Çoklu Dil Çeviri Uygulaması (Multi-Language Translation App)

This project is a simple multi-language translation application built using Windows Forms.  
It demonstrates dictionary-based translation using clean OOP architecture.

---

## 🌍 Supported Languages
- English  
- Turkish  
- Arabic  

---

## ✨ Features
- Translate words between English, Turkish, and Arabic  
- Select source and target language  
- Words stored in an internal dictionary  
- Supports sentence translation (word-by-word)  

---

## 🧩 Architecture

### 1. Model
`WordPair`  
Represents a single word in three languages:
```cs
public class WordPair {
    public string English { get; set; }
    public string Turkish { get; set; }
    public string Arabic  { get; set; }
}

2. Service Layer
Two components:

ITranslationService
Defines translation behavior:

string Translate(string input, string fromLang, string toLang);
TranslationService
Implements dictionary-based translation:

Stores predefined words

Splits sentences into words

Translates each word

Returns the full translated sentence

3. UI Layer
The translation tab contains:

txtInput — text to translate

cmbFrom — source language

cmbTo — target language

btnTranslate — performs translation

txtOutput — translated text

🎯 How Translation Works
User enters text

Application splits the text into words

Each word is matched inside the dictionary

If a match is found → translated

If not found → word remains unchanged

All results are combined into a final output sentence

🛠️ Technologies Used
C#

Windows Forms

DevExpress Controls

Dictionary-based translation logic

OOP principles (Models, Interfaces, Services)

⭐ Learning Outcomes
Creating service-based architecture

Using models to structure data

Implementing dictionary-driven translation

Building multilingual UI
