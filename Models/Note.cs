public class Note
{
    int Id {get; set;}
    String Title {get; set;}
    String Content {get; set;}
    DateTime CreatedAt {get; set;}

    /* Need to establish a difference between a note being created by the user at the command line
    and a note object being created because it's been loaded from a json file (which will already
    have Id and CreatedAt). Are they different objects? Probably not.

    */
    public Note(int id, String title, String content)
    {
        this.Id = id;
        this.Title = title;
        this.Content = content;
        // Add in content to set CreatedAt when the Note is initially created
    }

    public Note(String title, String content)
    {
        this.Title = title;
        this.Content = content;
    }
}