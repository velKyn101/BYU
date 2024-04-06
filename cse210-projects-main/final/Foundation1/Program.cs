using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        //setting the path to the .csv file
        string filePath = "infos.csv";

        //Creating lists to store infos
        List<Video> videos = new List<Video>();
        List<Comment> comments = new List<Comment>();

        try
        {   
            using (StreamReader sr = new StreamReader(filePath))
            { 
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    if(values.Length >= 5)
                    {
                        // Create a new Video object and add it to the list
                        Video video = new Video(values[0], values[1], int.Parse(values[2]));
                        videos.Add(video);

                        // Create a new Comment object and add it to the list
                        Comment comment = new Comment(values[3], values[4]);
                        comments.Add(comment);

                        // Add the comment to the video's list of comments
                        video.SetComments(comment);
                }
            }

            videos.Zip(comments, (video, comment) =>
            {
                video.Display();
                comment.Display();
                Console.WriteLine();
                return 0; 
            }).ToList();


            // Now iterate over videos and display total comments for each
            foreach (Video video in videos)
            {
                int totalComments = video.ComputeTotalComments();
                Console.WriteLine($"Total Comments for {video.GetTitle()}: {totalComments}");
            }
        }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred when reading the file: ");
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error while parsing integer value: ");
            Console.WriteLine(e.Message);
        }
    }
}