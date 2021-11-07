using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PeculiarAnatomy : Template
    {
        public static readonly Guid ID = Guid.Parse("0f9776a1-e2b7-4ff9-b36b-962811caf14c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Peculiar Anatomy",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("345dc7c4-a3e8-498d-9ff8-a05c0c94463b"), Type = TextBlockType.Text, Text = "Your circulatory system contains viscous protoplasmic fluid instead of ordinary blood. You gain a +2 circumstance bonus to saving throws against (trait: disease) and (trait: poison), and resistance to poison damage equal to half your level." };
            yield return new TextBlock { Id = Guid.Parse("91117ab7-e25a-43d4-ba37-45894cd2779b"), Type = TextBlockType.Text, Text = "In addition, your resistance to precision damage from (feat: Disturbing Defense) increases to an amount equal to 7 + your number of class feats from the oozemorph archetype, and the DC of your flat checks to recover from persistent bleed damage is 8 rather than 13." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ffb5ca78-4dec-4c1d-b89c-57769916b660"), Feats.Instances.DisturbingDefense.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41e3a1a2-5261-4144-bdd6-86dcb1b084b6"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
