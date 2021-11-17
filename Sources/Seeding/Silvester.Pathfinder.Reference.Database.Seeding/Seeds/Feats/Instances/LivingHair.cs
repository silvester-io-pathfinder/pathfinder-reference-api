using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingHair : Template
    {
        public static readonly Guid ID = Guid.Parse("c6713b0a-6829-4c83-bd39-4e0321fdf56d");

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
            yield return new TextBlock { Id = Guid.Parse("411811e7-bf19-4118-a128-ce3d5dfd034a"), Type = TextBlockType.Text, Text = "You can instantly grow or shrink your hair, eyebrows, beard, or mustache by up to several feet and manipulate your hair for use as a weapon, though your control isn’t fine enough for more dexterous tasks. You gain a hair unarmed attack that deals 1d4 bludgeoning damage; is in the brawling group; and has the (trait: agile), (trait: disarm), (trait: finesse), (trait: trip), and (trait: unarmed) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7fd3fe47-abc5-400e-b142-74c49c532498"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}