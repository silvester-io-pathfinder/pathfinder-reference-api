using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrippliLore : Template
    {
        public static readonly Guid ID = Guid.Parse("57e9ef60-7118-4d80-acee-2a3b0e41fdab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grippli Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17be0c46-7821-4912-960b-2029dc62acd8"), Type = TextBlockType.Text, Text = "You are well versed in grippli culture and tactics. You gain the trained proficiency in Nature and Stealth. If you would automatically become trained in one of those skills, you instead become trained in a skill of your choice. You also become trained in Grippli Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b3d4b1a-5d2e-4512-b6f3-6a7f1d999d1c"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
