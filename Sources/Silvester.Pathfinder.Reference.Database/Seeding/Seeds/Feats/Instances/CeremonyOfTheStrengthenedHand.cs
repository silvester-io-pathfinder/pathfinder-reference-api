using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CeremonyOfTheStrengthenedHand : Template
    {
        public static readonly Guid ID = Guid.Parse("51de15ad-e5fe-4249-8e36-1dfea64f7760");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ceremony of the Strengthened Hand",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86f585f4-c819-42c5-8ec3-854f474be1fb"), Type = TextBlockType.Text, Text = "Your exoskeleton’s weapons are even more potent. If you have a claws unarmed attack, it gains the (trait: deadly d8) trait. If you have a branch unarmed attack, it gains the (trait: shove) and (trait: trip) traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fc5ec5cb-6c30-4b93-b6ec-e435c4606423"), Feats.Instances.CeremonyOfTheEvenedHand.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fada740-cd0d-43db-8e63-f224bc6c73f5"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
