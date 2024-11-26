namespace ExamKata;

public interface IDamageable
{
    void TakeDamage(int damage);
    bool IsAlive { get; }
}
