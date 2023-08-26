namespace Comuni.Core;

public abstract class Identity<T>
{
    public T Id { get; }

    public Identity(T id)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));
    }

    protected static bool EqualOperator(Identity<T> left, Identity<T> right)
    {
        if (left is null && right is null)
        {
            return false;
        }

        return left is null || left.Equals(right);
    }

    protected static bool NotEqualOperator(Identity<T> left, Identity<T> right)
    {
        return !EqualOperator(left, right);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not null && this is null)
        {
            return false;
        }

        if (obj is null && this is not null)
        {
            return false;
        }

        if (obj is Identity<T> identity)
        {
            return identity.Id!.Equals(Id);
        }

        return false;
    }

    public override int GetHashCode() => Id!.GetHashCode();

    public override string ToString() => Id?.ToString() ?? "";
}
