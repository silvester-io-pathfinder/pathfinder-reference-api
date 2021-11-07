using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaulerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b2b4afe8-9ab5-42e2-b004-0a19c3e31739");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mauler Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the mauler archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8c1482f-6ce0-475a-80bc-cf8b183b6f28"), Type = TextBlockType.Text, Text = "You specialize in weapons that require two hands. You become trained in all simple and martial melee weapons that require two hands to wield or have the (trait: two-hand) trait. Whenever you gain a class feature that grants you expert or greater proficiency in weapons, you also gain that proficiency rank in these weapons. If you are at least an expert in such a weapon, you gain access to the critical specialization effect with that weapon." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("59f0721f-3b04-4855-a008-79b9c0db03fe"), requiredStatValue: 14, Stats.Instances.Strength.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a6184b1-ceee-4c54-a456-78d464085a42"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
