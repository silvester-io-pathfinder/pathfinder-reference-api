using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class FleetFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("37e3bc29-be7b-4112-92aa-0b7dddbc2da3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fleet",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7b4e22c3-cf7d-4ab3-9d47-3bca57cd7ed6"), Type = TextBlockType.Text, Text = "You move more quickly on foot. Your Speed increases by 5 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override IEnumerable<Effect> GetCharacterEffects()
        {
            yield return new SpeedModifierEffect
            {
                Id = Guid.Parse("19a4dd9a-5c5d-4237-80be-6384cf33ae2b"),
                Modifier = 5,
                ModifierType = ModifierType.Add
            };
        }


        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9963b416-df89-4371-b3cf-089fdc5e5cd4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 261
            };
        }
    }
}
