using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WayfinderResonanceTinkerer : Template
    {
        public static readonly Guid ID = Guid.Parse("f008ca44-c94a-4b65-8408-5913c981de58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wayfinder Resonance Tinkerer",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ced6f05-559e-4877-a84f-369c05e89192"), Type = TextBlockType.Text, Text = "You can use the unusual resonance of your wayfinder to grant it additional effects. Choose one cantrip from the arcane, divine, occult, or primal list. You can activate your wayfinder to cast that cantrip at will. Additionally, you can Activate your wayfinder with a ONE-ACTION (envision) activation to transform it into a nondescript pin or brooch to hide your affiliation with the Pathfinder Society. This transformation lasts for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("79b9a23a-ffb3-495a-9507-a0e452050b1e"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ceca1935-10fa-438e-b682-01b789216cc6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
