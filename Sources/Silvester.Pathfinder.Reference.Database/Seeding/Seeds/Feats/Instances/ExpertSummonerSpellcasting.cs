using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertSummonerSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("5cd8142d-5689-49eb-96eb-57fcca91808f");

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
            yield return new TextBlock { Id = Guid.Parse("0e0519c9-1486-4736-aa35-041a588ae43d"), Type = TextBlockType.Text, Text = "Your proficiency ranks for your tradition&#39;s spell attack rolls and spell DCs increase to expert. You gain an additional 3rd-level spell slot, and you can select a second spell from your repertoire as a signature spell. At 14th level, you replace your spell slots with two 4th-level spell slots and one 5th-level spell slot, and at 16th level, you replace your spell slots with two 5th-level spell slots and one 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8f056412-bf7f-4d8b-be6f-d1a471f7c5ed"), Feats.Instances.BasicSummonerSpellcasting.ID);
            builder.Manual(Guid.Parse("3d3bc913-1fcb-407f-8622-e358ed8ff7c7"), "Master in the skill associated with your eidolon's tradition.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("960edeca-decd-4ee3-9d6c-2289666cd04b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
