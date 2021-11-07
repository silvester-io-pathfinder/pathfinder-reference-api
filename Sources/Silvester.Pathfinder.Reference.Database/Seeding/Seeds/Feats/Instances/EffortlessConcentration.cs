using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EffortlessConcentration : Template
    {
        public static readonly Guid ID = Guid.Parse("dfc3e197-57ee-4a8e-825e-500226f78dec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Effortless Concentration",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bba2936f-daa6-4f32-a6d0-b05dcbd478c1"), Type = TextBlockType.Text, Text = "You maintain a spell with hardly a thought. You immediately gain the effects of the (action: Sustain a Spell) action, allowing you to extend the duration of one of your active spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96d29171-7354-47ad-8291-4c2a8e640597"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
