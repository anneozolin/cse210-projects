using System;
using System.Collections.Generic;

public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    private List<Comment> comments = new List<Comment>();

    public int CommentCount
    {
        get { return comments.Count; }
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}