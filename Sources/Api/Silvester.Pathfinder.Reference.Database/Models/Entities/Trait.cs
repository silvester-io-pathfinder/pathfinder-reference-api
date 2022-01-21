using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public abstract class TraitBinding<TOwner> : BaseEntity
        where TOwner : BaseEntity
    {
        public string? Specifier { get; set; }

        public Guid OwnerId { get; set; }
        public TOwner Owner { get; set; } = default!;

        public Guid TraitId { get; set; }
        public Trait Trait { get; set; } = default!;
    }

    public class Trait : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<Activity> Activities { get; set; } = new List<Activity>();

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();

        public ICollection<SkillAction> SkillActions{ get; set; } = new List<SkillAction>();

        public ICollection<Eidolon> Eidolons { get; set; } = new List<Eidolon>();

        public ICollection<Feat> Feats { get; set; } = new List<Feat>();

        public ICollection<Ability> Abilities { get; set; } = new List<Ability>();

        public ICollection<Background> Backgrounds { get; set; } = new List<Background>();

        public ICollection<Curse> Curses { get; set; } = new List<Curse>();

        public ICollection<ItemCurse> ItemCurses { get; set; } = new List<ItemCurse>();

        public ICollection<Disease> Diseases { get; set; } = new List<Disease>();

        public ICollection<Action> Actions { get; set; } = new List<Action>();
        
        public ICollection<Ancestry> Ancestries { get; set; } = new List<Ancestry>();

        public ICollection<Hazard> Hazards { get; set; } = new List<Hazard>();

        public ICollection<AlchemicalBomb> AlchemicalBombs { get; set; } = new List<AlchemicalBomb>();
     
        public ICollection<AlchemicalElixir> AlchemicalElixirs{ get; set; } = new List<AlchemicalElixir>();

        public ICollection<AlchemicalTool> AlchemicalTools { get; set; } = new List<AlchemicalTool>();

        public ICollection<AlchemicalPoison> AlchemicalPoisons { get; set; } = new List<AlchemicalPoison>();

        public ICollection<Plane> Planes { get; set; } = new List<Plane>();

        public ICollection<Armor> Armors { get; set; } = new List<Armor>();

        public ICollection<MeleeWeapon> MeleeWeapons { get; set; } = new List<MeleeWeapon>();

        public ICollection<RangedWeapon> RangedWeapons { get; set; } = new List<RangedWeapon>();

        public ICollection<BeastGun> BeastGuns { get; set; } = new List<BeastGun>();

        public ICollection<PreciousMaterial> PreciousMaterials { get; set; } = new List<PreciousMaterial>();

        public ICollection<PreciousMaterialArmor> PreciousMaterialArmors { get; set; } = new List<PreciousMaterialArmor>();

        public ICollection<PreciousMaterialShield> PreciousMaterialShields { get; set; } = new List<PreciousMaterialShield>();

        public ICollection<PreciousMaterialWeapon> PreciousMaterialWeapons { get; set; } = new List<PreciousMaterialWeapon>();

        public ICollection<ArmorPropertyRune> ArmorPropertyRunes { get; set; } = new List<ArmorPropertyRune>();
        
        public ICollection<WeaponPropertyRune> WeaponPropertyRunes { get; set; } = new List<WeaponPropertyRune>();
        
        public ICollection<FundamentalArmorRune> FundamentalArmorRunes { get; set; } = new List<FundamentalArmorRune>();

        public ICollection<FundamentalWeaponRune> FundamentalWeaponRunes { get; set; } = new List<FundamentalWeaponRune>();

        public ICollection<Artifact> Artifacts { get; set; } = new List<Artifact>();

        public ICollection<Creature> Creatures { get; set; } = new List<Creature>();

        public ICollection<Stave> Staves { get; set; } = new List<Stave>();

        public ICollection<CombinationWeapon> CombinationWeapons { get; set; } = new List<CombinationWeapon>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class TraitConfigurator : EntityConfigurator<Trait>
	{
		public TraitConfigurator()
		{
			ConfigureEntitySearch<Trait>(e => new {e.Name});
		}
	}
}

