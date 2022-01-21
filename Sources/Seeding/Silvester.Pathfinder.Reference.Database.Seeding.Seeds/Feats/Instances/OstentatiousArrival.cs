using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OstentatiousArrival : Template
    {
        public static readonly Guid ID = Guid.Parse("b3e21ba8-468b-4224-842e-e7f78e3fde59");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ostentatious Arrival",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1bb822af-3a43-4793-b3a2-ba5261535954"), Type = TextBlockType.Text, Text = "If the next action you take is to (action: Manifest your Eidolon | Manifest Eidolon) as a three-action activity, or to (action: Cast a three-action summoning Spell | Cast a Spell), the creature appears in an explosion." };
            yield return new TextBlock { Id = Guid.Parse("29b40ff0-c9e2-417a-9e17-737bbe153937"), Type = TextBlockType.Text, Text = "All creatures in a 10-foot emanation around the creature you summoned or manifested take 1d4 fire damage per spell level for a summoning spell, or 1d4 damage per 2 levels for (action: Manifesting your Eidolon | Manifest Eidolon). If the creature you summoned or manifested has the (trait: acid), (trait: cold), (trait: electricity), (trait: fire), (trait: sonic), or (trait: water) trait, the damage is that type instead (or cold damage for the (trait: water) trait). If the creature has more than one of these traits, you choose which damage type to deal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18745308-3a9a-42df-a70e-b7662d4d4e3d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
