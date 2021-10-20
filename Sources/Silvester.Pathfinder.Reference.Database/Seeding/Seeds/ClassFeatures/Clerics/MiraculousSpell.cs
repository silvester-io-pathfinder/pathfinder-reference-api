using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class MiraculousSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Miraculous Spell", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You're exalted by your deity and gain truly incredible spells. You gain a single 10th-level spell slot and can prepare a spell in that slot using divine spellcasting. You can't use this spell slot for abilities that let you cast spells without expending spell slots or that give you more spell slots. You don't gain more 10th-level spells as you level up, though you can take the Maker of Miracles feat to gain a second slot." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSpellSlotEffect
            {
                Id = Guid.Parse(""),
                Amount = 1,
                Level = 10,
                IsSpendingPreventable = false,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 19
                        }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 121
            };
        }
    }
}
