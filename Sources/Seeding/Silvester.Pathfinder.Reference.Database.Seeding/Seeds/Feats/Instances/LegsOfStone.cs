using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegsOfStone : Template
    {
        public static readonly Guid ID = Guid.Parse("35bda0ba-2e94-4f03-a772-29b4a407330d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legs of Stone",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e045bdee-a675-4736-98e3-cceca960e4e7"), Type = TextBlockType.Text, Text = "You gain a +2 status bonus to your Fortitude and Reflex DCs against attempts to (action: Shove) or (action: Trip) you. You can (action: Shove) creatures even if you don't have a hand free. When you successfully (action: Shove) a foe, you can (action: Stride) away from your opponent (instead of toward it), but you must move the same distance in the opposite direction from where you (action: Shoved | Shove) it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("068faf0d-9ecf-4e7c-a025-1121acad808f"), Feats.Instances.GolemGrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a530ad7e-6ce2-47fa-916b-021625a16eb6"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
