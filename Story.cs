namespace cSharpProject
{
    class Story
    {
        public string Sentence { get; set; } = "";

        public void AddSentence(string input)
        {
            Sentence += ' ' + input;
        }
    }
}