using System.Reflection;

namespace PruebaTecnica.Dominio.Enumeradores
{
    public abstract class Enumeracion<TEnum>(string value, string displayName) : IEquatable<Enumeracion<TEnum>> where TEnum : Enumeracion<TEnum>
        {
            private static readonly Dictionary<string, TEnum> Enumeraciones = CreateEnumerations();


            public string Value { get; protected init; } = value;

            public string DisplayName { get; protected init; } = displayName;

            public static TEnum? FromId(string value)
            {
                return Enumeraciones.TryGetValue(
                    value,
                    out TEnum? enumeration) ?
                        enumeration :
                        default;
            }

            public static TEnum? FromName(string displayName)
            {
                return Enumeraciones
                    .Values
                    .SingleOrDefault(e => e.DisplayName == displayName);
            }

            public bool Equals(Enumeracion<TEnum>? other)
            {
                if (other is null)
                {
                    return false;
                }

                return GetType() == other.GetType() &&
                       Value == other.Value;
            }

            private static Dictionary<string, TEnum> CreateEnumerations()
            {
                var enumerationType = typeof(TEnum);

                var fieldsForType = enumerationType
                    .GetFields(
                        BindingFlags.Public |
                        BindingFlags.Static |
                        BindingFlags.FlattenHierarchy)
                    .Where(fieldInfo =>
                        enumerationType.IsAssignableFrom(fieldInfo.FieldType))
                    .Select(fieldInfo =>
                        (TEnum)fieldInfo.GetValue(default)!);

                return fieldsForType.ToDictionary(x => x.Value);
            }
        }
    
}
