using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergyFusion : Template
    {
        public static readonly Guid ID = Guid.Parse("c8a35131-eb78-4f2a-a60f-38ccccbbc124");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Fusion",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7db40ff0-9b2d-443f-b87d-6ad220e2fda8"), Type = TextBlockType.Text, Text = $"You fuse two spells together, combining their energy types. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that deals acid, cold, electricity, fire, or sonic damage, select a non-cantrip spell in your spell repertoire that deals a different type of energy damage from that list, and expend an additional spell slot of the same level as this secondary spell. The spell you cast deals additional damage equal to the level of the secondary spell slot expended. The spell's total damage is divided evenly between the energy type of the spell you cast and the energy type of the secondary spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("113c58bf-2c52-44c3-8ee5-1e6c7c3ad2b1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
