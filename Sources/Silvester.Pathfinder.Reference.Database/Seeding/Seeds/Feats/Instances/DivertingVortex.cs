using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivertingVortex : Template
    {
        public static readonly Guid ID = Guid.Parse("355fac86-96cc-4967-90f9-abfa087586eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diverting Vortex",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f09b2805-b01d-4676-879f-2338edd70c2c"), Type = TextBlockType.Text, Text = "You transfer vestiges of magical energy to the air around you, creating a vortex that deflects ranged attacks. Until the start of your next turn, you gain a +1 status bonus to AC against ranged weapon attacks and physical ranged unarmed attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd44b14c-f725-4973-9525-4d653902fc9d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
