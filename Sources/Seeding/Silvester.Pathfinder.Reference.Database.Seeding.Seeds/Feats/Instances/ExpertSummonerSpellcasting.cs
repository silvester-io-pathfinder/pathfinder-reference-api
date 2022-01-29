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
    public class ExpertSummonerSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("f56af6a3-1cb7-4e50-8332-6e0f82e5f1c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Summoner Spellcasting",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("367df61f-8969-49c1-a0d1-2632f404ef8c"), Type = TextBlockType.Text, Text = $"Your proficiency ranks for your tradition's spell attack rolls and spell DCs increase to expert. You gain an additional 3rd-level spell slot, and you can select a second spell from your repertoire as a signature spell. At 14th level, you replace your spell slots with two 4th-level spell slots and one 5th-level spell slot, and at 16th level, you replace your spell slots with two 5th-level spell slots and one 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a5670413-0fad-4efb-a92e-5ca81ff202e3"), Feats.Instances.BasicSummonerSpellcasting.ID);
            builder.Manual(Guid.Parse("9d73c47c-db45-445f-a70c-15f3eb9c97cd"), "Master in the skill associated with your eidolon's tradition.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df06a212-638c-4818-90b0-20d4576fd4be"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
