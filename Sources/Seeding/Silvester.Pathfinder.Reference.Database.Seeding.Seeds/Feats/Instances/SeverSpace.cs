using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeverSpace : Template
    {
        public static readonly Guid ID = Guid.Parse("23b7e8de-cdae-48ad-be0d-876cf2171350");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sever Space",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7211fdf0-880b-4e30-ae72-fbcfa445617d"), Type = TextBlockType.Text, Text = "You destroy the space between you and your targets, allowing you to strike with your melee weapons at great range. Make a melee (action: Strike) with the required weapon or unarmed attack. The attack gains an 80-foot reach for this (action: Strike)." };
            yield return new TextBlock { Id = Guid.Parse("3a36bfac-db0c-4acc-8453-e63dabd1631c"), Type = TextBlockType.Text, Text = "After the (action: Strike), regardless of whether it succeeded, the world rushes to fill the space you destroyed, bringing you and the target adjacent to each other. You can choose to teleport to the closest space adjacent to the target or to attempt to teleport the target adjacent to you. If you choose the target, they can negate the teleportation if they succeed at a Fortitude save against your class DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae84d8b1-e541-433f-9365-2551d82037d6"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
