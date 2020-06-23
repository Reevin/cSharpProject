namespace cSharpProject
{
    class Story
    {
        public string Sentence { get; set; } = "";

        public void Add(string input)
        {
            Sentence += ' ' + input;
        }
    }
}