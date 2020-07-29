namespace cSharpProject
{
    static class StoryFileManager
    {    
        public static string[] GetStoryNames()
        {
            string sourcePath = @".\Stories";
            string[] filesRaw = System.IO.Directory.GetFiles(sourcePath);
            string[] files = new string[filesRaw.Length];
            
            for(int index = 0; index < filesRaw.Length; index++ )
            {
                files[index] = System.IO.Path.GetFileName(filesRaw[index]);
            }

            return files;
        }

        public static string GetStory(string fileName)
        {
            string text = System.IO.File.ReadAllText($@".\Stories\{fileName}");
            return text;
        }

        public static void SaveStory(string storyName, string[] lines)
        {
            System.IO.File.WriteAllLines($@".\Stories\{storyName}.txt", lines);
        }
    }
}