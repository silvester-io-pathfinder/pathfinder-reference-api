using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FighterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b37a98b6-ba39-4d8f-a87e-1c360b8cf16a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fighter Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the fighter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d798b75-d181-4821-a1f1-694651fcec92"), Type = TextBlockType.Text, Text = "You become trained in simple weapons and martial weapons. You become trained in your choice of Acrobatics or Athletics; if you are already trained in both of these skills, you instead become trained in a skill of your choice. You become trained in fighter class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("247e4499-b306-4a64-97c4-9fef3784ae60"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificStat(Guid.Parse("bfd7c060-a948-4eeb-817b-3ed542cb95ca"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85689aca-ca59-4a28-9587-97789b10c5de"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
