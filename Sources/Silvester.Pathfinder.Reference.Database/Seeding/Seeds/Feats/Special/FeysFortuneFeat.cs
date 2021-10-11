using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Special
{
    public class FeysFortuneFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("a4e23447-5bdb-40e7-af4f-c8be135cac9a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey's Fortune",
                Level = 1,
                Frequency = "Once per day.", 
                Trigger = "You attempt a skill check and haven't rolled yet.",
                FeatTypeId = FeatTypes.Instances.Background.ID,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fbdb0afe-930b-4440-b1be-84ce876a393b"), Type = TextBlockType.Text, Text = "Roll the skill check twice and use the better result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Fortune.ID;
        }
    }
}
