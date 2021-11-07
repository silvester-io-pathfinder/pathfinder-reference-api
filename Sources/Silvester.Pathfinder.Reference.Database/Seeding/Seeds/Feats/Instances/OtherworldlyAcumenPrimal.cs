using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OtherworldlyAcumenPrimal : Template
    {
        public static readonly Guid ID = Guid.Parse("9129154d-2fe1-4389-b80b-4fa6e1a06413");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Otherworldly Acumen - Primal",
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
            yield return new TextBlock { Id = Guid.Parse("c8a90205-a58e-4720-a82e-61788ff2a71c"), Type = TextBlockType.Text, Text = "Choose one common 2nd-level spell from the primal tradition." };
            yield return new TextBlock { Id = Guid.Parse("89483dbf-a0ac-4ab9-ae84-fd86de1ef644"), Type = TextBlockType.Text, Text = "You can cast that spell as an innate spell once per day. Your magic is adaptable. By spending 1 day of downtime, you can change the spell you chose to a different common 2nd-level spell from the same tradition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b07c06ad-c9c4-43dd-8098-0dc84df3bcdc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
