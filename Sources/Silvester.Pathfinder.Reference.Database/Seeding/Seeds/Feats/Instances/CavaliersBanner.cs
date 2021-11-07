using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CavaliersBanner : Template
    {
        public static readonly Guid ID = Guid.Parse("9dcd1a78-3f17-4722-b35e-176966b86ba9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cavalier's Banner",
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
            yield return new TextBlock { Id = Guid.Parse("7d7b26f7-1127-4b0d-bd61-3e5fed09093d"), Type = TextBlockType.Text, Text = "You fly the banner of your pledge from your mount, raising your allies’ spirits. You and all allies within 30 feet gain a +1 circumstance bonus to Will saves and DCs against (trait: fear) effects. If your banner is destroyed or removed, allies within 30 feet become frightened 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b019f255-ac40-4494-a22d-be47d9980401"), Feats.Instances.CavalierDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17488034-f4d6-459c-a86e-0c945e5127e8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
