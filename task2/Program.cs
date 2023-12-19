string text = Console.ReadLine();
int like = Convert.ToInt32(Console.ReadLine());
string comment = Console.ReadLine();
Post post = new Post();
post.Text = text;
post.Likes = like;
post.Coments = comment;
System.Console.WriteLine(post.SetPost);
class Post
{
    public string Text;
    public int Likes;
    public string Coments;
    public string SetPost(string text)
    {
        return $"Text = {Text} \nLikes : {Likes} \nComments : {Coments}";
    }
    
}