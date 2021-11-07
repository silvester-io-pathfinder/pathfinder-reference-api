using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterBeastGunnerSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("552f1925-029a-41b2-87d4-5d3c2c063a02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Beast Gunner Spellcasting",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04426c73-ed7b-4e97-91ec-2de0758619a3"), Type = TextBlockType.Text, Text = "You’ve learned the final truth of beast guns, making you a master in the magic they grant you. Your proficiency ranks for your beast gunner spell attack rolls and spell DCs increase to master, and you gain a 7th-level spell slot. You can select a third spell from your repertoire as a signature spell. At 20th level, you gain an 8th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e0d0baf0-b3ed-4e9d-95d9-a205a924b52b"), Feats.Instances.ExpertBeastGunnerSpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14c6e7b5-c9cf-478d-bad7-a84eeea7f1eb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
