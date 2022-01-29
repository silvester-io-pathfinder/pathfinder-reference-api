using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedRedMantisMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("dad2dd0f-0af6-432b-a3be-48c387c1b45d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Red Mantis Magic",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("91ece185-6577-46f1-8342-8337bfe7cf22"), Type = TextBlockType.Text, Text = $"Your Red Mantis magical training has improved. Add two 2nd-level spells to your Red Mantis assassin spellbook. You gain a 2nd-level spell slot that you can use to prepare a spell from your Red Mantis assassin spellbook." };
            yield return new TextBlock { Id = Guid.Parse("767b5ef9-5873-4b6d-aeed-ec09f2eb2ab1"), Type = TextBlockType.Text, Text = $"At 8th level, add two 3rd-level spells to your Red Mantis assassin spellbook. You gain a 3rd-level spell slot that you can use to prepare a spell from your Red Mantis assassin spellbook." };
            yield return new TextBlock { Id = Guid.Parse("0fa99a03-c2a6-4638-b641-5a14e57e1c79"), Type = TextBlockType.Text, Text = $"At 10th level, add two 4th-level spells to your Red Mantis assassin spellbook. You gain a 4th-level spell slot that you can use to prepare a spell from your Red Mantis assassin spellbook." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5f13bc4a-4b25-41b3-927e-19475819a7b1"), Feats.Instances.BasicRedMantisMagic.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80501dad-66f9-4f20-bc57-d5403e1ece14"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
