using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InuredToTheHeat : Template
    {
        public static readonly Guid ID = Guid.Parse("ae42a5e7-6dab-4ae8-9af9-2176dadd3709");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inured to the Heat",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2e58598-40fb-4058-9574-83419abb92e6"), Type = TextBlockType.Text, Text = "Your have a love for extreme heat. You gain resistance 4 to fire. You treat environmental heat effects as if they were one step less extreme (incredible heat becomes extreme, extreme heat becomes severe, and so on)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cc1af30-e24f-4d80-ab19-67f16a45a3cb"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
