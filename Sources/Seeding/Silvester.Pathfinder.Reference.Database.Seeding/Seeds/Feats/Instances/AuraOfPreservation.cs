using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuraOfPreservation : Template
    {
        public static readonly Guid ID = Guid.Parse("5281ded4-94a7-462e-a11b-d52ac9d44cba");

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
            yield return new TextBlock { Id = Guid.Parse("4362987b-16a2-4322-955a-df8747a323e5"), Type = TextBlockType.Text, Text = "Your aura protects against the twisting powers of aberrations. You and all allies within 15 feet gain a +1 status bonus to Fortitude and Will saves against effects from aberrations. You also gain a +1 status bonus to Fortitude saves against morph or polymorph effects and Will saves against mental effects; this bonus increases to +2 against aberrations' morph, polymorph, or mental effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a3a6b1e1-0c06-42c6-8cb1-a8a6b2e3a83b"), Feats.Instances.EsotericOath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("beb06102-0477-4b96-810a-74fadc1db201"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
