# ToDoList API – ASP.NET Core

Progetto di esempio realizzato in **ASP.NET Core Web API** che implementa una semplice **To-Do List**.
È pensato come progetto **portfolio entry-level**, per dimostrare le basi di:

- Web API REST
- Architettura a livelli
- Dependency Injection
- DTO
- Collegamento frontend ↔ backend

---

## 🎯 Scopo del progetto

L’obiettivo è fornire un’API che permetta di:

- Visualizzare una lista di task
- Aggiungere nuovi task
- Gestire i dati senza esporre direttamente la struttura interna

Il progetto simula un caso reale molto comune:  
un frontend (web, mobile, desktop) che comunica con un backend tramite API.

---

## 🧱 Architettura del progetto

ToDoList.Api
├── Controllers → Endpoint HTTP (API)
├── Services → Logica applicativa
├── Models → Modelli di dominio
├── DTOs → Oggetti di trasferimento dati
├── Program.cs → Configurazione applicazione
├── index.html → Frontend semplice di test


### Componenti principali

- **Controller**
  - Espongono gli endpoint (`GET`, `POST`, ecc.)
- **Service**
  - Contengono la logica di business
- **DTO**
  - Separano i dati in ingresso/uscita dai modelli interni
- **Dependency Injection**
  - I servizi vengono iniettati automaticamente

---

## 🔌 Endpoint disponibili

### `GET /api/tasks`
Restituisce la lista dei task.

### `POST /api/tasks`
Crea un nuovo task.

**Esempio body JSON:**
```json
{
  "title": "Studiare ASP.NET",
  "description": "Capire come funzionano le API"
}

🌐 Frontend di test

Nel progetto è incluso un semplice index.html che permette di:

Visualizzare i task

Aggiungere nuovi task tramite form

Testare l’API senza strumenti esterni

Il frontend comunica con l’API tramite fetch.

▶️ Avvio del progetto
Requisiti

.NET SDK (versione 8 o superiore)

Browser moderno

Avvio API

Dalla cartella ToDoList.Api:

dotnet run


L’API sarà disponibile su:

http://localhost:5150


Swagger UI:

http://localhost:5150/swagger

🧪 Test manuale

Apri index.html con Live Server (VSCodium) o server statico

Inserisci un task

Verifica che venga aggiunto e restituito dall’API

🚀 Possibili miglioramenti futuri

Persistenza dati (database)

Autenticazione utenti

Aggiornamento e cancellazione task

Validazioni avanzate

Frontend più strutturato

👤 Autore

Oscar Dicembri
Progetto realizzato come esercizio pratico per studio e portfolio.
