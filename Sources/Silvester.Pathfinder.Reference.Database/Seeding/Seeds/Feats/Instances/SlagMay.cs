using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlagMay : Template
    {
        public static readonly Guid ID = Guid.Parse("84bc4c52-6d9e-400e-964e-12fc120e2d55");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slag May",
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
            yield return new TextBlock { Id = Guid.Parse("4e086805-465c-4c88-867f-d037da9bfca8"), Type = TextBlockType.Text, Text = "Your mother was an annis hag, known for physical prowess, and you have one violet or steel-gray eye. You have thick, sturdy claws made of cold iron that grow naturally from your body. You gain a claw unarmed attack that deals 1d6 slashing damage. Your claws are in the brawling group, have the (trait: unarmed) and (trait: grapple) traits, and are cold iron." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c7055c1-f71c-48a1-acde-4fd18a7556b3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
