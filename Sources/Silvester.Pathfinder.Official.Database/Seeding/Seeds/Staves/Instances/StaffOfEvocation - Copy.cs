using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfEvocation2 : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                Effect = "You expend a number of charges from the staff to cast a spell from its list.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "" };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = ,
                ItemLevel = ,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = , SpellId = Spells.Instances.AbyssalPlague.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = ,
                ItemLevel = ,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = , SpellId = Spells.Instances.AbyssalPlague.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = ,
                ItemLevel = ,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = , SpellId = Spells.Instances.AbyssalPlague.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = ,
                ItemLevel = ,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.True.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = , SpellId = Spells.Instances.AbyssalPlague.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Staff.ID;
        }
      
        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 593
            };
        }
    }
}
