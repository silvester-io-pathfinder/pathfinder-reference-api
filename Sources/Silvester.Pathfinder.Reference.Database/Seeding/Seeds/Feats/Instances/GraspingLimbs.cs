using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GraspingLimbs : Template
    {
        public static readonly Guid ID = Guid.Parse("f92cf55f-e0e1-4bf3-b730-85cb838863d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grasping Limbs",
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
            yield return new TextBlock { Id = Guid.Parse("b6e6abca-58bf-4ce2-8b7f-dff56cb2f2da"), Type = TextBlockType.Text, Text = "Your eidolon grabs enemies. Choose one of the eidolon’s unarmed attacks with the (trait: grapple) trait. It gains the Grab action (Bestiary pg. 343) on that unarmed attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9be7a878-5fa5-462f-b240-565c8ed899ae"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
