using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MantisForm : Template
    {
        public static readonly Guid ID = Guid.Parse("cb311e1c-a0b4-40d2-9773-acca46794c86");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mantis Form",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a1303df-b6f6-4c22-9fb3-d68d831ef6fc"), Type = TextBlockType.Text, Text = "You gain the (spell: mantis form) focus spell. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can (action: Refocus) by praying to Achaekek or researching your assigned kill." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d977f643-3da5-46f3-b424-8c1790cf0c2a"), Feats.Instances.BasicRedMantisMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a369fba-e5a1-48da-88e6-3259c6bbc901"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
