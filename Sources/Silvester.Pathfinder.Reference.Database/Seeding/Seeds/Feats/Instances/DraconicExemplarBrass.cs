using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarBrass : Template
    {
        public static readonly Guid ID = Guid.Parse("fe9f0fa7-ca4e-426b-98ef-edb8c6631029");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Brass",
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
            yield return new TextBlock { Id = Guid.Parse("f56168cc-8091-4020-b5e0-f76ffdffae7c"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a brass dragon." };
            yield return new TextBlock { Id = Guid.Parse("de6663b2-b90f-4063-a19e-ace5aeb5c31a"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Line" };
            yield return new TextBlock { Id = Guid.Parse("cf695210-8986-4336-88c6-012ccb34b827"), Type = TextBlockType.Text, Text = "~ Damage Type: Fire" };
            yield return new TextBlock { Id = Guid.Parse("d3676e57-95e3-403e-a461-67e28ad371ea"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f82020f-6886-4e52-8f13-ff84981e712e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
