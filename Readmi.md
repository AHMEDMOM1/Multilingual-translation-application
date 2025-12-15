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
