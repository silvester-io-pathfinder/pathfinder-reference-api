using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuraOfPreservation : Template
    {
        public static readonly Guid ID = Guid.Parse("fdcfb6d5-145a-4fae-beda-8562ba75ba81");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aura of Preservation",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8554bcc-1d27-43fd-bba4-8a2d595475b9"), Type = TextBlockType.Text, Text = "Your aura protects against the twisting powers of aberrations. You and all allies within 15 feet gain a +1 status bonus to Fortitude and Will saves against effects from aberrations. You also gain a +1 status bonus to Fortitude saves against morph or polymorph effects and Will saves against mental effects; this bonus increases to +2 against aberrations’ morph, polymorph, or mental effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7a3a6a38-0783-49d8-a780-a3876dd98c96"), Feats.Instances.EsotericOath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62ca5c6d-9fc1-456a-b31c-4eb1faabee25"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
