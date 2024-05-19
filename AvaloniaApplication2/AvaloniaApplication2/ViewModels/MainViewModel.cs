using AvaloniaApplication2.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaApplication2.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    public string text => "Lorem Ipsum - это текст-рыба, часто используемый в печати и вэб-дизайне.";
    public ObservableCollection<Article> Articles { get; set; }
    public MainViewModel()
    {
        Articles = new ObservableCollection<Article>();
        Articles.Add(new Article("Давно выяснено, что при оценке дизайна и композиции читаемый текст мешает сосредоточиться.", "12:35 04.08.23"));
        Articles.Add(new Article("Давно выяснено, что при оценке дизайна и композиции читаемый текст мешает сосредоточиться.", "12:35 04.08.23"));
        BlogNotes = new ObservableCollection<BlogNote>();
        BlogNotes.Add(new BlogNote(
            "Article 1",
            "Lorem Ipsum - это текст-\"рыба\", часто используемый в печати и вэб-дизайне. Lorem Ipsum является стандартной \"рыбой\" для текстов на латинице с начала XVI века. В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum для распечатки образцов. Lorem Ipsum не только успешно пережил без заметных изменений пять веков, но и перешагнул в электронный дизайн. Его популяризации в новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum.",
            new List<string>()
            {
                "Tag 1",
                "Tag 2",
                "Tag 3"
            },
            "avares://AvaloniaApplication2/Assets/logo.png"

            ));
        CurrentBlogNote = BlogNotes[0];    
    }
    public ObservableCollection<BlogNote> BlogNotes { get; set; }
    public BlogNote CurrentBlogNote;
}
