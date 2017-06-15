namespace aw_console_wars.Warriors
{
    public class DamageReport
    {
        public int DamageDone { get; }
        public int DamageReceived { get; }

        public DamageReport(int damageDone, int damageReceived)
        {
            DamageDone = damageDone;
            DamageReceived = damageReceived;
        }
    }
}