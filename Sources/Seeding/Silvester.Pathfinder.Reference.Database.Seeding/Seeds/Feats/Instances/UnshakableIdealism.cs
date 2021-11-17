using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnshakableIdealism : Template
    {
        public static readonly Guid ID = Guid.Parse("0533a8dd-5fdc-4617-bfbc-03d34a394443");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unshakable Idealism",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7530883d-4a88-44ea-8563-20fa39963d95"), Type = TextBlockType.Text, Text = "Your faith and hope can’t be shaken, and you won’t flee when lives are at stake. You gain a +1 circumstance bonus on saves against (trait: fear) effects and (trait: emotion) effects that inflict despair. When you would gain the fleeing condition, you can choose to stand your ground and be stunned for the effect’s duration as well, preventing you from running and allowing you to re-enter the fight more quickly when the effect ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("deabb500-5cd9-49cd-8322-7873d06668f1"), Feats.Instances.KnightVigilantDedication.ID);
            builder.HaveSpecificSavingThrowSpecificProficiency(Guid.Parse("a1f1bf8a-42cb-40fe-8ca8-6a7122a50fd9"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e96a460-a472-48dd-9d9c-42197e91536d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
