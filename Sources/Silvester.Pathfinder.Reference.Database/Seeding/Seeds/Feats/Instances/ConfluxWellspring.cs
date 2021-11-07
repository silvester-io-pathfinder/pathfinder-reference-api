using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConfluxWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("82e7d5b9-0520-4f97-b6df-35c404c2e8ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conflux Wellspring",
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
            yield return new TextBlock { Id = Guid.Parse("1dafd121-f688-4c00-8060-972067041971"), Type = TextBlockType.Text, Text = "You’ve achieved perfect magical and physical balance, allowing magic to flow into and through you more easily. You can recover 3 Focus Points when you (action: Refocus) instead of 1 if you have spent at least 3 Focus Points since the last time you (action: Refocused | Refocus)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c83ee726-1afd-4d07-ba40-67cfca8c7b03"), Feats.Instances.ConfluxFocus.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39503f81-f51b-490a-9a0e-719a6b874088"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
