using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PoisonCoat : Template
    {
        public static readonly Guid ID = Guid.Parse("7615eec8-3336-4679-baab-6d135a0bfff0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Poison Coat",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature adjacent to you hits you with a melee unarmed Strike.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("337ed0bc-38ab-46b7-b0d7-8a46c6210429"), Type = TextBlockType.Text, Text = "In nature, certain animals are covered in venomous spines, such that even touching them is deadly. To use this reaction, you must have brushed poison onto your clothing or woven sharp poisoned needles into the garment’s fabric. This takes 10 minutes and uses one dose of (trait: contact) or (trait: injury) poison. You can have only one such poison suffused into your clothing at a time." };
            yield return new TextBlock { Id = Guid.Parse("5dabe876-8f0a-4b33-b987-83946c3013bc"), Type = TextBlockType.Text, Text = "When you use this reaction, the triggering creature is exposed to the suffused poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3341e4a1-3d19-47c1-a088-d5d7252cbece"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d16d85ef-f742-4079-95b6-4bdf837116f9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
