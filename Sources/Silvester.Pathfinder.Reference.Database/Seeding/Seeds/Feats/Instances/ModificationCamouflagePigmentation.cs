using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationCamouflagePigmentation : Template
    {
        public static readonly Guid ID = Guid.Parse("30b9ba34-8d52-4579-b97a-9393cd3234d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification -  Camouflage Pigmentation",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2451a96f-13cb-45e6-a460-e704e4a9f92d"), Type = TextBlockType.Enumeration, Text = "*Subterfuge Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("49b2a315-e999-4983-a206-7edf2ddd5229"), Type = TextBlockType.Text, Text = "You’ve modified your armor’s exterior to let you blend into your surroundings with ease, as long as you stay still. While wearing your armor, you can (action: Hide) even without cover or concealment, as the pigmentation shifts to match your surroundings." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47c36085-8118-4cb2-bad7-daaefbe6ce7d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
