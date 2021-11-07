using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergyFusion : Template
    {
        public static readonly Guid ID = Guid.Parse("0681ff2d-5d1e-41cd-ab2b-1c15183cea89");

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
            yield return new TextBlock { Id = Guid.Parse("5616d768-6129-40dd-87ff-d4aa68389d35"), Type = TextBlockType.Text, Text = "You fuse two spells together, combining their energy types. If the next action you use is to (activity: Cast a Spell) that deals acid, cold, electricity, fire, or sonic damage, select a non-cantrip spell in your spell repertoire that deals a different type of energy damage from that list, and expend an additional spell slot of the same level as this secondary spell. The spell you cast deals additional damage equal to the level of the secondary spell slot expended. The spell’s total damage is divided evenly between the energy type of the spell you cast and the energy type of the secondary spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e894d29e-d705-478c-ac00-66e680eb6c09"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
