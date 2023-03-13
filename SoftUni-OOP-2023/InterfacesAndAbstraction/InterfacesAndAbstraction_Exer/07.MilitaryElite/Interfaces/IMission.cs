using _07.MilitaryElite.Enumerators;

namespace _07.MilitaryElite.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; }

        void CompleteMission();
        public State State { get; }
    }
}