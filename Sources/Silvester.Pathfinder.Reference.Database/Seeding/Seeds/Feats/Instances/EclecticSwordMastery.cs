using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EclecticSwordMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("2ae249eb-107b-4a94-8724-10826270a6ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eclectic Sword Mastery",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4db82b4-ec05-4200-918c-a5343e691751"), Type = TextBlockType.Text, Text = "You instinctively learn how to use a sword with just a few practice swings. You change one of the swords designated in your (feat: Tengu Weapon Familiarity) to a new one that you’re wielding, provided the sword meets the specifications of (feat: Tengu Weapon Familiarity). You can (action: Interact) to draw a sword as part of this activity, designating the sword as part of drawing it; disrupting that (action: Interact) action prevents you from designating it as one of your swords. This designation lasts until your next daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d272eb4c-90b3-438d-82e5-643da5f17a01"), Feats.Instances.EclecticSwordTraining.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf3d0d55-82eb-4589-893c-e8a85a6a240f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
