namespace RPS.Module.Opponent
{
    public struct UpdateOpponentMessage
    {
        public int HandIndex { get; private set; }
        public UpdateOpponentMessage(int handIndex)
        {
            HandIndex = handIndex;
        }
    }
}

