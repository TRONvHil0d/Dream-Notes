# Note Taking Application

This is a simple note-taking application built with C# Windows Forms. Users can add, edit, and delete notes, which are saved locally on their computer using JSON.

## Features

- Add new notes with a title, content, and creation date.
- Edit existing notes.
- Delete notes.
- Display notes in a card layout.
- Save notes locally in a JSON file.

## Screenshots

![Main Screen](https://github.com/batutandoga/Dream-Notes/blob/master/DreamImg/mainpage.png)
![Add Note](https://github.com/batutandoga/Dream-Notes/blob/master/DreamImg/addpage.png)
![Edit Note](https://github.com/batutandoga/Dream-Notes/blob/master/DreamImg/editpage.png)

## Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/batutandoga/Dream-Notes.git
    ```

2. Open the project in Visual Studio.

3. Build the project:
    ```bash
    Build > Build Solution
    ```

4. Run the application:
    ```bash
    Debug > Start Debugging
    ```

## Usage

1. **Add Note**: Click on the `Add Note` button to open a new form. Enter the note title and content, then click `Add`. The note will be displayed on the main screen.
2. **Edit Note**: Click the `Edit` button on a note to modify its title or content. Save changes by clicking `Save`.
3. **Delete Note**: Click the `Delete` button on a note to remove it from the list.

## Project Structure

- **MainForm.cs**: The main form displaying the notes and providing options to add, edit, and delete notes.
- **AddNoteForm.cs**: The form for adding new notes.
- **EditNoteForm.cs**: The form for editing existing notes.
- **Note.cs**: The model representing a note.
- **NoteStorage.cs**: Handles saving and loading notes from a JSON file.


## Contact

If you have any questions or suggestions, please contact me at [HERE](mailto:batuhantandtr@gmail.com).
