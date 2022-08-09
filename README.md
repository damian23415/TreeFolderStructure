# TreeFolderStructure

Stack techniczny wykorzystany w projekcie: 
- MSSQL, 
- Vue.js, 
- ASP .Net Core
- MediatR z wzorcem CQRS
- EntityFramework

Aby uruchomić aplikację:
1. Należy pobrać repozytorium i z poziomu Package Manager Console upewnić się, że startowy projekt to TreeFolderStructure.DataAccess.
2. Wykonać polecenie Update-Database - polecenie stworzy bazę danych oraz wypełni ją przykładowymi danymi.
3. Uruchomić aplikację upewniając się, że wybrany projekt startowy to TreeFolderStructure.
4. Uruchomić plik Index.html, który znajduje się w: `TreeFolderStructure -> Views`.
5. Jeśli aplikacja została poprawnie uruchomiona wczyta się podstawowe drzewo katalogów, które wygląda następująco:
- Root
    - Dokumenty
    - Wideo
    - Obrazki
        - Moje zdjęcia

### Jak korzystać z aplikacji:
1. Aby dodać główny folder do struktury (taki, który nie ma rodziców) upewnij się, że: *Currently selected folder: None* wtedy wpisz nazwę folderu i kliknij przycisk *Add folder*. Natomiast jeśli w *Currently selected folder:* zamiast *None* jest widoczna inna wartość wtedy najpierw należy kliknąć przycisk *Reset current selected folder*, i po pojawieniu się *None* w *Currently selected folder:* należy wpisać nazwę folderu i kliknąć przycisk *AddFolder*.
2. Aby usunąć folder, należy kliknąć folder, który ma zostać usunięty, upewnić się, że w *Currently selected folder:* widnieje nazwa tego folderu i kliknąć przycisk *Delete folder*.
3. Aby edytować nazwę folderu należy kliknąć na folder, który ma zostać edytowany, następnie upewnić się, że jego nazwa widnieje w *Currently selected folder:*, następnie wprowadzić nową nazwę folderu w polu *Enter your folder name:* i kliknąć przycisk *Edit folder name*.
