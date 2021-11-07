using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertBeastGunnerSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("abdd89a4-714e-4e84-82c3-dc25d65d9d9a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Beast Gunner Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("dab019fe-bb7f-4da2-a603-ff499fb4482d"), Type = TextBlockType.Text, Text = "You’ve learned the deeper secrets of beast guns, making you an expert in the magic they grant you. Your proficiency ranks for your beast gunner spell attack rolls and spell DCs increase to expert, and you gain a 4th-level spell slot. You can select a second spell from your repertoire as a signature spell. At 14th level, you gain a 5th-level spell slot, and at 16th level, you gain a 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4fc5f6bf-8b79-4f5c-bc45-90e46d60a8c3"), Feats.Instances.BasicBeastGunnerSpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16e1a4d5-faa0-4f8c-b0b1-1b2ca82b06bf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
