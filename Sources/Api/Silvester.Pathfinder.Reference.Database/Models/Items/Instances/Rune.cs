using System;
using System.Linq.Expressions;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public abstract class Rune : BaseItem
    {

    }

    public abstract class RuneVariant : BaseItemVariant, IUsed
    {
        public string Usage { get; set; } = default!;

        public int Price { get; set; }
        public int Level { get; set; }

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;
    }


    //Fundamental Armor Runes
    public class FundamentalArmorRune : Rune
    {

    }

    public class FundamentalArmorRuneVariant : RuneVariant, ISearchableEntity
    {
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class FundamentalArmorRuneVariantConfigurator : EntityConfigurator<FundamentalArmorRuneVariant>
    {
        public FundamentalArmorRuneVariantConfigurator()
        {
            ConfigureEntitySearch<FundamentalArmorRuneVariant>(e => new { e.Name, e.Usage });
        }
    }

    //Fundamental Weapon Runes
    public class FundamentalWeaponRune : Rune
    {

    }

    public class FundamentalWeaponRuneVariant : RuneVariant, ISearchableEntity
    {
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class FundamentalWeaponRuneVariantConfigurator : EntityConfigurator<FundamentalWeaponRuneVariant>
    {
        public FundamentalWeaponRuneVariantConfigurator()
        {
            ConfigureEntitySearch<FundamentalWeaponRuneVariant>(e => new { e.Name, e.Usage });
        }
    }

    //Armor Property Runes
    public class ArmorPropertyRune : Rune
    {

    }

    public class ArmorPropertyRuneVariant : RuneVariant, ISearchableEntity
    {
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ArmorPropertyRuneVariantConfigurator : EntityConfigurator<ArmorPropertyRuneVariant>
    {
        public ArmorPropertyRuneVariantConfigurator()
        {
            ConfigureEntitySearch<ArmorPropertyRuneVariant>(e => new { e.Name, e.Usage });
        }
    }

    //Weapon Property Runes
    public class WeaponPropertyRune : Rune
    {

    }

    public class WeaponPropertyRuneVariant : RuneVariant, ISearchableEntity
    {
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class WeaponPropertyRuneVariantConfigurator : EntityConfigurator<WeaponPropertyRuneVariant>
    {
        public WeaponPropertyRuneVariantConfigurator()
        {
            ConfigureEntitySearch<WeaponPropertyRuneVariant>(e => new { e.Name, e.Usage });
        }
    }
}
