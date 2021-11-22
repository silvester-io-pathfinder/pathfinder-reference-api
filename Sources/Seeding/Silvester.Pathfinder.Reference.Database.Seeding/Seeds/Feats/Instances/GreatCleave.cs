using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreatCleave : Template
    {
        public static readonly Guid ID = Guid.Parse("4dde1648-9c19-4164-a5fb-6f5c5d6e98b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Great Cleave",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01f6b518-03c7-42b6-9f06-7a6fff1cc6bb"), Type = TextBlockType.Text, Text = "Your fury carries your weapon through multiple foes. When you (feat: Cleave), if your (action: Strike) also kills or knocks the target unconscious, you can continue to make melee (action: Strikes | Strike) until you make a (action: Strike) that doesn't kill or knock a creature unconscious, or until there are no creatures adjacent to the most recent creature you attacked while (feat: Cleaving | Cleave), whichever comes first." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("24f1d39b-7a9c-4b18-8ab1-ea44fd2be4bf"), Feats.Instances.Cleave.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0759c25a-6acc-4bbe-bac0-1e2b864923bf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
