# Unity Change Scene Using Collider 2D


### What is this?
Script unity untuk perpindahan scene dengan menggunakan metode Collider2D

### How to Use?

- Pertama, kalian bisa download atau copy-paste code yang ada didalam
- Lalu deklarasikan var int 1LevelToLoad atau kalian bisa menambah var baru

### Sneakpeek


```csharp
public int LevelToLoad; // Var Integer untuk Load Level 1 pada Game
private int currentSceneIndex; // Untuk mengetahui Index Scene
```

```csharp
void OnTriggerEnter2D(Collider2D col) // Ketika Player Menyentuh Collider 2D Dalam Game
	{
		if (col.CompareTag("Player")) // Handler untuk mengetahui Collider Player
		{
				currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // Detect Scene yang ada
				PlayerPrefs.SetInt("SavedScene", currentSceneIndex); // Scene di Save
				SceneManager.LoadScene(LevelToLoad); // Lalu Scene akan berpindah ke Level 1
		}
	}	
```
