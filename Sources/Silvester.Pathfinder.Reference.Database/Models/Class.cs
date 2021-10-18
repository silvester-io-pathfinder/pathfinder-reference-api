using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Class : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int BaseHealth { get; set; }

        public string Description{ get; set; } = default!;

        public string DuringCombatEncounters { get; set; } = default!;
        public string DuringSocialEncounters { get; set; } = default!;
        public string WhileExploring { get; set; } = default!;
        public string InDowntime { get; set; } = default!;

        public Guid PerceptionProficiencyId { get; set; }
        public Proficiency PerceptionProficiency { get; set; } = default!;

        public Guid FortitudeProficiencyId { get; set; }
        public Proficiency FortitudeProficiency { get; set; } = default!;

        public Guid WillProficiencyId { get; set; }
        public Proficiency WillProficiency { get; set; } = default!;

        public Guid ReflexProficiencyId { get; set; }
        public Proficiency ReflexProficiency { get; set; } = default!;

        public Guid SimpleWeaponProficiencyId { get; set; }
        public Proficiency SimpleWeaponProficiency { get; set; } = default!;

        public Guid MartialWeaponProficiencyId { get; set; }
        public Proficiency MartialWeaponProficiency { get; set; } = default!;

        public Guid AdvancedWeaponProficiencyId { get; set; }
        public Proficiency AdvancedWeaponProficiency { get; set; } = default!;

        public Guid UnarmedWeaponProficiencyId { get; set; }
        public Proficiency UnarmedWeaponProficiency { get; set; } = default!;

        public Guid UnarmoredProficiencyId { get; set; }
        public Proficiency UnarmoredProficiency { get; set; } = default!;

        public Guid LightArmorProficiencyId { get; set; }
        public Proficiency LightArmorProficiency { get; set; } = default!;

        public Guid MediumArmorProficiencyId { get; set; }
        public Proficiency MediumArmorProficiency { get; set; } = default!;

        public Guid HeavyArmorProficiencyId { get; set; }
        public Proficiency HeavyArmorProficiency { get; set; } = default!;

        public Guid? ClassDcProficiencyId { get; set; }
        public Proficiency? ClassDcProficiency { get; set; }

        public Guid? SpellDcProficiencyId { get; set; }
        public Proficiency? SpellDcProficiency { get; set; }

        public Guid? SpellAttackProficiencyId { get; set; }
        public Proficiency? SpellAttackProficiency { get; set; }

        public Guid? PredefinedMagicTraditionId { get; set; }
        public MagicTradition? PredefinedMagicTradition { get; set; }

        public ICollection<Stat> KeyAbilities { get; set; } = new List<Stat>();

        public ICollection<Instinct> Instincts { get; set; } = new List<Instinct>();

        public ICollection<ClassMannerism> Mannerisms { get; set; } = new List<ClassMannerism>();

        public ICollection<ClassCharacteristic> Characteristics { get; set; } = new List<ClassCharacteristic>();

        public ICollection<ClassFeature> Features { get; set; } = new List<ClassFeature>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
