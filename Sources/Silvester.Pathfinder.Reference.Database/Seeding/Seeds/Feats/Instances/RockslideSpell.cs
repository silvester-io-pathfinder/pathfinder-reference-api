using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RockslideSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("947432ab-7c13-4235-b997-f3d7f6767f3e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rockslide Spell",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e66460b3-f472-4f46-aed5-7b60d62b429b"), Type = TextBlockType.Text, Text = "You enhance your spell with elemental earth, causing chunks of stone to litter the ground. If the next action you use is to (action: Cast a non-cantrip Spell | Cast a Spell) that affects an area, a number of 5-foot squares in the area equal to the spell level become difficult terrain for 1 round. These squares must be on the ground, and the entire area of difficult terrain must be contiguous. The spell gains the (trait: earth) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("759476f2-8685-4b48-bbc4-0221f5fef67b"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c28c5aed-d60d-46a3-a858-b394ee4100d2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
