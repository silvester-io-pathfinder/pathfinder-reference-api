using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DreadStriker : Template
    {
        public static readonly Guid ID = Guid.Parse("efd4d488-a9f8-44b6-8a5b-de1d10e9a371");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dread Striker",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a33867df-bb7b-4eca-b07c-10058bec61ea"), Type = TextBlockType.Text, Text = "You capitalize on your enemies’ fear to slip past their defenses. Any creature that has the frightened condition is also flat-footed against your attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19c20e65-0e57-4ec5-8226-9ead815e1858"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
