namespace aw_console_wars.Warriors
{
    public class DamageReport
    {
        public int DamageDealt { get; }
        public int DamageReceived { get; }

        public DamageReport(int damageDealt, int damageReceived)
        {
            DamageDealt = damageDealt;
            DamageReceived = damageReceived;
        }
    }
}