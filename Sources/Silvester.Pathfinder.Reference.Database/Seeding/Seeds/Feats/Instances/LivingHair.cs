using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingHair : Template
    {
        public static readonly Guid ID = Guid.Parse("7d153589-51ee-49d1-b814-d8603041dfe7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Living Hair",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b81401a5-0b23-4ec9-b9e3-3c75606a964f"), Type = TextBlockType.Text, Text = "You can instantly grow or shrink your hair, eyebrows, beard, or mustache by up to several feet and manipulate your hair for use as a weapon, though your control isn’t fine enough for more dexterous tasks. You gain a hair unarmed attack that deals 1d4 bludgeoning damage; is in the brawling group; and has the (trait: agile), (trait: disarm), (trait: finesse), (trait: trip), and (trait: unarmed) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50108221-427f-4d3e-b49c-f320418de033"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
